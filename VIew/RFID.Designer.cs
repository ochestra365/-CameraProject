
namespace 내힘으로만들CameraProject
{
    partial class RFID
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
            this.BtnClosePort = new System.Windows.Forms.Button();
            this.BtnOpenPort = new System.Windows.Forms.Button();
            this.CboParity = new System.Windows.Forms.ComboBox();
            this.CboStop_bits = new System.Windows.Forms.ComboBox();
            this.CboData_bits = new System.Windows.Forms.ComboBox();
            this.CboBaudrate = new System.Windows.Forms.ComboBox();
            this.TxtDevice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BtnImport = new System.Windows.Forms.Button();
            this.BtnExport = new System.Windows.Forms.Button();
            this.BtnASCII = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ChkAutoCR_LF = new System.Windows.Forms.CheckBox();
            this.BtnCapture = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnClosePort);
            this.groupBox1.Controls.Add(this.BtnOpenPort);
            this.groupBox1.Controls.Add(this.CboParity);
            this.groupBox1.Controls.Add(this.CboStop_bits);
            this.groupBox1.Controls.Add(this.CboData_bits);
            this.groupBox1.Controls.Add(this.CboBaudrate);
            this.groupBox1.Controls.Add(this.TxtDevice);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 209);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Port Config";
            // 
            // BtnClosePort
            // 
            this.BtnClosePort.Location = new System.Drawing.Point(114, 173);
            this.BtnClosePort.Name = "BtnClosePort";
            this.BtnClosePort.Size = new System.Drawing.Size(75, 23);
            this.BtnClosePort.TabIndex = 11;
            this.BtnClosePort.Text = "Close Port";
            this.BtnClosePort.UseVisualStyleBackColor = true;
            this.BtnClosePort.Click += new System.EventHandler(this.BtnClosePort_Click);
            // 
            // BtnOpenPort
            // 
            this.BtnOpenPort.Location = new System.Drawing.Point(12, 173);
            this.BtnOpenPort.Name = "BtnOpenPort";
            this.BtnOpenPort.Size = new System.Drawing.Size(75, 23);
            this.BtnOpenPort.TabIndex = 10;
            this.BtnOpenPort.Text = "Open Port";
            this.BtnOpenPort.UseVisualStyleBackColor = true;
            this.BtnOpenPort.Click += new System.EventHandler(this.BtnOpenPort_Click);
            // 
            // CboParity
            // 
            this.CboParity.FormattingEnabled = true;
            this.CboParity.Items.AddRange(new object[] {
            "Even",
            "None",
            "Odd"});
            this.CboParity.Location = new System.Drawing.Point(63, 147);
            this.CboParity.Name = "CboParity";
            this.CboParity.Size = new System.Drawing.Size(138, 20);
            this.CboParity.TabIndex = 9;
            // 
            // CboStop_bits
            // 
            this.CboStop_bits.FormattingEnabled = true;
            this.CboStop_bits.Items.AddRange(new object[] {
            "1",
            "2"});
            this.CboStop_bits.Location = new System.Drawing.Point(63, 114);
            this.CboStop_bits.Name = "CboStop_bits";
            this.CboStop_bits.Size = new System.Drawing.Size(138, 20);
            this.CboStop_bits.TabIndex = 8;
            // 
            // CboData_bits
            // 
            this.CboData_bits.FormattingEnabled = true;
            this.CboData_bits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.CboData_bits.Location = new System.Drawing.Point(63, 81);
            this.CboData_bits.Name = "CboData_bits";
            this.CboData_bits.Size = new System.Drawing.Size(138, 20);
            this.CboData_bits.TabIndex = 7;
            // 
            // CboBaudrate
            // 
            this.CboBaudrate.FormattingEnabled = true;
            this.CboBaudrate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600"});
            this.CboBaudrate.Location = new System.Drawing.Point(64, 48);
            this.CboBaudrate.Name = "CboBaudrate";
            this.CboBaudrate.Size = new System.Drawing.Size(136, 20);
            this.CboBaudrate.TabIndex = 6;
            // 
            // TxtDevice
            // 
            this.TxtDevice.Location = new System.Drawing.Point(63, 14);
            this.TxtDevice.Name = "TxtDevice";
            this.TxtDevice.Size = new System.Drawing.Size(138, 21);
            this.TxtDevice.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "Parity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stop bits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data bits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baudrate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Device";
            // 
            // BtnImport
            // 
            this.BtnImport.Location = new System.Drawing.Point(12, 215);
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.Size = new System.Drawing.Size(75, 23);
            this.BtnImport.TabIndex = 1;
            this.BtnImport.Text = "Import";
            this.BtnImport.UseVisualStyleBackColor = true;
            this.BtnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // BtnExport
            // 
            this.BtnExport.Location = new System.Drawing.Point(114, 215);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(75, 23);
            this.BtnExport.TabIndex = 2;
            this.BtnExport.Text = "Export";
            this.BtnExport.UseVisualStyleBackColor = true;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // BtnASCII
            // 
            this.BtnASCII.Location = new System.Drawing.Point(616, 215);
            this.BtnASCII.Name = "BtnASCII";
            this.BtnASCII.Size = new System.Drawing.Size(75, 23);
            this.BtnASCII.TabIndex = 3;
            this.BtnASCII.Text = "ASCII";
            this.BtnASCII.UseVisualStyleBackColor = true;
            this.BtnASCII.Click += new System.EventHandler(this.BtnASCII_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(697, 215);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 4;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(215, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(557, 197);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // ChkAutoCR_LF
            // 
            this.ChkAutoCR_LF.AutoSize = true;
            this.ChkAutoCR_LF.Location = new System.Drawing.Point(227, 215);
            this.ChkAutoCR_LF.Name = "ChkAutoCR_LF";
            this.ChkAutoCR_LF.Size = new System.Drawing.Size(90, 16);
            this.ChkAutoCR_LF.TabIndex = 6;
            this.ChkAutoCR_LF.Text = "Auto CR/LF";
            this.ChkAutoCR_LF.UseVisualStyleBackColor = true;
            this.ChkAutoCR_LF.CheckedChanged += new System.EventHandler(this.ChkAutoCR_LF_CheckedChanged);
            // 
            // BtnCapture
            // 
            this.BtnCapture.Location = new System.Drawing.Point(513, 215);
            this.BtnCapture.Name = "BtnCapture";
            this.BtnCapture.Size = new System.Drawing.Size(97, 23);
            this.BtnCapture.TabIndex = 9;
            this.BtnCapture.Text = "Start Capture";
            this.BtnCapture.UseVisualStyleBackColor = true;
            this.BtnCapture.Click += new System.EventHandler(this.BtnCapture_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "현재 포트가 닫힌 상태입니다.";
            // 
            // RFID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 260);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnCapture);
            this.Controls.Add(this.ChkAutoCR_LF);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnASCII);
            this.Controls.Add(this.BtnExport);
            this.Controls.Add(this.BtnImport);
            this.Controls.Add(this.groupBox1);
            this.Name = "RFID";
            this.Text = "RFID";
            this.Load += new System.EventHandler(this.RFID_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnClosePort;
        private System.Windows.Forms.Button BtnOpenPort;
        private System.Windows.Forms.ComboBox CboParity;
        private System.Windows.Forms.ComboBox CboStop_bits;
        private System.Windows.Forms.ComboBox CboData_bits;
        private System.Windows.Forms.ComboBox CboBaudrate;
        private System.Windows.Forms.TextBox TxtDevice;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button BtnImport;
        private System.Windows.Forms.Button BtnExport;
        private System.Windows.Forms.Button BtnASCII;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox ChkAutoCR_LF;
        private System.Windows.Forms.Button BtnCapture;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label6;
    }
}