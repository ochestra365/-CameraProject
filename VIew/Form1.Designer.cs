
namespace 내힘으로만들CameraProject
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBoxIpl1 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnSnapShot = new System.Windows.Forms.Button();
            this.LblTime = new System.Windows.Forms.Label();
            this.LblStatus = new System.Windows.Forms.Label();
            this.BtnRFID = new System.Windows.Forms.Button();
            this.BtnStopwatch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnDate = new System.Windows.Forms.Button();
            this.BtnAlarm = new System.Windows.Forms.Button();
            this.BtnWebRtc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxIpl1
            // 
            this.pictureBoxIpl1.Location = new System.Drawing.Point(2, 70);
            this.pictureBoxIpl1.Name = "pictureBoxIpl1";
            this.pictureBoxIpl1.Size = new System.Drawing.Size(1920, 1080);
            this.pictureBoxIpl1.TabIndex = 0;
            this.pictureBoxIpl1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Display";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnSnapShot
            // 
            this.BtnSnapShot.Location = new System.Drawing.Point(350, 4);
            this.BtnSnapShot.Name = "BtnSnapShot";
            this.BtnSnapShot.Size = new System.Drawing.Size(75, 23);
            this.BtnSnapShot.TabIndex = 2;
            this.BtnSnapShot.Text = "Snapshot";
            this.BtnSnapShot.UseVisualStyleBackColor = true;
            this.BtnSnapShot.Click += new System.EventHandler(this.BtnSnapShot_Click);
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.Location = new System.Drawing.Point(12, 9);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(0, 12);
            this.LblTime.TabIndex = 3;
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(12, 32);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(253, 12);
            this.LblStatus.TabIndex = 4;
            this.LblStatus.Text = "기기와 통신포트가 아직 연결되지 않았습니다.";
            // 
            // BtnRFID
            // 
            this.BtnRFID.Location = new System.Drawing.Point(431, 4);
            this.BtnRFID.Name = "BtnRFID";
            this.BtnRFID.Size = new System.Drawing.Size(75, 23);
            this.BtnRFID.TabIndex = 5;
            this.BtnRFID.Text = "RFID";
            this.BtnRFID.UseVisualStyleBackColor = true;
            this.BtnRFID.Click += new System.EventHandler(this.BtnRFID_Click);
            // 
            // BtnStopwatch
            // 
            this.BtnStopwatch.Location = new System.Drawing.Point(512, 4);
            this.BtnStopwatch.Name = "BtnStopwatch";
            this.BtnStopwatch.Size = new System.Drawing.Size(75, 23);
            this.BtnStopwatch.TabIndex = 6;
            this.BtnStopwatch.Text = "StopWatch";
            this.BtnStopwatch.UseVisualStyleBackColor = true;
            this.BtnStopwatch.Click += new System.EventHandler(this.BtnStopwatch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 7;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BtnDate
            // 
            this.BtnDate.Location = new System.Drawing.Point(593, 4);
            this.BtnDate.Name = "BtnDate";
            this.BtnDate.Size = new System.Drawing.Size(75, 23);
            this.BtnDate.TabIndex = 8;
            this.BtnDate.Text = "Date";
            this.BtnDate.UseVisualStyleBackColor = true;
            this.BtnDate.Click += new System.EventHandler(this.BtnDate_Click);
            // 
            // BtnAlarm
            // 
            this.BtnAlarm.Location = new System.Drawing.Point(674, 4);
            this.BtnAlarm.Name = "BtnAlarm";
            this.BtnAlarm.Size = new System.Drawing.Size(109, 23);
            this.BtnAlarm.TabIndex = 9;
            this.BtnAlarm.Text = "Digital Alarm";
            this.BtnAlarm.UseVisualStyleBackColor = true;
            this.BtnAlarm.Click += new System.EventHandler(this.BtnAlarm_Click);
            // 
            // BtnWebRtc
            // 
            this.BtnWebRtc.Location = new System.Drawing.Point(789, 4);
            this.BtnWebRtc.Name = "BtnWebRtc";
            this.BtnWebRtc.Size = new System.Drawing.Size(75, 23);
            this.BtnWebRtc.TabIndex = 10;
            this.BtnWebRtc.Text = "WebRTC";
            this.BtnWebRtc.UseVisualStyleBackColor = true;
            this.BtnWebRtc.Click += new System.EventHandler(this.BtnWebRtc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1934, 1061);
            this.Controls.Add(this.BtnWebRtc);
            this.Controls.Add(this.BtnAlarm);
            this.Controls.Add(this.BtnDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnStopwatch);
            this.Controls.Add(this.BtnRFID);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.LblTime);
            this.Controls.Add(this.BtnSnapShot);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxIpl1);
            this.Name = "Form1";
            this.Text = "Camera_Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnSnapShot;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Button BtnRFID;
        private System.Windows.Forms.Button BtnStopwatch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BtnDate;
        private System.Windows.Forms.Button BtnAlarm;
        private System.Windows.Forms.Button BtnWebRtc;
    }
}

