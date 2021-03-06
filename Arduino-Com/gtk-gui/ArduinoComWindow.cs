
// This file has been generated by the GUI designer. Do not modify.
public partial class ArduinoComWindow
{
	private global::Gtk.UIManager UIManager;
	private global::Gtk.Action FileAction;
	private global::Gtk.Action HelpAction;
	private global::Gtk.Action quitAction;
	private global::Gtk.Action helpAction;
	private global::Gtk.VBox vbox1;
	private global::Gtk.MenuBar menubar;
	private global::Gtk.HBox hbox2;
	private global::Gtk.Frame frame3;
	private global::Gtk.Alignment GtkAlignment;
	private global::Gtk.VBox vbox3;
	private global::Gtk.VBox vbox9;
	private global::Gtk.HBox hbox7;
	private global::Gtk.Label label6;
	private global::Gtk.VBox vbox10;
	private global::Gtk.ComboBox comboboxPorts;
	private global::Gtk.VBox vbox11;
	private global::Gtk.HBox hbox10;
	private global::Gtk.Label label7;
	private global::Gtk.ComboBox comboboxBaudRate;
	private global::Gtk.VBox vbox4;
	private global::Gtk.Button buttonConnect;
	private global::Gtk.Button buttonDisconnect;
	private global::Gtk.Button buttonRefresh;
	private global::Gtk.Label GtkLabel5;
	private global::Gtk.VBox vbox5;
	private global::Gtk.Frame frameConsole;
	private global::Gtk.Alignment GtkAlignment1;
	private global::Gtk.VBox vbox2;
	private global::Gtk.ScrolledWindow scrollWindowConsole;
	private global::Gtk.TextView textviewConsole;
	private global::Gtk.HBox hbox1;
	private global::Gtk.VBox vbox6;
	private global::Gtk.Frame frame4;
	private global::Gtk.VBox vbox12;
	private global::Gtk.HBox hbox12;
	private global::Gtk.Entry entrySend;
	private global::Gtk.HBox hbox3;
	private global::Gtk.ComboBox comboboxSendType;
	private global::Gtk.Button buttonSendMessage;
	private global::Gtk.Button buttonCopyConsole;
	private global::Gtk.Button buttonClearConsole;
	private global::Gtk.Label GtkLabel18;
	private global::Gtk.HBox hbox4;
	private global::Gtk.Frame frame1;
	private global::Gtk.Alignment GtkAlignment2;
	private global::Gtk.VBox vbox7;
	private global::Gtk.HBox hbox5;
	private global::Gtk.CheckButton checkboxUseLeadingByte;
	private global::Gtk.Entry entryLeadingByte;
	private global::Gtk.HBox hbox6;
	private global::Gtk.CheckButton checkboxUseTrailingByte;
	private global::Gtk.Entry entryTrailingByte;
	private global::Gtk.CheckButton checkboxClearInputOnSend;
	private global::Gtk.CheckButton checkboxSendOnEnter;
	private global::Gtk.Label GtkLabel13;
	private global::Gtk.Frame frame2;
	private global::Gtk.Alignment GtkAlignment3;
	private global::Gtk.VBox vbox8;
	private global::Gtk.CheckButton checkboxShowSends;
	private global::Gtk.CheckButton checkboxAutoScroll;
	private global::Gtk.Label GtkLabel16;
	private global::Gtk.Label GtkLabel17;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget ArduinoComWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.FileAction = new global::Gtk.Action ("FileAction", global::Mono.Unix.Catalog.GetString ("File"), null, null);
		this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("File");
		w1.Add (this.FileAction, null);
		this.HelpAction = new global::Gtk.Action ("HelpAction", global::Mono.Unix.Catalog.GetString ("Help"), null, null);
		this.HelpAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Help");
		w1.Add (this.HelpAction, null);
		this.quitAction = new global::Gtk.Action ("quitAction", global::Mono.Unix.Catalog.GetString ("Exit"), null, "gtk-quit");
		this.quitAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Exit");
		w1.Add (this.quitAction, null);
		this.helpAction = new global::Gtk.Action ("helpAction", global::Mono.Unix.Catalog.GetString ("About"), null, "gtk-help");
		this.helpAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("About");
		w1.Add (this.helpAction, null);
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "ArduinoComWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("Arduino Com");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child ArduinoComWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><menubar name=\'menubar\'><menu name=\'FileAction\' action=\'FileAction\'><menuitem" +
			" name=\'quitAction\' action=\'quitAction\'/></menu><menu name=\'HelpAction\' action=\'H" +
			"elpAction\'><menuitem name=\'helpAction\' action=\'helpAction\'/></menu></menubar></u" +
			"i>");
		this.menubar = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar")));
		this.menubar.Name = "menubar";
		this.vbox1.Add (this.menubar);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.menubar]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox ();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.frame3 = new global::Gtk.Frame ();
		this.frame3.Name = "frame3";
		// Container child frame3.Gtk.Container+ContainerChild
		this.GtkAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment.Name = "GtkAlignment";
		this.GtkAlignment.LeftPadding = ((uint)(6));
		this.GtkAlignment.TopPadding = ((uint)(6));
		this.GtkAlignment.RightPadding = ((uint)(6));
		this.GtkAlignment.BottomPadding = ((uint)(6));
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		this.vbox3 = new global::Gtk.VBox ();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.vbox9 = new global::Gtk.VBox ();
		this.vbox9.Name = "vbox9";
		this.vbox9.Spacing = 6;
		// Container child vbox9.Gtk.Box+BoxChild
		this.hbox7 = new global::Gtk.HBox ();
		this.hbox7.Name = "hbox7";
		this.hbox7.Spacing = 6;
		// Container child hbox7.Gtk.Box+BoxChild
		this.label6 = new global::Gtk.Label ();
		this.label6.Name = "label6";
		this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Port");
		this.hbox7.Add (this.label6);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.label6]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		this.vbox9.Add (this.hbox7);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.hbox7]));
		w4.Position = 0;
		w4.Expand = false;
		w4.Fill = false;
		this.vbox3.Add (this.vbox9);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.vbox9]));
		w5.Position = 0;
		w5.Expand = false;
		w5.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.vbox10 = new global::Gtk.VBox ();
		this.vbox10.Name = "vbox10";
		this.vbox10.Spacing = 6;
		// Container child vbox10.Gtk.Box+BoxChild
		this.comboboxPorts = global::Gtk.ComboBox.NewText ();
		this.comboboxPorts.WidthRequest = 110;
		this.comboboxPorts.Name = "comboboxPorts";
		this.vbox10.Add (this.comboboxPorts);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox10 [this.comboboxPorts]));
		w6.Position = 0;
		w6.Expand = false;
		w6.Fill = false;
		// Container child vbox10.Gtk.Box+BoxChild
		this.vbox11 = new global::Gtk.VBox ();
		this.vbox11.Name = "vbox11";
		this.vbox11.Spacing = 6;
		// Container child vbox11.Gtk.Box+BoxChild
		this.hbox10 = new global::Gtk.HBox ();
		this.hbox10.Name = "hbox10";
		this.hbox10.Spacing = 6;
		// Container child hbox10.Gtk.Box+BoxChild
		this.label7 = new global::Gtk.Label ();
		this.label7.Name = "label7";
		this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("Baud Rate");
		this.hbox10.Add (this.label7);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox10 [this.label7]));
		w7.Position = 0;
		w7.Expand = false;
		w7.Fill = false;
		this.vbox11.Add (this.hbox10);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox11 [this.hbox10]));
		w8.Position = 0;
		w8.Expand = false;
		w8.Fill = false;
		// Container child vbox11.Gtk.Box+BoxChild
		this.comboboxBaudRate = global::Gtk.ComboBox.NewText ();
		this.comboboxBaudRate.AppendText (global::Mono.Unix.Catalog.GetString ("300"));
		this.comboboxBaudRate.AppendText (global::Mono.Unix.Catalog.GetString ("600"));
		this.comboboxBaudRate.AppendText (global::Mono.Unix.Catalog.GetString ("1200"));
		this.comboboxBaudRate.AppendText (global::Mono.Unix.Catalog.GetString ("2400"));
		this.comboboxBaudRate.AppendText (global::Mono.Unix.Catalog.GetString ("4800"));
		this.comboboxBaudRate.AppendText (global::Mono.Unix.Catalog.GetString ("9600"));
		this.comboboxBaudRate.AppendText (global::Mono.Unix.Catalog.GetString ("14400"));
		this.comboboxBaudRate.AppendText (global::Mono.Unix.Catalog.GetString ("19200"));
		this.comboboxBaudRate.AppendText (global::Mono.Unix.Catalog.GetString ("28800"));
		this.comboboxBaudRate.AppendText (global::Mono.Unix.Catalog.GetString ("38400"));
		this.comboboxBaudRate.AppendText (global::Mono.Unix.Catalog.GetString ("57600"));
		this.comboboxBaudRate.AppendText (global::Mono.Unix.Catalog.GetString ("115200"));
		this.comboboxBaudRate.WidthRequest = 110;
		this.comboboxBaudRate.Name = "comboboxBaudRate";
		this.comboboxBaudRate.Active = 5;
		this.comboboxBaudRate.HasFrame = false;
		this.vbox11.Add (this.comboboxBaudRate);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox11 [this.comboboxBaudRate]));
		w9.Position = 1;
		w9.Expand = false;
		w9.Fill = false;
		this.vbox10.Add (this.vbox11);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox10 [this.vbox11]));
		w10.PackType = ((global::Gtk.PackType)(1));
		w10.Position = 1;
		w10.Expand = false;
		w10.Fill = false;
		this.vbox3.Add (this.vbox10);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.vbox10]));
		w11.Position = 1;
		w11.Expand = false;
		w11.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.vbox4 = new global::Gtk.VBox ();
		this.vbox4.Name = "vbox4";
		this.vbox4.Spacing = 6;
		// Container child vbox4.Gtk.Box+BoxChild
		this.buttonConnect = new global::Gtk.Button ();
		this.buttonConnect.Sensitive = false;
		this.buttonConnect.CanFocus = true;
		this.buttonConnect.Name = "buttonConnect";
		this.buttonConnect.UseUnderline = true;
		this.buttonConnect.Label = global::Mono.Unix.Catalog.GetString ("Connect");
		this.vbox4.Add (this.buttonConnect);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.buttonConnect]));
		w12.Position = 0;
		w12.Expand = false;
		w12.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.buttonDisconnect = new global::Gtk.Button ();
		this.buttonDisconnect.Sensitive = false;
		this.buttonDisconnect.CanFocus = true;
		this.buttonDisconnect.Name = "buttonDisconnect";
		this.buttonDisconnect.UseUnderline = true;
		this.buttonDisconnect.Label = global::Mono.Unix.Catalog.GetString ("Disconnect");
		this.vbox4.Add (this.buttonDisconnect);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.buttonDisconnect]));
		w13.Position = 1;
		w13.Expand = false;
		w13.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.buttonRefresh = new global::Gtk.Button ();
		this.buttonRefresh.Sensitive = false;
		this.buttonRefresh.CanFocus = true;
		this.buttonRefresh.Name = "buttonRefresh";
		this.buttonRefresh.UseUnderline = true;
		this.buttonRefresh.Label = global::Mono.Unix.Catalog.GetString ("Refresh");
		this.vbox4.Add (this.buttonRefresh);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.buttonRefresh]));
		w14.PackType = ((global::Gtk.PackType)(1));
		w14.Position = 2;
		w14.Expand = false;
		w14.Fill = false;
		this.vbox3.Add (this.vbox4);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.vbox4]));
		w15.Position = 2;
		w15.Expand = false;
		w15.Fill = false;
		this.GtkAlignment.Add (this.vbox3);
		this.frame3.Add (this.GtkAlignment);
		this.GtkLabel5 = new global::Gtk.Label ();
		this.GtkLabel5.Name = "GtkLabel5";
		this.GtkLabel5.LabelProp = global::Mono.Unix.Catalog.GetString ("Connection");
		this.GtkLabel5.UseMarkup = true;
		this.frame3.LabelWidget = this.GtkLabel5;
		this.hbox2.Add (this.frame3);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.frame3]));
		w18.Position = 0;
		w18.Expand = false;
		w18.Fill = false;
		w18.Padding = ((uint)(6));
		// Container child hbox2.Gtk.Box+BoxChild
		this.vbox5 = new global::Gtk.VBox ();
		this.vbox5.Name = "vbox5";
		this.vbox5.Spacing = 6;
		// Container child vbox5.Gtk.Box+BoxChild
		this.frameConsole = new global::Gtk.Frame ();
		this.frameConsole.Name = "frameConsole";
		// Container child frameConsole.Gtk.Container+ContainerChild
		this.GtkAlignment1 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment1.Name = "GtkAlignment1";
		this.GtkAlignment1.LeftPadding = ((uint)(6));
		this.GtkAlignment1.TopPadding = ((uint)(6));
		this.GtkAlignment1.RightPadding = ((uint)(6));
		this.GtkAlignment1.BottomPadding = ((uint)(6));
		// Container child GtkAlignment1.Gtk.Container+ContainerChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.scrollWindowConsole = new global::Gtk.ScrolledWindow ();
		this.scrollWindowConsole.Name = "scrollWindowConsole";
		this.scrollWindowConsole.VscrollbarPolicy = ((global::Gtk.PolicyType)(0));
		this.scrollWindowConsole.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child scrollWindowConsole.Gtk.Container+ContainerChild
		this.textviewConsole = new global::Gtk.TextView ();
		this.textviewConsole.CanFocus = true;
		this.textviewConsole.Name = "textviewConsole";
		this.textviewConsole.Editable = false;
		this.scrollWindowConsole.Add (this.textviewConsole);
		this.vbox2.Add (this.scrollWindowConsole);
		global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.scrollWindowConsole]));
		w20.Position = 0;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.vbox6 = new global::Gtk.VBox ();
		this.vbox6.Name = "vbox6";
		this.vbox6.Spacing = 6;
		// Container child vbox6.Gtk.Box+BoxChild
		this.frame4 = new global::Gtk.Frame ();
		this.frame4.Name = "frame4";
		// Container child frame4.Gtk.Container+ContainerChild
		this.vbox12 = new global::Gtk.VBox ();
		this.vbox12.Name = "vbox12";
		this.vbox12.Spacing = 6;
		// Container child vbox12.Gtk.Box+BoxChild
		this.hbox12 = new global::Gtk.HBox ();
		this.hbox12.Name = "hbox12";
		this.hbox12.Spacing = 6;
		// Container child hbox12.Gtk.Box+BoxChild
		this.entrySend = new global::Gtk.Entry ();
		this.entrySend.TooltipMarkup = "Input";
		this.entrySend.CanFocus = true;
		this.entrySend.Name = "entrySend";
		this.entrySend.IsEditable = true;
		this.entrySend.InvisibleChar = '•';
		this.hbox12.Add (this.entrySend);
		global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox12 [this.entrySend]));
		w21.Position = 0;
		w21.Padding = ((uint)(3));
		this.vbox12.Add (this.hbox12);
		global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox12 [this.hbox12]));
		w22.Position = 0;
		w22.Expand = false;
		w22.Fill = false;
		w22.Padding = ((uint)(3));
		// Container child vbox12.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox ();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.comboboxSendType = global::Gtk.ComboBox.NewText ();
		this.comboboxSendType.AppendText (global::Mono.Unix.Catalog.GetString ("String"));
		this.comboboxSendType.AppendText (global::Mono.Unix.Catalog.GetString ("Int"));
		this.comboboxSendType.AppendText (global::Mono.Unix.Catalog.GetString ("Long"));
		this.comboboxSendType.AppendText (global::Mono.Unix.Catalog.GetString ("Float"));
		this.comboboxSendType.AppendText (global::Mono.Unix.Catalog.GetString ("Double"));
		this.comboboxSendType.AppendText (global::Mono.Unix.Catalog.GetString ("Byte Array"));
		this.comboboxSendType.CanDefault = true;
		this.comboboxSendType.Name = "comboboxSendType";
		this.comboboxSendType.Active = 0;
		this.hbox3.Add (this.comboboxSendType);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.comboboxSendType]));
		w23.Position = 0;
		w23.Expand = false;
		w23.Fill = false;
		w23.Padding = ((uint)(3));
		// Container child hbox3.Gtk.Box+BoxChild
		this.buttonSendMessage = new global::Gtk.Button ();
		this.buttonSendMessage.CanFocus = true;
		this.buttonSendMessage.Name = "buttonSendMessage";
		this.buttonSendMessage.UseUnderline = true;
		this.buttonSendMessage.Label = global::Mono.Unix.Catalog.GetString ("Send Message");
		this.hbox3.Add (this.buttonSendMessage);
		global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.buttonSendMessage]));
		w24.Position = 1;
		w24.Expand = false;
		w24.Fill = false;
		w24.Padding = ((uint)(3));
		// Container child hbox3.Gtk.Box+BoxChild
		this.buttonCopyConsole = new global::Gtk.Button ();
		this.buttonCopyConsole.CanFocus = true;
		this.buttonCopyConsole.Name = "buttonCopyConsole";
		this.buttonCopyConsole.UseUnderline = true;
		this.buttonCopyConsole.Label = global::Mono.Unix.Catalog.GetString ("Copy Console");
		this.hbox3.Add (this.buttonCopyConsole);
		global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.buttonCopyConsole]));
		w25.Position = 2;
		w25.Expand = false;
		w25.Fill = false;
		w25.Padding = ((uint)(3));
		// Container child hbox3.Gtk.Box+BoxChild
		this.buttonClearConsole = new global::Gtk.Button ();
		this.buttonClearConsole.CanFocus = true;
		this.buttonClearConsole.Name = "buttonClearConsole";
		this.buttonClearConsole.UseUnderline = true;
		this.buttonClearConsole.Label = global::Mono.Unix.Catalog.GetString ("Clear Console");
		this.hbox3.Add (this.buttonClearConsole);
		global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.buttonClearConsole]));
		w26.Position = 3;
		w26.Expand = false;
		w26.Fill = false;
		w26.Padding = ((uint)(3));
		this.vbox12.Add (this.hbox3);
		global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox12 [this.hbox3]));
		w27.Position = 1;
		w27.Expand = false;
		w27.Fill = false;
		w27.Padding = ((uint)(3));
		this.frame4.Add (this.vbox12);
		this.GtkLabel18 = new global::Gtk.Label ();
		this.GtkLabel18.Name = "GtkLabel18";
		this.GtkLabel18.LabelProp = global::Mono.Unix.Catalog.GetString ("Console Entry");
		this.GtkLabel18.UseMarkup = true;
		this.frame4.LabelWidget = this.GtkLabel18;
		this.vbox6.Add (this.frame4);
		global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.frame4]));
		w29.Position = 0;
		// Container child vbox6.Gtk.Box+BoxChild
		this.hbox4 = new global::Gtk.HBox ();
		this.hbox4.Name = "hbox4";
		this.hbox4.Spacing = 6;
		// Container child hbox4.Gtk.Box+BoxChild
		this.frame1 = new global::Gtk.Frame ();
		this.frame1.Name = "frame1";
		// Container child frame1.Gtk.Container+ContainerChild
		this.GtkAlignment2 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment2.Name = "GtkAlignment2";
		this.GtkAlignment2.LeftPadding = ((uint)(12));
		// Container child GtkAlignment2.Gtk.Container+ContainerChild
		this.vbox7 = new global::Gtk.VBox ();
		this.vbox7.Name = "vbox7";
		this.vbox7.Spacing = 6;
		// Container child vbox7.Gtk.Box+BoxChild
		this.hbox5 = new global::Gtk.HBox ();
		this.hbox5.Name = "hbox5";
		this.hbox5.Spacing = 6;
		// Container child hbox5.Gtk.Box+BoxChild
		this.checkboxUseLeadingByte = new global::Gtk.CheckButton ();
		this.checkboxUseLeadingByte.CanFocus = true;
		this.checkboxUseLeadingByte.Name = "checkboxUseLeadingByte";
		this.checkboxUseLeadingByte.Label = global::Mono.Unix.Catalog.GetString ("Use Leading Byte");
		this.checkboxUseLeadingByte.DrawIndicator = true;
		this.checkboxUseLeadingByte.UseUnderline = true;
		this.hbox5.Add (this.checkboxUseLeadingByte);
		global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.checkboxUseLeadingByte]));
		w30.Position = 0;
		// Container child hbox5.Gtk.Box+BoxChild
		this.entryLeadingByte = new global::Gtk.Entry ();
		this.entryLeadingByte.CanFocus = true;
		this.entryLeadingByte.Name = "entryLeadingByte";
		this.entryLeadingByte.Text = global::Mono.Unix.Catalog.GetString ("0x00");
		this.entryLeadingByte.IsEditable = true;
		this.entryLeadingByte.WidthChars = 4;
		this.entryLeadingByte.MaxLength = 4;
		this.entryLeadingByte.InvisibleChar = '•';
		this.hbox5.Add (this.entryLeadingByte);
		global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.entryLeadingByte]));
		w31.Position = 1;
		w31.Expand = false;
		w31.Fill = false;
		this.vbox7.Add (this.hbox5);
		global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.hbox5]));
		w32.Position = 0;
		w32.Expand = false;
		w32.Fill = false;
		// Container child vbox7.Gtk.Box+BoxChild
		this.hbox6 = new global::Gtk.HBox ();
		this.hbox6.Name = "hbox6";
		this.hbox6.Spacing = 6;
		// Container child hbox6.Gtk.Box+BoxChild
		this.checkboxUseTrailingByte = new global::Gtk.CheckButton ();
		this.checkboxUseTrailingByte.CanFocus = true;
		this.checkboxUseTrailingByte.Name = "checkboxUseTrailingByte";
		this.checkboxUseTrailingByte.Label = global::Mono.Unix.Catalog.GetString ("Use Trailing Byte");
		this.checkboxUseTrailingByte.DrawIndicator = true;
		this.checkboxUseTrailingByte.UseUnderline = true;
		this.hbox6.Add (this.checkboxUseTrailingByte);
		global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.checkboxUseTrailingByte]));
		w33.Position = 0;
		// Container child hbox6.Gtk.Box+BoxChild
		this.entryTrailingByte = new global::Gtk.Entry ();
		this.entryTrailingByte.CanFocus = true;
		this.entryTrailingByte.Name = "entryTrailingByte";
		this.entryTrailingByte.Text = global::Mono.Unix.Catalog.GetString ("0x00");
		this.entryTrailingByte.IsEditable = true;
		this.entryTrailingByte.WidthChars = 4;
		this.entryTrailingByte.MaxLength = 4;
		this.entryTrailingByte.InvisibleChar = '•';
		this.hbox6.Add (this.entryTrailingByte);
		global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.entryTrailingByte]));
		w34.Position = 1;
		w34.Expand = false;
		w34.Fill = false;
		this.vbox7.Add (this.hbox6);
		global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.hbox6]));
		w35.Position = 1;
		w35.Expand = false;
		w35.Fill = false;
		// Container child vbox7.Gtk.Box+BoxChild
		this.checkboxClearInputOnSend = new global::Gtk.CheckButton ();
		this.checkboxClearInputOnSend.CanFocus = true;
		this.checkboxClearInputOnSend.Name = "checkboxClearInputOnSend";
		this.checkboxClearInputOnSend.Label = global::Mono.Unix.Catalog.GetString ("Clear Input On Send");
		this.checkboxClearInputOnSend.DrawIndicator = true;
		this.checkboxClearInputOnSend.UseUnderline = true;
		this.vbox7.Add (this.checkboxClearInputOnSend);
		global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.checkboxClearInputOnSend]));
		w36.Position = 2;
		w36.Expand = false;
		w36.Fill = false;
		// Container child vbox7.Gtk.Box+BoxChild
		this.checkboxSendOnEnter = new global::Gtk.CheckButton ();
		this.checkboxSendOnEnter.CanFocus = true;
		this.checkboxSendOnEnter.Name = "checkboxSendOnEnter";
		this.checkboxSendOnEnter.Label = global::Mono.Unix.Catalog.GetString ("Send On Enter");
		this.checkboxSendOnEnter.Active = true;
		this.checkboxSendOnEnter.DrawIndicator = true;
		this.checkboxSendOnEnter.UseUnderline = true;
		this.vbox7.Add (this.checkboxSendOnEnter);
		global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.checkboxSendOnEnter]));
		w37.Position = 3;
		w37.Expand = false;
		w37.Fill = false;
		this.GtkAlignment2.Add (this.vbox7);
		this.frame1.Add (this.GtkAlignment2);
		this.GtkLabel13 = new global::Gtk.Label ();
		this.GtkLabel13.Name = "GtkLabel13";
		this.GtkLabel13.LabelProp = global::Mono.Unix.Catalog.GetString ("Send Options");
		this.GtkLabel13.UseMarkup = true;
		this.frame1.LabelWidget = this.GtkLabel13;
		this.hbox4.Add (this.frame1);
		global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.frame1]));
		w40.Position = 0;
		w40.Expand = false;
		w40.Fill = false;
		// Container child hbox4.Gtk.Box+BoxChild
		this.frame2 = new global::Gtk.Frame ();
		this.frame2.Name = "frame2";
		// Container child frame2.Gtk.Container+ContainerChild
		this.GtkAlignment3 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment3.Name = "GtkAlignment3";
		this.GtkAlignment3.LeftPadding = ((uint)(12));
		// Container child GtkAlignment3.Gtk.Container+ContainerChild
		this.vbox8 = new global::Gtk.VBox ();
		this.vbox8.Name = "vbox8";
		this.vbox8.Spacing = 6;
		// Container child vbox8.Gtk.Box+BoxChild
		this.checkboxShowSends = new global::Gtk.CheckButton ();
		this.checkboxShowSends.CanFocus = true;
		this.checkboxShowSends.Name = "checkboxShowSends";
		this.checkboxShowSends.Label = global::Mono.Unix.Catalog.GetString ("Show Sends");
		this.checkboxShowSends.Active = true;
		this.checkboxShowSends.DrawIndicator = true;
		this.checkboxShowSends.UseUnderline = true;
		this.vbox8.Add (this.checkboxShowSends);
		global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.checkboxShowSends]));
		w41.Position = 0;
		w41.Expand = false;
		w41.Fill = false;
		// Container child vbox8.Gtk.Box+BoxChild
		this.checkboxAutoScroll = new global::Gtk.CheckButton ();
		this.checkboxAutoScroll.CanFocus = true;
		this.checkboxAutoScroll.Name = "checkboxAutoScroll";
		this.checkboxAutoScroll.Label = global::Mono.Unix.Catalog.GetString ("Auto Scroll");
		this.checkboxAutoScroll.Active = true;
		this.checkboxAutoScroll.DrawIndicator = true;
		this.checkboxAutoScroll.UseUnderline = true;
		this.vbox8.Add (this.checkboxAutoScroll);
		global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.checkboxAutoScroll]));
		w42.Position = 1;
		w42.Expand = false;
		w42.Fill = false;
		this.GtkAlignment3.Add (this.vbox8);
		this.frame2.Add (this.GtkAlignment3);
		this.GtkLabel16 = new global::Gtk.Label ();
		this.GtkLabel16.Name = "GtkLabel16";
		this.GtkLabel16.LabelProp = global::Mono.Unix.Catalog.GetString ("Console Options");
		this.GtkLabel16.UseMarkup = true;
		this.frame2.LabelWidget = this.GtkLabel16;
		this.hbox4.Add (this.frame2);
		global::Gtk.Box.BoxChild w45 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.frame2]));
		w45.Position = 1;
		this.vbox6.Add (this.hbox4);
		global::Gtk.Box.BoxChild w46 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.hbox4]));
		w46.Position = 1;
		w46.Expand = false;
		w46.Fill = false;
		this.hbox1.Add (this.vbox6);
		global::Gtk.Box.BoxChild w47 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox6]));
		w47.Position = 0;
		this.vbox2.Add (this.hbox1);
		global::Gtk.Box.BoxChild w48 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox1]));
		w48.Position = 1;
		w48.Expand = false;
		w48.Fill = false;
		this.GtkAlignment1.Add (this.vbox2);
		this.frameConsole.Add (this.GtkAlignment1);
		this.GtkLabel17 = new global::Gtk.Label ();
		this.GtkLabel17.Name = "GtkLabel17";
		this.GtkLabel17.LabelProp = global::Mono.Unix.Catalog.GetString ("Console");
		this.GtkLabel17.UseMarkup = true;
		this.frameConsole.LabelWidget = this.GtkLabel17;
		this.vbox5.Add (this.frameConsole);
		global::Gtk.Box.BoxChild w51 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.frameConsole]));
		w51.Position = 0;
		this.hbox2.Add (this.vbox5);
		global::Gtk.Box.BoxChild w52 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.vbox5]));
		w52.Position = 1;
		this.vbox1.Add (this.hbox2);
		global::Gtk.Box.BoxChild w53 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox2]));
		w53.Position = 1;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 629;
		this.DefaultHeight = 519;
		this.comboboxSendType.HasDefault = true;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.quitAction.Activated += new global::System.EventHandler (this.OnQuitActionActivated);
		this.helpAction.Activated += new global::System.EventHandler (this.OnHelpActionActivated);
		this.buttonConnect.Clicked += new global::System.EventHandler (this.OnButtonConnectClicked);
		this.buttonDisconnect.Clicked += new global::System.EventHandler (this.OnButtonDisconnectClicked);
		this.buttonRefresh.Clicked += new global::System.EventHandler (this.OnButtonRefreshClicked);
		this.buttonSendMessage.Clicked += new global::System.EventHandler (this.OnButtonSendMessageClicked);
		this.buttonCopyConsole.Clicked += new global::System.EventHandler (this.OnButtonCopyConsoleClicked);
		this.buttonClearConsole.Clicked += new global::System.EventHandler (this.OnButtonClearConsoleClicked);
	}
}
