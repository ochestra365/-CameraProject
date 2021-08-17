using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;

namespace 내힘으로만들CameraProject
{
    public partial class RFID : Form
    {
        public RFID()
        {
            InitializeComponent();
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {

        }

        private void BtnExport_Click(object sender, EventArgs e)
        {

        }

        private void BtnCapture_Click(object sender, EventArgs e)
        {

        }

        private void BtnASCII_Click(object sender, EventArgs e)
        {

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {

        }

        private void BtnOpenPort_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Open();//현재 포트가 열린상태
                label6.Text = "현재 포트가 열린 상태입니다.";
                Thread t1 = new Thread(Port_Information);
                t1.Start();
                t1.IsBackground = true;
                Thread.Sleep(300);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex}");
            }
            
        }

        private void BtnClosePort_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex}")
            }
            serialPort1.Close();
            label6.Text = "현재 포트가 닫힌 상태입니다.";
        }

        private void ChkAutoCR_LF_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void Port_Information()
        {
            try
            {
                serialPort1.PortName = TxtDevice.Text;//연결할 포트
                serialPort1.BaudRate = (int)CboBaudrate.SelectedIndex;//보레이트(통신속도)
                serialPort1.DataBits = (int)CboData_bits.SelectedIndex;//데이터비트
                serialPort1.Parity = Parity.None;//패리티(없음)
                serialPort1.StopBits = StopBits.One;//정지비트는 1
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);//이벤트 발생
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex}");
            }
            
        }
        private void RFID_Load(object sender, EventArgs e)
        {
           
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            richTextBox1.Text = serialPort1.ReadExisting();
        }
    }
}
