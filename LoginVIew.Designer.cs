
namespace 내힘으로만들CameraProject
{
    partial class LoginVIew
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txtusername = new System.Windows.Forms.TextBox();
            this.Txtpassword = new System.Windows.Forms.TextBox();
            this.Btnb_login = new System.Windows.Forms.Button();
            this.Btnb_cancle_l = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // Txtusername
            // 
            this.Txtusername.Location = new System.Drawing.Point(120, 56);
            this.Txtusername.Name = "Txtusername";
            this.Txtusername.Size = new System.Drawing.Size(118, 21);
            this.Txtusername.TabIndex = 2;
            // 
            // Txtpassword
            // 
            this.Txtpassword.Location = new System.Drawing.Point(120, 84);
            this.Txtpassword.Name = "Txtpassword";
            this.Txtpassword.Size = new System.Drawing.Size(118, 21);
            this.Txtpassword.TabIndex = 3;
            // 
            // Btnb_login
            // 
            this.Btnb_login.Location = new System.Drawing.Point(61, 120);
            this.Btnb_login.Name = "Btnb_login";
            this.Btnb_login.Size = new System.Drawing.Size(75, 23);
            this.Btnb_login.TabIndex = 4;
            this.Btnb_login.Text = "Login";
            this.Btnb_login.UseVisualStyleBackColor = true;
            this.Btnb_login.Click += new System.EventHandler(this.Btnb_login_Click);
            // 
            // Btnb_cancle_l
            // 
            this.Btnb_cancle_l.Location = new System.Drawing.Point(142, 120);
            this.Btnb_cancle_l.Name = "Btnb_cancle_l";
            this.Btnb_cancle_l.Size = new System.Drawing.Size(75, 23);
            this.Btnb_cancle_l.TabIndex = 5;
            this.Btnb_cancle_l.Text = "Cancle";
            this.Btnb_cancle_l.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // LoginVIew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 167);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btnb_cancle_l);
            this.Controls.Add(this.Btnb_login);
            this.Controls.Add(this.Txtpassword);
            this.Controls.Add(this.Txtusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginVIew";
            this.Text = "LoginVIew";
            this.Load += new System.EventHandler(this.LoginVIew_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txtusername;
        private System.Windows.Forms.TextBox Txtpassword;
        private System.Windows.Forms.Button Btnb_login;
        private System.Windows.Forms.Button Btnb_cancle_l;
        private System.Windows.Forms.Label label3;
    }
}