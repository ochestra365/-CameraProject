using System;
using System.Drawing;
using System.Windows.Forms;
using OpenCvSharp;//사용한 것.
using OpenCvSharp.Extensions;//사용한 것
using System.Threading;
using System.Drawing.Imaging;
using System.IO;
namespace 내힘으로만들CameraProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                LblTime.Text = DateTime.Now.ToString();
                Ticktock();
                Thread t1 = new Thread(DisplayPC);
                t1.Start();
                t1.IsBackground = true;//메인 스레드 종료 시 같이 종료되게 함.
                Thread.Sleep(1000);//없으면 뭔가 불안정한 반응을 보인다.
            }
            catch (Exception ex)
            {
                MessageBox.Show("관리자 박성철에게 연락하세요");
            }

        }
        /// <summary>
        /// 현재 시간을 나타내는 기능을 의미한다.
        /// </summary>
        private void Ticktock()
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();//컴파일러가 모호하다고 반응해서 경로지정을 해줌.
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }
        /// <summary>
        /// 화면을 나오게 하는 메서드(구글에 있음 추가한 것은 가비지 컬렉터로 메모리 누수 잡은 것임)
        /// </summary>
        private void DisplayPC()
        {
            string rtspaddr = "rtsp://admin:1234@192.168.78.100:554";//Honeywell 연결스트링(보안처리 잘해야 함.)
            VideoCapture capture = new VideoCapture();//비디오 이미지 캡쳐
            capture.Open(rtspaddr);//연결스트링에 해당하는 거 열기
            using (Mat image = new Mat())//오픈 CV에서 이미지 파일을 2차원 배열로 해서 출력.
            {
                while (true)
                {
                    try
                    {
                        if (!capture.Read(image))//읽지 못하면
                        {
                            Cv2.WaitKey();//키 누르면 대기..기다리게 할것
                        }
                        if (image.Size().Width > 0 && image.Size().Height > 0)//이미지 사이즈가 존재하면
                        {
                            LblStatus.Text = "기기와 통신포트가 연결되었습니다.";
                            Bitmap bitmap = BitmapConverter.ToBitmap(image);//비트맵으로 바꿔서 form에 출력
                            pictureBoxIpl1.Image = bitmap;//컨트롤러의 이미지 속성에 대입
                            GC.Collect();//가비지 컬렉터로 메모리 누수를 잡아준다.
                        }
                        else
                        {
                            LblStatus.Text = "기기와 통신포트가 연결되어 있지 않습니다.";
                        }
                        if (Cv2.WaitKey(1) >= 0) break;//delay가 1초이상이면 반복문을 탈출함== 화면이 멈춤
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"관리자에게 이 메세지를 보여주세요\n관리자 : 박성철\n연락처 : 010.2874.1479\n\nError : {ex}");break;
                    }
                }
            }
        }
        
        /// <summary>
        /// 기능만 구현해 놓았음. RFID읽으면 스냅샷 찍게 해야 함. Delegate+Invoke+Action을 사용해야 함.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSnapShot_Click(object sender, EventArgs e)
        {
            try
            {
                Screen scr = Screen.PrimaryScreen;
                Rectangle rect = scr.Bounds;
                Bitmap bmp = new Bitmap(rect.Width, rect.Height);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.CopyFromScreen(rect.Left, rect.Top, 0, 0, rect.Size);
                }
                string now = DateTime.Now.ToString("yyyMMdd_hhmmss");
                bmp.Save(@"C:\temp\src.png",ImageFormat.Png);//일단 파일은 얘로 저장하는데
                FileExistCheck(@"C:\temp\src.png");//얘가 존재하는 지 파악하는 메서드 왜냐하면 같은 파일이 2번 존재할 필요는 없으니까
                File.Move(@"C:\temp\src.png",$"C:\\temp\\{now}.png");//저장 파일명을현재 날짜로 변환시켜줌
            }
            catch (Exception ex)
            {
                MessageBox.Show($"관리자에게 이 메세지를 보여주세요\n관리자 : 박성철\n연락처 : 010.2874.1479\n\nError : {ex}");
            }
            
        }

        /// <summary>
        /// 파일이 존재하는 지 확인하는 메서드
        /// </summary>
        /// <param name="oldFile"></param>
        /// <returns></returns>
        private static bool FileExistCheck(string oldFile)
        {
            if (File.Exists(oldFile))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #region 각종 View

        private void BtnRFID_Click(object sender, EventArgs e)
        {
            Form f1 = new RFID();
            f1.Show();
        }

        private void BtnStopwatch_Click(object sender, EventArgs e)
        {
            Form f2 = new 내힘으로만들CameraProject.VIew.watch();
            f2.Show();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label1.BackColor = Color.Transparent;
        }

        private void BtnDate_Click(object sender, EventArgs e)
        {
            Form f3 = new 내힘으로만들CameraProject.VIew.CaculatingDate();
            f3.Show();
        }

        private void BtnAlarm_Click(object sender, EventArgs e)
        {
            Form f4 = new 내힘으로만들CameraProject.VIew.DigitalAlarm();
            f4.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form f5 = new 내힘으로만들CameraProject.VIew.Login();
            f5.Show();
        }

        private void BtnWebRtc_Click(object sender, EventArgs e)
        {
            //나중에 구현할 기능 현재 기술 습득중 내용은 웹 화상 통신
        }
        #endregion
    }
}
