using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 내힘으로만들CameraProject.VIew
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "abcd" && textBox2.Text == "1234")
            {
                label3.Text = "로그인 성공";
            }
            else
            {
                label3.Text = "로그인 실패";
            }
        }
    }
}
