using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
namespace 내힘으로만들CameraProject.VIew
{
    public partial class watch : Form
    {
        private int CountMS = 0;
        private int CountS = 0;
        private int CountM = 0;
        int a = 1;
        private bool Toggle = false;
        public watch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Toggle == false)
            {
                timer1.Start();
                timer2.Start();
                Toggle = true;
            }
            else
            {
                timer1.Stop();
                timer2.Stop();
                Toggle = false;
            }
        }

        private void Run()
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "";
            label1.Text = a.ToString() + "." + CountM.ToString() + " " + UnitM.Text + " " + CountS.ToString() + " " + UnitS.Text + " " + CountMS.ToString() + UnitMS.Text + "\n";
            ++a;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ++CountMS;
            if (CountMS == 60){
                CountMS = 0;
                ++CountS;
                if (CountS == 60)
                {
                    CountS = 0;
                    ++CountM;
                }

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DispM.Text = CountM.ToString();
            DispS.Text = CountS.ToString();
            DispMS.Text = CountMS.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            Toggle = false;
            CountM = 0;
            CountS = 0;
            CountMS = 0;
            DispM.Text = CountM.ToString();
            DispS.Text = CountS.ToString();
            DispMS.Text = CountMS.ToString();
            label1.Text = "";
            a = 1;
        }
    }
}
