
namespace 내힘으로만들CameraProject.VIew
{
    partial class watch
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DispM = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.UnitM = new System.Windows.Forms.Label();
            this.DispS = new System.Windows.Forms.Label();
            this.UnitS = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.DispMS = new System.Windows.Forms.Label();
            this.UnitMS = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(474, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "기록";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(562, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "시작/정지";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DispM
            // 
            this.DispM.AutoSize = true;
            this.DispM.Font = new System.Drawing.Font("굴림", 40F);
            this.DispM.Location = new System.Drawing.Point(122, 33);
            this.DispM.Name = "DispM";
            this.DispM.Size = new System.Drawing.Size(0, 54);
            this.DispM.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UnitM
            // 
            this.UnitM.AutoSize = true;
            this.UnitM.Font = new System.Drawing.Font("굴림", 40F);
            this.UnitM.Location = new System.Drawing.Point(313, 33);
            this.UnitM.Name = "UnitM";
            this.UnitM.Size = new System.Drawing.Size(77, 54);
            this.UnitM.TabIndex = 3;
            this.UnitM.Text = "분";
            // 
            // DispS
            // 
            this.DispS.AutoSize = true;
            this.DispS.Font = new System.Drawing.Font("굴림", 40F);
            this.DispS.Location = new System.Drawing.Point(122, 119);
            this.DispS.Name = "DispS";
            this.DispS.Size = new System.Drawing.Size(0, 54);
            this.DispS.TabIndex = 4;
            // 
            // UnitS
            // 
            this.UnitS.AutoSize = true;
            this.UnitS.Font = new System.Drawing.Font("굴림", 40F);
            this.UnitS.Location = new System.Drawing.Point(313, 119);
            this.UnitS.Name = "UnitS";
            this.UnitS.Size = new System.Drawing.Size(77, 54);
            this.UnitS.TabIndex = 5;
            this.UnitS.Text = "초";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(562, 362);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "리셋";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DispMS
            // 
            this.DispMS.AutoSize = true;
            this.DispMS.Font = new System.Drawing.Font("굴림", 40F);
            this.DispMS.Location = new System.Drawing.Point(122, 206);
            this.DispMS.Name = "DispMS";
            this.DispMS.Size = new System.Drawing.Size(0, 54);
            this.DispMS.TabIndex = 7;
            // 
            // UnitMS
            // 
            this.UnitMS.AutoSize = true;
            this.UnitMS.Font = new System.Drawing.Font("굴림", 40F);
            this.UnitMS.Location = new System.Drawing.Point(313, 206);
            this.UnitMS.Name = "UnitMS";
            this.UnitMS.Size = new System.Drawing.Size(185, 54);
            this.UnitMS.TabIndex = 8;
            this.UnitMS.Text = "밀리초";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 9;
            // 
            // watch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UnitMS);
            this.Controls.Add(this.DispMS);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.UnitS);
            this.Controls.Add(this.DispS);
            this.Controls.Add(this.UnitM);
            this.Controls.Add(this.DispM);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "watch";
            this.Text = "Stopwatch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label DispM;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label UnitM;
        private System.Windows.Forms.Label DispS;
        private System.Windows.Forms.Label UnitS;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label DispMS;
        private System.Windows.Forms.Label UnitMS;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
    }
}