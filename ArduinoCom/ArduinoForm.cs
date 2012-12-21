using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace ArduinoCom
{
    public partial class ArduinoForm : Form
    {
        Boolean mContinue;
        SerialPort serialPort;
        Thread threadRead;
        AboutArduinoCom helpForm;
        Encoding encoding;

        public ArduinoForm()
        {
            encoding = new System.Text.ASCIIEncoding();
            InitializeComponent();
            fillComList();
            helpForm = new AboutArduinoCom();
            lstDataTypes.SetSelected(0, true);
            this.FormClosing += formClosing;
        }

        private delegate void UpdateConsoleCallback(String msg);
        private void UpdateConsole(String msg)
        {
            lstConsole.Items.Add(msg);
            if (chkBoxAutoScroll.Checked)
                lstConsole.TopIndex = Math.Max(lstConsole.Items.Count - (lstConsole.ClientSize.Height / lstConsole.ItemHeight) + 1, 0);
        }

        private void ThreadRead()
        {
            while (mContinue)
            {
                try
                {
                    lstConsole.BeginInvoke(new UpdateConsoleCallback(UpdateConsole), serialPort.ReadLine());
                }
                catch (Exception)
                {
                }
            }
        }

        private void doDisconnect()
        {
            // Signal the thread to stop working
            mContinue = false;

            // Close the port
            if (serialPort != null && serialPort.IsOpen)
            {
                try
                {
                    serialPort.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to disconnect from device.", "Error");
                }
                UpdateConsole("Disconnected from " + serialPort.PortName);
            }

            //  Join the thread if it happens to still be open
            if (threadRead != null)
                threadRead.Join();
        }

        private void fillComList()
        {
            lstComPorts.Items.Clear();
            foreach (String port in SerialPort.GetPortNames())
                lstComPorts.Items.Add(port);

            lstComPorts.SetSelected(0, true);
        }

        private void btnConnect_Click(object sender, System.EventArgs e)
        {
            if (lstComPorts.SelectedItem == null)
            {
                MessageBox.Show("You must select a COM port to continue.", "Error");
            }
            else
            {
                try
                {
                    String comPort = lstComPorts.SelectedItem.ToString();
                    int baud = 9600;
                    serialPort = new SerialPort(comPort, baud);
                    serialPort.Open();
                    UpdateConsole("Connected to " + comPort + " at " + baud);
                    btnConnect.Enabled = false;
                    btnDisconnect.Enabled = true;
                    lstComPorts.Enabled = false;
                    groupBoxConsole.Enabled = true;

                    mContinue = true;
                    threadRead = new Thread(new ThreadStart(ThreadRead));
                    threadRead.Start();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDisconnect_Click(object sender, System.EventArgs e)
        {
            doDisconnect();

            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            lstComPorts.Enabled = true;
            groupBoxConsole.Enabled = false;
        }

        private void txtBoxData_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnSendMsg.PerformClick();
            }
        }

        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            byte[] sendBytes = null;
            Exception parseException = null;
            try
            {
                switch (lstDataTypes.SelectedItem.ToString())
                {
                    case "Byte Array":
                        // Send a byte array. ie 0xFF 0x81 (Int16 -127)
                        String[] bytes = txtBoxData.Text.Split(' ');
                        sendBytes = new Byte[bytes.Length];
                        for (int i = 0; i < bytes.Length; i++)
                            sendBytes[i] = Convert.ToByte(bytes[i], 16);
                        break;
                    case "Int":
                        // Arduino Int is Int16
                        sendBytes = BitConverter.GetBytes(Int16.Parse(txtBoxData.Text));
                        if (BitConverter.IsLittleEndian)
                            Array.Reverse(sendBytes);
                        break;
                    case "Long":
                        // Arduino Long is Int32
                        sendBytes = BitConverter.GetBytes(Int32.Parse(txtBoxData.Text));
                        if (BitConverter.IsLittleEndian)
                            Array.Reverse(sendBytes);
                        break;
                    case "Float":
                        float floatVal = float.Parse(txtBoxData.Text);
                        sendBytes = BitConverter.GetBytes(floatVal);
                        if (BitConverter.IsLittleEndian)
                            Array.Reverse(sendBytes);
                        break;
                    case "Double":
                        double doubleVal = Double.Parse(txtBoxData.Text);
                        sendBytes = BitConverter.GetBytes(doubleVal);
                        if (BitConverter.IsLittleEndian)
                            Array.Reverse(sendBytes);
                        break;
                    case "String":
                    default:
                        sendBytes = encoding.GetBytes(txtBoxData.Text);
                        break;
                }
            }
            catch (Exception ex)
            {
                parseException = ex;
            }

            if (parseException != null)
            {
                MessageBox.Show("Invalid Message: " + parseException.Message, "Error");
                return;
            }
            else if (sendBytes != null)
            {
                // If leading or trailing is enabled, the source byte[] will need to be copied to a 
                // new byte array to make room for the leading and trailing
                if (chkBoxUseLeadingByte.Checked || chkBoxUseTrailingByte.Checked)
                {
                    // Create a new byte[] to store the leading and/or trailing bytes
                    int newByteArrayLength = sendBytes.Length;
                    if (chkBoxUseLeadingByte.Checked)
                        newByteArrayLength++;
                    if (chkBoxUseTrailingByte.Checked)
                        newByteArrayLength++;
                    byte[] newSendBytes = new byte[newByteArrayLength];

                    if (chkBoxUseTrailingByte.Checked)
                    {
                        try
                        {
                            newSendBytes[newSendBytes.Length - 1] = Convert.ToByte(txtBoxUseTrailingByte.Text, 16);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Invalid format entered for trailing byte. Must be in 0x00 format.");
                            txtBoxUseTrailingByte.Text = "0x00";
                        }
                    }


                    if (chkBoxUseLeadingByte.Checked)
                    {
                        // Copy the byte[] to the new byte[] at position 1
                        try
                        {
                            newSendBytes[0] = Convert.ToByte(txtBoxUseLeadingByte.Text, 16);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Invalid format entered for leading byte. Must be in 0x00 format.");
                            txtBoxUseLeadingByte.Text = "0x00";
                        }
                        Array.Copy(sendBytes, 0, newSendBytes, 1, sendBytes.Length);
                    }
                    else
                    {
                        // Copy the byte[] to the new byte[] at position 0
                        Array.Copy(sendBytes, 0, newSendBytes, 0, sendBytes.Length);
                    }

                    // Send the new byte[]
                    sendBytes = newSendBytes;
                }
                try
                {
                    serialPort.Write(sendBytes, 0, sendBytes.Length);
                    if (chkBoxShowSends.Checked)
                        UpdateConsole("SEND MSG: " + txtBoxData.Text);

                    if (chkBoxClearInputOnSend.Checked)
                        txtBoxData.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to send data to device.", "Error");
                    UpdateConsole("ERROR: Failed to send data to device");
                }
            }
        }

        private void btnClearConsole_Click(object sender, EventArgs e)
        {
            lstConsole.Items.Clear();
        }

        private void btnCopyConsole_Click(object sender, EventArgs e)
        {
            String data = "";
            foreach (String row in lstConsole.Items)
                data += row + "\n";

            if (data == null)
            {
                MessageBox.Show("Failed to copy to clipboard.", "Error");
            }
            else
            {
                Clipboard.SetText(data);
            }
        }

        private void chkBoxUseLeadingByte_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxUseLeadingByte.Enabled = chkBoxUseLeadingByte.Checked;
        }

        private void chkBoxTrailingByte_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxUseTrailingByte.Enabled = chkBoxUseTrailingByte.Checked;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helpForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doDisconnect();
            Environment.Exit(0);
        }

        private void formClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            doDisconnect();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            fillComList();
        }
    }
}
