using System;
using System.Windows.Forms;
using System.IO.Ports;

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
            richTextBox1.Text = string.Empty;
        }

        private void BtnOpenPort_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Open();
                label6.Text = "현재 포트가 열렸습니다.";
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
                serialPort1.Close();
                label6.Text = "현재 포트를 닫았습니다.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex}");
            }
        }

        private void ChkAutoCR_LF_CheckedChanged(object sender, EventArgs e)
        {

        }
    
        private void RFID_Load(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = "COM3";//연결할 포트
                serialPort1.BaudRate = (int)9600;//보레이트(통신속도)
                serialPort1.DataBits = (int)8;//데이터비트
                serialPort1.Parity = Parity.None;//패리티(없음)
                serialPort1.StopBits = StopBits.One;//정지비트는 1
                serialPort1.Open();
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);//이벤트 발생
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex}");
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                this.Invoke(new EventHandler(sportRCV));//스레드 위반을 피하기 위해 시그널링을 주는 것임. 호출할 떄만 스레드가 돌아가도록 하는 것이다.
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex}");
            }
        }

        private void sportRCV(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.BytesToRead > 0)
                {
                    richTextBox1.Text = serialPort1.ReadExisting();
                    GC.Collect();//메모리 누수를 잡아서 불필요한 데이터들이 수거되서 다음 데이터가 들어올 배열공간을 만든다.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex}");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
