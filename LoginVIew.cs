using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 내힘으로만들CameraProject
{
    public partial class LoginVIew : Form
    {
        public LoginVIew()
        {
            InitializeComponent();
            this.ClientSize = new Size(300, 200);
        }

        private void LoginVIew_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private void Btnb_login_Click(object sender, EventArgs e)
        {
            if (Txtusername.Text == "admin" && Txtpassword.Text == "1234")
            {
                label3.Text = "로그인 성공";
                Close();
            }
            else label3.Text = "로그인 실패";
        }
    }
}
