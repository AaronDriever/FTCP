namespace FTCP
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbBaud = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.radioButtonLED1 = new System.Windows.Forms.RadioButton();
            this.radioButtonLED2 = new System.Windows.Forms.RadioButton();
            this.radioButtonLED3 = new System.Windows.Forms.RadioButton();
            this.radioButtonLED4 = new System.Windows.Forms.RadioButton();
            this.radioButtonLED5 = new System.Windows.Forms.RadioButton();
            this.radioButtonLED6 = new System.Windows.Forms.RadioButton();
            this.radioButtonLED7 = new System.Windows.Forms.RadioButton();
            this.radioButtonLED8 = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.radioButtonOFF = new System.Windows.Forms.RadioButton();
            this.radioButtonON = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.cmbBaud);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbPort);
            this.groupBox1.Controls.Add(this.buttonStop);
            this.groupBox1.Controls.Add(this.buttonStart);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 57);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COMMS";
            // 
            // cmbBaud
            // 
            this.cmbBaud.FormattingEnabled = true;
            this.cmbBaud.Location = new System.Drawing.Point(87, 19);
            this.cmbBaud.Name = "cmbBaud";
            this.cmbBaud.Size = new System.Drawing.Size(71, 21);
            this.cmbBaud.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "by A.D 2014";
            // 
            // cmbPort
            // 
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Location = new System.Drawing.Point(9, 19);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(61, 21);
            this.cmbPort.TabIndex = 3;
            this.cmbPort.SelectedIndexChanged += new System.EventHandler(this.cmbPort_SelectedIndexChanged);
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(277, 17);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(64, 23);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Disconect";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click_1);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(181, 17);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(64, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Connect";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click_1);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.sendButton);
            this.groupBox4.Controls.Add(this.richTextBox1);
            this.groupBox4.Location = new System.Drawing.Point(12, 353);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(468, 52);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Raw Sentence";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(386, 16);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 1;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.SendButton);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(9, 16);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(360, 23);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(125, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 272);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lighting";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.trackBarBlue);
            this.groupBox6.Location = new System.Drawing.Point(6, 183);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(250, 76);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Blue";
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarBlue.LargeChange = 15;
            this.trackBarBlue.Location = new System.Drawing.Point(6, 19);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(238, 45);
            this.trackBarBlue.TabIndex = 1;
            this.trackBarBlue.TickFrequency = 15;
            this.trackBarBlue.Scroll += new System.EventHandler(this.trackBarBlue_Scroll);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.trackBarGreen);
            this.groupBox5.Location = new System.Drawing.Point(6, 101);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(250, 76);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Green";
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarGreen.LargeChange = 15;
            this.trackBarGreen.Location = new System.Drawing.Point(6, 19);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(238, 45);
            this.trackBarGreen.TabIndex = 1;
            this.trackBarGreen.TickFrequency = 15;
            this.trackBarGreen.Scroll += new System.EventHandler(this.trackBarGreen_Scroll);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.trackBarRed);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 76);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Red";
            // 
            // trackBarRed
            // 
            this.trackBarRed.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarRed.LargeChange = 15;
            this.trackBarRed.Location = new System.Drawing.Point(6, 18);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(238, 45);
            this.trackBarRed.TabIndex = 1;
            this.trackBarRed.TickFrequency = 15;
            this.trackBarRed.Scroll += new System.EventHandler(this.trackBarRed_Scroll);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Location = new System.Drawing.Point(6, 11);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(36, 17);
            this.radioButtonAll.TabIndex = 7;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "All";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            this.radioButtonAll.CheckedChanged += new System.EventHandler(this.radioButtonAll_CheckedChanged);
            // 
            // radioButtonLED1
            // 
            this.radioButtonLED1.AutoSize = true;
            this.radioButtonLED1.Location = new System.Drawing.Point(6, 37);
            this.radioButtonLED1.Name = "radioButtonLED1";
            this.radioButtonLED1.Size = new System.Drawing.Size(55, 17);
            this.radioButtonLED1.TabIndex = 8;
            this.radioButtonLED1.TabStop = true;
            this.radioButtonLED1.Text = "LED 1";
            this.radioButtonLED1.UseVisualStyleBackColor = true;
            this.radioButtonLED1.CheckedChanged += new System.EventHandler(this.radioButtonLED1_CheckedChanged);
            // 
            // radioButtonLED2
            // 
            this.radioButtonLED2.AutoSize = true;
            this.radioButtonLED2.Location = new System.Drawing.Point(6, 66);
            this.radioButtonLED2.Name = "radioButtonLED2";
            this.radioButtonLED2.Size = new System.Drawing.Size(55, 17);
            this.radioButtonLED2.TabIndex = 9;
            this.radioButtonLED2.TabStop = true;
            this.radioButtonLED2.Text = "LED 2";
            this.radioButtonLED2.UseVisualStyleBackColor = true;
            this.radioButtonLED2.CheckedChanged += new System.EventHandler(this.radioButtonLED2_CheckedChanged);
            // 
            // radioButtonLED3
            // 
            this.radioButtonLED3.AutoSize = true;
            this.radioButtonLED3.Location = new System.Drawing.Point(6, 94);
            this.radioButtonLED3.Name = "radioButtonLED3";
            this.radioButtonLED3.Size = new System.Drawing.Size(55, 17);
            this.radioButtonLED3.TabIndex = 10;
            this.radioButtonLED3.TabStop = true;
            this.radioButtonLED3.Text = "LED 3";
            this.radioButtonLED3.UseVisualStyleBackColor = true;
            this.radioButtonLED3.CheckedChanged += new System.EventHandler(this.radioButtonLED3_CheckedChanged);
            // 
            // radioButtonLED4
            // 
            this.radioButtonLED4.AutoSize = true;
            this.radioButtonLED4.Location = new System.Drawing.Point(6, 127);
            this.radioButtonLED4.Name = "radioButtonLED4";
            this.radioButtonLED4.Size = new System.Drawing.Size(55, 17);
            this.radioButtonLED4.TabIndex = 11;
            this.radioButtonLED4.TabStop = true;
            this.radioButtonLED4.Text = "LED 4";
            this.radioButtonLED4.UseVisualStyleBackColor = true;
            this.radioButtonLED4.CheckedChanged += new System.EventHandler(this.radioButtonLED4_CheckedChanged);
            // 
            // radioButtonLED5
            // 
            this.radioButtonLED5.AutoSize = true;
            this.radioButtonLED5.Location = new System.Drawing.Point(6, 158);
            this.radioButtonLED5.Name = "radioButtonLED5";
            this.radioButtonLED5.Size = new System.Drawing.Size(55, 17);
            this.radioButtonLED5.TabIndex = 12;
            this.radioButtonLED5.TabStop = true;
            this.radioButtonLED5.Text = "LED 5";
            this.radioButtonLED5.UseVisualStyleBackColor = true;
            this.radioButtonLED5.CheckedChanged += new System.EventHandler(this.radioButtonLED5_CheckedChanged);
            // 
            // radioButtonLED6
            // 
            this.radioButtonLED6.AutoSize = true;
            this.radioButtonLED6.Location = new System.Drawing.Point(6, 190);
            this.radioButtonLED6.Name = "radioButtonLED6";
            this.radioButtonLED6.Size = new System.Drawing.Size(55, 17);
            this.radioButtonLED6.TabIndex = 13;
            this.radioButtonLED6.TabStop = true;
            this.radioButtonLED6.Text = "LED 6";
            this.radioButtonLED6.UseVisualStyleBackColor = true;
            this.radioButtonLED6.CheckedChanged += new System.EventHandler(this.radioButtonLED6_CheckedChanged);
            // 
            // radioButtonLED7
            // 
            this.radioButtonLED7.AutoSize = true;
            this.radioButtonLED7.Location = new System.Drawing.Point(6, 218);
            this.radioButtonLED7.Name = "radioButtonLED7";
            this.radioButtonLED7.Size = new System.Drawing.Size(55, 17);
            this.radioButtonLED7.TabIndex = 14;
            this.radioButtonLED7.TabStop = true;
            this.radioButtonLED7.Text = "LED 7";
            this.radioButtonLED7.UseVisualStyleBackColor = true;
            this.radioButtonLED7.CheckedChanged += new System.EventHandler(this.radioButtonLED7_CheckedChanged);
            // 
            // radioButtonLED8
            // 
            this.radioButtonLED8.AutoSize = true;
            this.radioButtonLED8.Location = new System.Drawing.Point(6, 243);
            this.radioButtonLED8.Name = "radioButtonLED8";
            this.radioButtonLED8.Size = new System.Drawing.Size(55, 17);
            this.radioButtonLED8.TabIndex = 15;
            this.radioButtonLED8.TabStop = true;
            this.radioButtonLED8.Text = "LED 8";
            this.radioButtonLED8.UseVisualStyleBackColor = true;
            this.radioButtonLED8.CheckedChanged += new System.EventHandler(this.radioButtonLED8_CheckedChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.radioButtonLED4);
            this.groupBox7.Controls.Add(this.radioButtonLED5);
            this.groupBox7.Controls.Add(this.radioButtonLED6);
            this.groupBox7.Controls.Add(this.radioButtonLED7);
            this.groupBox7.Controls.Add(this.radioButtonLED8);
            this.groupBox7.Controls.Add(this.radioButtonAll);
            this.groupBox7.Controls.Add(this.radioButtonLED1);
            this.groupBox7.Controls.Add(this.radioButtonLED2);
            this.groupBox7.Controls.Add(this.radioButtonLED3);
            this.groupBox7.Location = new System.Drawing.Point(21, 75);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(98, 272);
            this.groupBox7.TabIndex = 16;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "LED Selection";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.radioButtonOFF);
            this.groupBox8.Controls.Add(this.radioButtonON);
            this.groupBox8.Location = new System.Drawing.Point(399, 75);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(81, 272);
            this.groupBox8.TabIndex = 17;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Mode";
            // 
            // radioButtonOFF
            // 
            this.radioButtonOFF.AutoSize = true;
            this.radioButtonOFF.Location = new System.Drawing.Point(9, 47);
            this.radioButtonOFF.Name = "radioButtonOFF";
            this.radioButtonOFF.Size = new System.Drawing.Size(65, 17);
            this.radioButtonOFF.TabIndex = 1;
            this.radioButtonOFF.TabStop = true;
            this.radioButtonOFF.Text = "Solid Off";
            this.radioButtonOFF.UseVisualStyleBackColor = true;
            this.radioButtonOFF.CheckedChanged += new System.EventHandler(this.radioButtonOFF_CheckedChanged);
            // 
            // radioButtonON
            // 
            this.radioButtonON.AutoSize = true;
            this.radioButtonON.Location = new System.Drawing.Point(9, 24);
            this.radioButtonON.Name = "radioButtonON";
            this.radioButtonON.Size = new System.Drawing.Size(65, 17);
            this.radioButtonON.TabIndex = 0;
            this.radioButtonON.TabStop = true;
            this.radioButtonON.Text = "Solid On";
            this.radioButtonON.UseVisualStyleBackColor = true;
            this.radioButtonON.CheckedChanged += new System.EventHandler(this.radioButtonON_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(489, 415);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox7);
            this.Name = "Form1";
            this.Text = "FTCP";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbBaud;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.RadioButton radioButtonLED1;
        private System.Windows.Forms.RadioButton radioButtonLED2;
        private System.Windows.Forms.RadioButton radioButtonLED3;
        private System.Windows.Forms.RadioButton radioButtonLED4;
        private System.Windows.Forms.RadioButton radioButtonLED5;
        private System.Windows.Forms.RadioButton radioButtonLED6;
        private System.Windows.Forms.RadioButton radioButtonLED7;
        private System.Windows.Forms.RadioButton radioButtonLED8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RadioButton radioButtonOFF;
        private System.Windows.Forms.RadioButton radioButtonON;
    }
}

