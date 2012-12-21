namespace ArduinoCom
{
    partial class ArduinoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConnect = new System.Windows.Forms.Button();
            this.lstComPorts = new System.Windows.Forms.ListBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.lstConsole = new System.Windows.Forms.ListBox();
            this.txtBoxData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstDataTypes = new System.Windows.Forms.ListBox();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.groupBoxConsole = new System.Windows.Forms.GroupBox();
            this.grpBoxConsoleOptions = new System.Windows.Forms.GroupBox();
            this.chkBoxAutoScroll = new System.Windows.Forms.CheckBox();
            this.chkBoxShowSends = new System.Windows.Forms.CheckBox();
            this.grpBoxAdvancedSend = new System.Windows.Forms.GroupBox();
            this.chkBoxClearInputOnSend = new System.Windows.Forms.CheckBox();
            this.txtBoxUseTrailingByte = new System.Windows.Forms.TextBox();
            this.chkBoxUseTrailingByte = new System.Windows.Forms.CheckBox();
            this.txtBoxUseLeadingByte = new System.Windows.Forms.TextBox();
            this.chkBoxUseLeadingByte = new System.Windows.Forms.CheckBox();
            this.btnCopyConsole = new System.Windows.Forms.Button();
            this.btnClearConsole = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxConnection = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBoxConsole.SuspendLayout();
            this.grpBoxConsoleOptions.SuspendLayout();
            this.grpBoxAdvancedSend.SuspendLayout();
            this.groupBoxConnection.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(6, 120);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(122, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lstComPorts
            // 
            this.lstComPorts.FormattingEnabled = true;
            this.lstComPorts.Location = new System.Drawing.Point(6, 19);
            this.lstComPorts.Name = "lstComPorts";
            this.lstComPorts.Size = new System.Drawing.Size(122, 95);
            this.lstComPorts.TabIndex = 1;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(6, 149);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(122, 23);
            this.btnDisconnect.TabIndex = 2;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // lstConsole
            // 
            this.lstConsole.FormattingEnabled = true;
            this.lstConsole.HorizontalScrollbar = true;
            this.lstConsole.Location = new System.Drawing.Point(6, 19);
            this.lstConsole.Name = "lstConsole";
            this.lstConsole.ScrollAlwaysVisible = true;
            this.lstConsole.Size = new System.Drawing.Size(369, 251);
            this.lstConsole.TabIndex = 3;
            // 
            // txtBoxData
            // 
            this.txtBoxData.Location = new System.Drawing.Point(98, 289);
            this.txtBoxData.Name = "txtBoxData";
            this.txtBoxData.Size = new System.Drawing.Size(277, 20);
            this.txtBoxData.TabIndex = 4;
            this.txtBoxData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxData_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Input";
            // 
            // lstDataTypes
            // 
            this.lstDataTypes.FormattingEnabled = true;
            this.lstDataTypes.Items.AddRange(new object[] {
            "String",
            "Int",
            "Long",
            "Float",
            "Double",
            "Byte Array"});
            this.lstDataTypes.Location = new System.Drawing.Point(6, 289);
            this.lstDataTypes.Name = "lstDataTypes";
            this.lstDataTypes.Size = new System.Drawing.Size(86, 82);
            this.lstDataTypes.TabIndex = 6;
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Location = new System.Drawing.Point(98, 315);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(98, 23);
            this.btnSendMsg.TabIndex = 7;
            this.btnSendMsg.Text = "Send Message";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // groupBoxConsole
            // 
            this.groupBoxConsole.AutoSize = true;
            this.groupBoxConsole.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxConsole.Controls.Add(this.grpBoxConsoleOptions);
            this.groupBoxConsole.Controls.Add(this.grpBoxAdvancedSend);
            this.groupBoxConsole.Controls.Add(this.btnCopyConsole);
            this.groupBoxConsole.Controls.Add(this.btnClearConsole);
            this.groupBoxConsole.Controls.Add(this.label2);
            this.groupBoxConsole.Controls.Add(this.btnSendMsg);
            this.groupBoxConsole.Controls.Add(this.lstDataTypes);
            this.groupBoxConsole.Controls.Add(this.label1);
            this.groupBoxConsole.Controls.Add(this.txtBoxData);
            this.groupBoxConsole.Controls.Add(this.lstConsole);
            this.groupBoxConsole.Enabled = false;
            this.groupBoxConsole.Location = new System.Drawing.Point(152, 27);
            this.groupBoxConsole.Name = "groupBoxConsole";
            this.groupBoxConsole.Size = new System.Drawing.Size(381, 464);
            this.groupBoxConsole.TabIndex = 8;
            this.groupBoxConsole.TabStop = false;
            this.groupBoxConsole.Text = "Console";
            // 
            // grpBoxConsoleOptions
            // 
            this.grpBoxConsoleOptions.Controls.Add(this.chkBoxAutoScroll);
            this.grpBoxConsoleOptions.Controls.Add(this.chkBoxShowSends);
            this.grpBoxConsoleOptions.Location = new System.Drawing.Point(266, 344);
            this.grpBoxConsoleOptions.Name = "grpBoxConsoleOptions";
            this.grpBoxConsoleOptions.Size = new System.Drawing.Size(109, 69);
            this.grpBoxConsoleOptions.TabIndex = 16;
            this.grpBoxConsoleOptions.TabStop = false;
            this.grpBoxConsoleOptions.Text = "Console Options";
            // 
            // chkBoxAutoScroll
            // 
            this.chkBoxAutoScroll.AutoSize = true;
            this.chkBoxAutoScroll.Checked = true;
            this.chkBoxAutoScroll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxAutoScroll.Location = new System.Drawing.Point(16, 42);
            this.chkBoxAutoScroll.Name = "chkBoxAutoScroll";
            this.chkBoxAutoScroll.Size = new System.Drawing.Size(77, 17);
            this.chkBoxAutoScroll.TabIndex = 12;
            this.chkBoxAutoScroll.Text = "Auto Scroll";
            this.chkBoxAutoScroll.UseVisualStyleBackColor = true;
            // 
            // chkBoxShowSends
            // 
            this.chkBoxShowSends.AutoSize = true;
            this.chkBoxShowSends.Checked = true;
            this.chkBoxShowSends.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxShowSends.Location = new System.Drawing.Point(16, 19);
            this.chkBoxShowSends.Name = "chkBoxShowSends";
            this.chkBoxShowSends.Size = new System.Drawing.Size(86, 17);
            this.chkBoxShowSends.TabIndex = 11;
            this.chkBoxShowSends.Text = "Show Sends";
            this.chkBoxShowSends.UseVisualStyleBackColor = true;
            // 
            // grpBoxAdvancedSend
            // 
            this.grpBoxAdvancedSend.AutoSize = true;
            this.grpBoxAdvancedSend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpBoxAdvancedSend.Controls.Add(this.chkBoxClearInputOnSend);
            this.grpBoxAdvancedSend.Controls.Add(this.txtBoxUseTrailingByte);
            this.grpBoxAdvancedSend.Controls.Add(this.chkBoxUseTrailingByte);
            this.grpBoxAdvancedSend.Controls.Add(this.txtBoxUseLeadingByte);
            this.grpBoxAdvancedSend.Controls.Add(this.chkBoxUseLeadingByte);
            this.grpBoxAdvancedSend.Location = new System.Drawing.Point(98, 344);
            this.grpBoxAdvancedSend.Name = "grpBoxAdvancedSend";
            this.grpBoxAdvancedSend.Size = new System.Drawing.Size(154, 101);
            this.grpBoxAdvancedSend.TabIndex = 15;
            this.grpBoxAdvancedSend.TabStop = false;
            this.grpBoxAdvancedSend.Text = "Send Options";
            // 
            // chkBoxClearInputOnSend
            // 
            this.chkBoxClearInputOnSend.AutoSize = true;
            this.chkBoxClearInputOnSend.Location = new System.Drawing.Point(6, 65);
            this.chkBoxClearInputOnSend.Name = "chkBoxClearInputOnSend";
            this.chkBoxClearInputOnSend.Size = new System.Drawing.Size(122, 17);
            this.chkBoxClearInputOnSend.TabIndex = 17;
            this.chkBoxClearInputOnSend.Text = "Clear Input On Send";
            this.chkBoxClearInputOnSend.UseVisualStyleBackColor = true;
            // 
            // txtBoxUseTrailingByte
            // 
            this.txtBoxUseTrailingByte.Enabled = false;
            this.txtBoxUseTrailingByte.Location = new System.Drawing.Point(118, 40);
            this.txtBoxUseTrailingByte.Name = "txtBoxUseTrailingByte";
            this.txtBoxUseTrailingByte.Size = new System.Drawing.Size(30, 20);
            this.txtBoxUseTrailingByte.TabIndex = 16;
            this.txtBoxUseTrailingByte.Text = "0x00";
            // 
            // chkBoxUseTrailingByte
            // 
            this.chkBoxUseTrailingByte.AutoSize = true;
            this.chkBoxUseTrailingByte.Location = new System.Drawing.Point(6, 42);
            this.chkBoxUseTrailingByte.Name = "chkBoxUseTrailingByte";
            this.chkBoxUseTrailingByte.Size = new System.Drawing.Size(106, 17);
            this.chkBoxUseTrailingByte.TabIndex = 15;
            this.chkBoxUseTrailingByte.Text = "Use Trailing Byte";
            this.chkBoxUseTrailingByte.UseVisualStyleBackColor = true;
            this.chkBoxUseTrailingByte.CheckedChanged += new System.EventHandler(this.chkBoxTrailingByte_CheckedChanged);
            // 
            // txtBoxUseLeadingByte
            // 
            this.txtBoxUseLeadingByte.Enabled = false;
            this.txtBoxUseLeadingByte.Location = new System.Drawing.Point(118, 17);
            this.txtBoxUseLeadingByte.Name = "txtBoxUseLeadingByte";
            this.txtBoxUseLeadingByte.Size = new System.Drawing.Size(30, 20);
            this.txtBoxUseLeadingByte.TabIndex = 14;
            this.txtBoxUseLeadingByte.Text = "0x00";
            // 
            // chkBoxUseLeadingByte
            // 
            this.chkBoxUseLeadingByte.AutoSize = true;
            this.chkBoxUseLeadingByte.Location = new System.Drawing.Point(6, 19);
            this.chkBoxUseLeadingByte.Name = "chkBoxUseLeadingByte";
            this.chkBoxUseLeadingByte.Size = new System.Drawing.Size(110, 17);
            this.chkBoxUseLeadingByte.TabIndex = 13;
            this.chkBoxUseLeadingByte.Text = "Use Leading Byte";
            this.chkBoxUseLeadingByte.UseVisualStyleBackColor = true;
            this.chkBoxUseLeadingByte.CheckedChanged += new System.EventHandler(this.chkBoxUseLeadingByte_CheckedChanged);
            // 
            // btnCopyConsole
            // 
            this.btnCopyConsole.Location = new System.Drawing.Point(202, 315);
            this.btnCopyConsole.Name = "btnCopyConsole";
            this.btnCopyConsole.Size = new System.Drawing.Size(81, 23);
            this.btnCopyConsole.TabIndex = 10;
            this.btnCopyConsole.Text = "Copy Console";
            this.btnCopyConsole.UseVisualStyleBackColor = true;
            this.btnCopyConsole.Click += new System.EventHandler(this.btnCopyConsole_Click);
            // 
            // btnClearConsole
            // 
            this.btnClearConsole.Location = new System.Drawing.Point(289, 315);
            this.btnClearConsole.Name = "btnClearConsole";
            this.btnClearConsole.Size = new System.Drawing.Size(86, 23);
            this.btnClearConsole.TabIndex = 9;
            this.btnClearConsole.Text = "Clear Console";
            this.btnClearConsole.UseVisualStyleBackColor = true;
            this.btnClearConsole.Click += new System.EventHandler(this.btnClearConsole_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Data Type";
            // 
            // groupBoxConnection
            // 
            this.groupBoxConnection.AutoSize = true;
            this.groupBoxConnection.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxConnection.Controls.Add(this.btnRefresh);
            this.groupBoxConnection.Controls.Add(this.lstComPorts);
            this.groupBoxConnection.Controls.Add(this.btnConnect);
            this.groupBoxConnection.Controls.Add(this.btnDisconnect);
            this.groupBoxConnection.Location = new System.Drawing.Point(12, 27);
            this.groupBoxConnection.Name = "groupBoxConnection";
            this.groupBoxConnection.Size = new System.Drawing.Size(134, 220);
            this.groupBoxConnection.TabIndex = 9;
            this.groupBoxConnection.TabStop = false;
            this.groupBoxConnection.Text = "Connection";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(543, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(6, 178);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(122, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ArduinoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(543, 499);
            this.Controls.Add(this.groupBoxConnection);
            this.Controls.Add(this.groupBoxConsole);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "ArduinoForm";
            this.Text = "Arduino Connect";
            this.groupBoxConsole.ResumeLayout(false);
            this.groupBoxConsole.PerformLayout();
            this.grpBoxConsoleOptions.ResumeLayout(false);
            this.grpBoxConsoleOptions.PerformLayout();
            this.grpBoxAdvancedSend.ResumeLayout(false);
            this.grpBoxAdvancedSend.PerformLayout();
            this.groupBoxConnection.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ListBox lstComPorts;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.ListBox lstConsole;
        private System.Windows.Forms.TextBox txtBoxData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstDataTypes;
        private System.Windows.Forms.Button btnSendMsg;
        private System.Windows.Forms.GroupBox groupBoxConsole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxConnection;
        private System.Windows.Forms.Button btnClearConsole;
        private System.Windows.Forms.Button btnCopyConsole;
        private System.Windows.Forms.CheckBox chkBoxShowSends;
        private System.Windows.Forms.CheckBox chkBoxAutoScroll;
        private System.Windows.Forms.TextBox txtBoxUseLeadingByte;
        private System.Windows.Forms.CheckBox chkBoxUseLeadingByte;
        private System.Windows.Forms.GroupBox grpBoxConsoleOptions;
        private System.Windows.Forms.GroupBox grpBoxAdvancedSend;
        private System.Windows.Forms.TextBox txtBoxUseTrailingByte;
        private System.Windows.Forms.CheckBox chkBoxUseTrailingByte;
        private System.Windows.Forms.CheckBox chkBoxClearInputOnSend;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnRefresh;
    }
}

