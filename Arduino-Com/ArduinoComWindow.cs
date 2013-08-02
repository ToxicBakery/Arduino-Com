using System;
using Gtk;
using ArduinoCom;
using System.Reflection;
using System.IO.Ports;
using System.Threading;
using System.Text;
using Gdk;

public partial class ArduinoComWindow: Gtk.Window
{	
	private static Gdk.Atom _atom = Gdk.Atom.Intern ("CLIPBOARD", false);
	private Gtk.Clipboard mClipBoard = Gtk.Clipboard.Get (_atom);
	private Encoding mEncoding;
	private SerialPort mSerialPort;
	private Thread mConnectionThread;
	private Boolean isReading;

	public ArduinoComWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		Init ();
	}

	//
	// EVENTS
	//

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Quit ();
	}

	protected void OnQuitActionActivated (object sender, EventArgs e)
	{
		Quit ();
	}

	protected void OnHelpActionActivated (object sender, EventArgs e)
	{
		AssemblyName assemName = Assembly.GetExecutingAssembly ().GetName ();

		AcAboutDialog about = new AcAboutDialog ();
		about.Version = assemName.Version.ToString ();
		about.Run ();
		about.Destroy ();
	}

	protected void OnButtonConnectClicked (object sender, EventArgs e)
	{
		if (comboboxPorts.Active != -1) {
			try {
				// Open the port
				int baudRate = Int32.Parse (comboboxBaudRate.ActiveText);
				mSerialPort = new SerialPort (comboboxPorts.ActiveText, baudRate);
				mSerialPort.DataReceived += DataReceivedHandler;
				mSerialPort.Open ();

				// Notify user
				UpdateConsole ("Connected to " + comboboxPorts.ActiveText + " at " + baudRate);

				// Update the GUI
				UpdateGUI ();
			} catch (Exception ex) {
				Console.WriteLine (ex.StackTrace);
				ShowError (ex.Message);
			}
		}
	}

	private void DataReceivedHandler (object sender, EventArgs e)
	{
		if (!isReading) {
			isReading = true;
			mConnectionThread = new Thread (new ThreadStart (MonitorData));
			mConnectionThread.Start ();
		}
	}

	private void MonitorData ()
	{
		try {
			// Read the data to a string
			String received = "";
			while (mSerialPort.BytesToRead > 0)
				received += mSerialPort.ReadLine ();

			// Notify GTK to update the console
			Gtk.Application.Invoke (delegate {
				textviewConsole.Buffer.Text += received;
				ScrollToEnd();
			});
		} catch (Exception) {
		}
		isReading = false;
	}

	protected void OnButtonDisconnectClicked (object sender, EventArgs e)
	{
		Disconnect ();
	}

	protected void OnButtonRefreshClicked (object sender, EventArgs e)
	{
		UpdateComPorts ();
	}

	protected void OnButtonSendMessageClicked (object sender, EventArgs e)
	{
		byte[] sendBytes = null;
		Exception parseException = null;
		String msgType = comboboxSendType.ActiveText.Trim();

		try {
			switch (msgType) {
			case "Byte Array":
				// Send a byte array. ie 0xFF 0x81 (Int16 -127)
				String[] bytes = entrySend.Text.Split (' ');
				sendBytes = new Byte[bytes.Length];
				for (int i = 0; i < bytes.Length; i++)
					sendBytes [i] = Convert.ToByte (bytes [i], 16);
				break;
			case "Int":
				// Arduino Int is Int16
				sendBytes = BitConverter.GetBytes (Int16.Parse (entrySend.Text));
				if (BitConverter.IsLittleEndian)
					Array.Reverse (sendBytes);
				break;
			case "Long":
				// Arduino Long is Int32
				sendBytes = BitConverter.GetBytes (Int32.Parse (entrySend.Text));
				if (BitConverter.IsLittleEndian)
					Array.Reverse (sendBytes);
				break;
			case "Float":
				float floatVal = float.Parse (entrySend.Text);
				sendBytes = BitConverter.GetBytes (floatVal);
				if (BitConverter.IsLittleEndian)
					Array.Reverse (sendBytes);
				break;
			case "Double":
				double doubleVal = Double.Parse (entrySend.Text);
				sendBytes = BitConverter.GetBytes (doubleVal);
				if (BitConverter.IsLittleEndian)
					Array.Reverse (sendBytes);
				break;
			case "String":
			default:
				sendBytes = mEncoding.GetBytes (entrySend.Text);
				break;
			}
		} catch (Exception ex) {
			parseException = ex;
		}
		
		if (parseException != null) {
			ShowError ("Invalid Message: " + parseException.Message);
			return;
		} else if (sendBytes != null) {
			// If leading or trailing is enabled, the source byte[] will need to be copied to a 
			// new byte array to make room for the leading and trailing
			if (checkboxUseLeadingByte.Active || checkboxUseTrailingByte.Active) {
				// Create a new byte[] to store the leading and/or trailing bytes
				int newByteArrayLength = sendBytes.Length;
				if (checkboxUseLeadingByte.Active)
					newByteArrayLength++;
				if (checkboxUseTrailingByte.Active)
					newByteArrayLength++;
				byte[] newSendBytes = new byte[newByteArrayLength];
				
				if (checkboxUseTrailingByte.Active) {
					try {
						newSendBytes [newSendBytes.Length - 1] = Convert.ToByte (entryTrailingByte.Text, 16);
					} catch (Exception) {
						ShowError ("Invalid format entered for trailing byte. Must be in 0x00 format.");
						entryTrailingByte.Text = "0x00";
					}
				}
				
				
				if (checkboxUseLeadingByte.Active) {
					// Copy the byte[] to the new byte[] at position 1
					try {
						newSendBytes [0] = Convert.ToByte (entryLeadingByte.Text, 16);
					} catch (Exception) {
						ShowError ("Invalid format entered for leading byte. Must be in 0x00 format.");
						entryLeadingByte.Text = "0x00";
					}
					Array.Copy (sendBytes, 0, newSendBytes, 1, sendBytes.Length);
				} else {
					// Copy the byte[] to the new byte[] at position 0
					Array.Copy (sendBytes, 0, newSendBytes, 0, sendBytes.Length);
				}
				
				// Send the new byte[]
				sendBytes = newSendBytes;
			}
			try {
				mSerialPort.Write (sendBytes, 0, sendBytes.Length);
				if (checkboxShowSends.Active)
					UpdateConsole ("SEND " + msgType +": " + entrySend.Text);
				
				if (checkboxClearInputOnSend.Active)
					entrySend.Text = "";
			} catch (Exception) {
				ShowError ("Failed to send data to device.");
				UpdateConsole ("ERROR: Failed to send data to device");
			}
		}
	}

	protected void OnButtonClearConsoleClicked (object sender, EventArgs e)
	{
		textviewConsole.Buffer.Clear ();
	}

	protected void OnButtonCopyConsoleClicked (object sender, EventArgs e)
	{
		mClipBoard.Text = textviewConsole.Buffer.Text;
	}

	//
	// PRIVATE METHODS
	//

	private void Disconnect ()
	{
		if (mSerialPort != null && mSerialPort.IsOpen) {
			try {
				mSerialPort.Close ();
			} catch (Exception) {

			}
			UpdateConsole ("Disconnected from " + mSerialPort.PortName);
		}

		if (mConnectionThread != null)
			mConnectionThread.Join ();

		UpdateGUI ();
	}

	private void Init ()
	{
		textviewConsole.Buffer.Changed += ConsoleUpdated;
		mEncoding = new System.Text.ASCIIEncoding ();
		UpdateComPorts ();
		UpdateGUI ();
	}

	private void ConsoleUpdated (object sender, EventArgs e)
	{
		Gtk.Application.Invoke (delegate {
			ScrollToEnd();
		});
	}


	private Boolean IsConnected ()
	{
		return mSerialPort != null && mSerialPort.IsOpen;
	}

	private void UpdateComPorts ()
	{
		while (comboboxPorts.Active != -1) {
			comboboxPorts.RemoveText (0);
			comboboxPorts.Active = 0;
		}

		foreach (String port in SerialPort.GetPortNames())
			if (!port.ToString ().Trim ().Equals (""))
				comboboxPorts.AppendText (port.ToString ().Trim ());

		comboboxPorts.Active = 0;
		buttonConnect.Sensitive = comboboxPorts.Active != -1;
	}

	private void UpdateConsole (String msg)
	{
		textviewConsole.Buffer.Text += msg + "\n";
	}

	private void UpdateGUI ()
	{
		buttonConnect.Sensitive = !IsConnected ();
		buttonDisconnect.Sensitive = IsConnected ();
		buttonRefresh.Sensitive = !IsConnected ();
		frameConsole.Sensitive = IsConnected ();
	}

	private void ShowError (String msg)
	{
		MessageDialog msgDialog = new MessageDialog (this, DialogFlags.DestroyWithParent, MessageType.Error, ButtonsType.Close, msg, "");
		msgDialog.Run ();
		msgDialog.Destroy ();
	}

	private void Quit ()
	{
		Disconnect ();
		Application.Quit ();
		Environment.Exit (0);
	}

	private void ScrollToEnd ()
	{
		if (!checkboxAutoScroll.Active)
			return;

		textviewConsole.ScrollToIter(textviewConsole.Buffer.EndIter, 0, true, 0, 0);
	}

}