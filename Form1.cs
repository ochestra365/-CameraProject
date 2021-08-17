using System;
using System.Drawing;
using System.Windows.Forms;
using OpenCvSharp;//사용한 것.
using OpenCvSharp.Extensions;//사용한 것
using System.Threading;
using System.Drawing.Imaging;

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
                Thread t1 = new Thread(DisplayPC);
                t1.Start();
                t1.IsBackground = true;//메인 스레드 종료 시 같이 종료되게 함.
                Thread.Sleep(1000);
                if (t1 != null)
                {
                    LblStatus.Text = "기기와 통신포트가 연결되었습니다.";
                }
                else
                {
                    LblStatus.Text = "기기와 통신포트가 연결되어 있지 않습니다.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("관리자 박성철에게 연락하세요");
            }

        }

        /// <summary>
        /// 화면을 나오게 하는 메서드(구글에 있음 추가한 것은 가비지 컬렉터로 메모리 누수 잡은 것임)
        /// </summary>
        private void DisplayPC()
        {
            string rtspaddr = "rtsp://admin:1234@192.168.78.100:554";//연결스트링
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
                        if (image.Size().Width > 0 && image.Size().Height > 0)//이미지 사이즈가 존재하면 0보다 크면
                        {
                            Bitmap bitmap = BitmapConverter.ToBitmap(image);//비트맵으로 바꿔서 form에 출력
                            pictureBoxIpl1.Image = bitmap;//컨트롤러의 이미지 속성에 대입
                            //pictureBoxIpl1.Image.Dispose();
                            GC.Collect();//가비지 컬렉터로 메모리 누수를 잡아준다.
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
                string now = DateTime.Now.ToString("yyyyMMdd_hh:mm:ss");
                bmp.Save(@"C:\temp\src.png",ImageFormat.Png);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"관리자에게 이 메세지를 보여주세요\n관리자 : 박성철\n연락처 : 010.2874.1479\n\nError : {ex}");
            }
            
        }

        private void BtnRFID_Click(object sender, EventArgs e)
        {
            Form f1 = new RFID();
            f1.Show();
        }
    }
}
