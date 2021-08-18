
namespace 내힘으로만들CameraProject.VIew
{
    partial class DigitalAlarm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.BtnSet = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.LblAlarmSet = new System.Windows.Forms.Label();
            this.LblAlarm = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblTime = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(294, 170);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnReset);
            this.tabPage1.Controls.Add(this.BtnSet);
            this.tabPage1.Controls.Add(this.timePicker);
            this.tabPage1.Controls.Add(this.datePicker);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(286, 144);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "알람설정";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.LblAlarm);
            this.tabPage2.Controls.Add(this.LblAlarmSet);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(286, 144);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "디지털 시계";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 21);
            this.datePicker.TabIndex = 0;
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(3, 81);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(200, 21);
            this.timePicker.TabIndex = 1;
            // 
            // BtnSet
            // 
            this.BtnSet.Location = new System.Drawing.Point(125, 108);
            this.BtnSet.Name = "BtnSet";
            this.BtnSet.Size = new System.Drawing.Size(75, 23);
            this.BtnSet.TabIndex = 2;
            this.BtnSet.Text = "설정";
            this.BtnSet.UseVisualStyleBackColor = true;
            this.BtnSet.Click += new System.EventHandler(this.BtnSet_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(205, 108);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 3;
            this.BtnReset.Text = "해제";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // LblAlarmSet
            // 
            this.LblAlarmSet.AutoSize = true;
            this.LblAlarmSet.Location = new System.Drawing.Point(20, 20);
            this.LblAlarmSet.Name = "LblAlarmSet";
            this.LblAlarmSet.Size = new System.Drawing.Size(57, 12);
            this.LblAlarmSet.TabIndex = 0;
            this.LblAlarmSet.Text = "알람 설정";
            // 
            // LblAlarm
            // 
            this.LblAlarm.AutoSize = true;
            this.LblAlarm.Location = new System.Drawing.Point(20, 45);
            this.LblAlarm.Name = "LblAlarm";
            this.LblAlarm.Size = new System.Drawing.Size(46, 12);
            this.LblAlarm.TabIndex = 1;
            this.LblAlarm.Text = "Alarm :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblTime);
            this.groupBox1.Controls.Add(this.LblDate);
            this.groupBox1.Location = new System.Drawing.Point(22, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 69);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "현재 시간";
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Location = new System.Drawing.Point(6, 17);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(30, 12);
            this.LblDate.TabIndex = 3;
            this.LblDate.Text = "Date";
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.Font = new System.Drawing.Font("굴림", 20F);
            this.LblTime.Location = new System.Drawing.Point(6, 39);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(73, 27);
            this.LblTime.TabIndex = 4;
            this.LblTime.Text = "Time";
            // 
            // DigitalAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 194);
            this.Controls.Add(this.tabControl1);
            this.Name = "DigitalAlarm";
            this.Text = "DigitalAlarm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnSet;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblAlarm;
        private System.Windows.Forms.Label LblAlarmSet;
    }
}