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
    public partial class CaculatingDate : Form
    {
        public CaculatingDate()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            DateTime selectedDay = dateTimePicker1.Value;

            textBox1.Text = today.Subtract(selectedDay).TotalDays.ToString("0");//소숫점 없이 표현
        }
    }
}
