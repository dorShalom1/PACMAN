namespace PACMAN
{
    partial class FormAddAtt
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxAttType = new System.Windows.Forms.ComboBox();
            this.comboBoxConType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxComPort = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxBaudRate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panelHttp = new System.Windows.Forms.Panel();
            this.textBoxHttpPort = new System.Windows.Forms.TextBox();
            this.textBoxHttpIp = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelUsb = new System.Windows.Forms.Panel();
            this.comboBoxDeviceId = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.comboBoxStopBits = new System.Windows.Forms.ComboBox();
            this.comboBoxDataBits = new System.Windows.Forms.ComboBox();
            this.panelSerial = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panelHttp.SuspendLayout();
            this.panelUsb.SuspendLayout();
            this.panelSerial.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(90, 354);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 27);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PACMAN.Properties.Resources.pacmanMenu;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 28);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "";
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormAddAtt_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::PACMAN.Properties.Resources.pacmanMenu;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::PACMAN.Properties.Resources.pacmanX1;
            this.pictureBox2.Location = new System.Drawing.Point(214, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textBoxDescription);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.comboBoxAttType);
            this.panel3.Controls.Add(this.comboBoxConType);
            this.panel3.Location = new System.Drawing.Point(11, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(231, 101);
            this.panel3.TabIndex = 24;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxDescription.Location = new System.Drawing.Point(93, 4);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(131, 20);
            this.textBoxDescription.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Attenuator Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Connection Type";
            // 
            // comboBoxAttType
            // 
            this.comboBoxAttType.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBoxAttType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAttType.FormattingEnabled = true;
            this.comboBoxAttType.Items.AddRange(new object[] {
            "RUDAT",
            "RCDAT"});
            this.comboBoxAttType.Location = new System.Drawing.Point(93, 38);
            this.comboBoxAttType.Name = "comboBoxAttType";
            this.comboBoxAttType.Size = new System.Drawing.Size(131, 21);
            this.comboBoxAttType.TabIndex = 4;
            // 
            // comboBoxConType
            // 
            this.comboBoxConType.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBoxConType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConType.FormattingEnabled = true;
            this.comboBoxConType.Items.AddRange(new object[] {
            "HTTP",
            "TELNET",
            "USB",
            "SERIAL"});
            this.comboBoxConType.Location = new System.Drawing.Point(93, 75);
            this.comboBoxConType.Name = "comboBoxConType";
            this.comboBoxConType.Size = new System.Drawing.Size(131, 21);
            this.comboBoxConType.TabIndex = 5;
            this.comboBoxConType.SelectedIndexChanged += new System.EventHandler(this.comboBoxConType_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "COM Port #";
            // 
            // comboBoxComPort
            // 
            this.comboBoxComPort.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBoxComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComPort.FormattingEnabled = true;
            this.comboBoxComPort.Location = new System.Drawing.Point(93, 8);
            this.comboBoxComPort.Name = "comboBoxComPort";
            this.comboBoxComPort.Size = new System.Drawing.Size(129, 21);
            this.comboBoxComPort.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Baud Rate";
            // 
            // textBoxBaudRate
            // 
            this.textBoxBaudRate.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxBaudRate.Location = new System.Drawing.Point(93, 35);
            this.textBoxBaudRate.Name = "textBoxBaudRate";
            this.textBoxBaudRate.Size = new System.Drawing.Size(129, 20);
            this.textBoxBaudRate.TabIndex = 10;
            this.textBoxBaudRate.Text = "9600";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Parity";
            // 
            // panelHttp
            // 
            this.panelHttp.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelHttp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelHttp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHttp.Controls.Add(this.textBoxHttpPort);
            this.panelHttp.Controls.Add(this.textBoxHttpIp);
            this.panelHttp.Controls.Add(this.labelPort);
            this.panelHttp.Controls.Add(this.label4);
            this.panelHttp.Location = new System.Drawing.Point(11, 145);
            this.panelHttp.Name = "panelHttp";
            this.panelHttp.Size = new System.Drawing.Size(229, 70);
            this.panelHttp.TabIndex = 6;
            // 
            // textBoxHttpPort
            // 
            this.textBoxHttpPort.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxHttpPort.Location = new System.Drawing.Point(93, 38);
            this.textBoxHttpPort.Name = "textBoxHttpPort";
            this.textBoxHttpPort.Size = new System.Drawing.Size(129, 20);
            this.textBoxHttpPort.TabIndex = 9;
            this.textBoxHttpPort.Text = "80";
            // 
            // textBoxHttpIp
            // 
            this.textBoxHttpIp.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxHttpIp.Location = new System.Drawing.Point(93, 9);
            this.textBoxHttpIp.Name = "textBoxHttpIp";
            this.textBoxHttpIp.Size = new System.Drawing.Size(129, 20);
            this.textBoxHttpIp.TabIndex = 7;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelPort.ForeColor = System.Drawing.Color.White;
            this.labelPort.Location = new System.Drawing.Point(3, 41);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(26, 13);
            this.labelPort.TabIndex = 8;
            this.labelPort.Text = "Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "IP Address";
            // 
            // panelUsb
            // 
            this.panelUsb.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelUsb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelUsb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUsb.Controls.Add(this.comboBoxDeviceId);
            this.panelUsb.Controls.Add(this.label7);
            this.panelUsb.Location = new System.Drawing.Point(11, 145);
            this.panelUsb.Name = "panelUsb";
            this.panelUsb.Size = new System.Drawing.Size(229, 44);
            this.panelUsb.TabIndex = 10;
            this.panelUsb.Visible = false;
            // 
            // comboBoxDeviceId
            // 
            this.comboBoxDeviceId.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBoxDeviceId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDeviceId.FormattingEnabled = true;
            this.comboBoxDeviceId.Location = new System.Drawing.Point(93, 9);
            this.comboBoxDeviceId.Name = "comboBoxDeviceId";
            this.comboBoxDeviceId.Size = new System.Drawing.Size(129, 21);
            this.comboBoxDeviceId.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Usb Device ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Data Bits";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Stop Bits";
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBoxParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.comboBoxParity.Location = new System.Drawing.Point(93, 60);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(129, 21);
            this.comboBoxParity.TabIndex = 17;
            // 
            // comboBoxStopBits
            // 
            this.comboBoxStopBits.AutoCompleteCustomSource.AddRange(new string[] {
            "None",
            "One"});
            this.comboBoxStopBits.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBoxStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStopBits.FormattingEnabled = true;
            this.comboBoxStopBits.Items.AddRange(new object[] {
            "None",
            "1",
            "1.5",
            "2"});
            this.comboBoxStopBits.Location = new System.Drawing.Point(93, 113);
            this.comboBoxStopBits.Name = "comboBoxStopBits";
            this.comboBoxStopBits.Size = new System.Drawing.Size(129, 21);
            this.comboBoxStopBits.TabIndex = 18;
            // 
            // comboBoxDataBits
            // 
            this.comboBoxDataBits.AutoCompleteCustomSource.AddRange(new string[] {
            "None",
            "One"});
            this.comboBoxDataBits.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBoxDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDataBits.FormattingEnabled = true;
            this.comboBoxDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.comboBoxDataBits.Location = new System.Drawing.Point(93, 87);
            this.comboBoxDataBits.Name = "comboBoxDataBits";
            this.comboBoxDataBits.Size = new System.Drawing.Size(129, 21);
            this.comboBoxDataBits.TabIndex = 19;
            // 
            // panelSerial
            // 
            this.panelSerial.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelSerial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSerial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSerial.Controls.Add(this.comboBoxDataBits);
            this.panelSerial.Controls.Add(this.comboBoxStopBits);
            this.panelSerial.Controls.Add(this.comboBoxParity);
            this.panelSerial.Controls.Add(this.label10);
            this.panelSerial.Controls.Add(this.label9);
            this.panelSerial.Controls.Add(this.label8);
            this.panelSerial.Controls.Add(this.textBoxBaudRate);
            this.panelSerial.Controls.Add(this.label6);
            this.panelSerial.Controls.Add(this.comboBoxComPort);
            this.panelSerial.Controls.Add(this.label5);
            this.panelSerial.Location = new System.Drawing.Point(11, 145);
            this.panelSerial.Name = "panelSerial";
            this.panelSerial.Size = new System.Drawing.Size(231, 146);
            this.panelSerial.TabIndex = 25;
            this.panelSerial.Visible = false;
            // 
            // FormAddAtt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = global::PACMAN.Properties.Resources.pacmanAdd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(254, 404);
            this.Controls.Add(this.panelSerial);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelUsb);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.panelHttp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddAtt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Attenuator";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormAddAtt_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelHttp.ResumeLayout(false);
            this.panelHttp.PerformLayout();
            this.panelUsb.ResumeLayout(false);
            this.panelUsb.PerformLayout();
            this.panelSerial.ResumeLayout(false);
            this.panelSerial.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxAttType;
        private System.Windows.Forms.ComboBox comboBoxConType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxComPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxBaudRate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelHttp;
        private System.Windows.Forms.TextBox textBoxHttpPort;
        private System.Windows.Forms.TextBox textBoxHttpIp;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelUsb;
        private System.Windows.Forms.ComboBox comboBoxDeviceId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.ComboBox comboBoxStopBits;
        private System.Windows.Forms.ComboBox comboBoxDataBits;
        private System.Windows.Forms.Panel panelSerial;
    }
}