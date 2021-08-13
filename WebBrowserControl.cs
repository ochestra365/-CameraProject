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
    public partial class WebBrowserControl : Form
    {
        public WebBrowserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = textBox1.Text;
            webBrowser1.Navigate(url);
        }
    }
}
