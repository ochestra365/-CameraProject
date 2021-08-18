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
    public partial class DigitalAlarm : Form
    {
        private Timer myTimer = new Timer();
        private DateTime aDay;
        private DateTime tTime;
        private bool setAlarm;

        public DigitalAlarm()
        {
            InitializeComponent();
            LblAlarm.ForeColor = Color.Gray;
            LblAlarmSet.ForeColor = Color.Gray;

            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.CustomFormat = "tt hh:mm";

            myTimer.Interval = 1000;
            myTimer.Tick += MyTimer_Tick;
            myTimer.Start();
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            DateTime cTime = DateTime.Now;
            LblDate.Text = cTime.ToShortDateString();
            LblTime.Text = cTime.ToLongTimeString();
            if (setAlarm == true)
            {
                if(aDay==DateTime.Today&& cTime.Hour == tTime.Hour && cTime.Minute == tTime.Minute)
                {
                    setAlarm = false;
                    MessageBox.Show("Alarm");
                }
            }
        }

        private void BtnSet_Click(object sender, EventArgs e)
        {
            aDay = DateTime.Parse(datePicker.Text);
            tTime = DateTime.Parse(timePicker.Text);

            setAlarm = true;
            LblAlarmSet.ForeColor = Color.Red;
            LblAlarm.ForeColor = Color.Blue;
            LblAlarm.Text = "Alarm : " + aDay.ToShortDateString() + " " + tTime.ToLongTimeString();
            tabControl1.SelectedTab = tabPage2;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            setAlarm = false;
            LblAlarmSet.ForeColor = Color.Gray;
            LblAlarm.ForeColor = Color.Gray;
            LblAlarm.Text = "Alarm : ";
            tabControl1.SelectedTab = tabPage2;
        }
    }
}
