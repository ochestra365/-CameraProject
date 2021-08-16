using System;
using System.Drawing;
using System.Windows.Forms;
using OpenCvSharp;//사용한 것.
using OpenCvSharp.Extensions;//사용한 것
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Drawing.Imaging;
using System.Drawing;
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
                Thread.Sleep(1000);
              //  Thread t2 = new Thread(GetMomory);
              //  t2.Start();
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
        private void Form1_Load(object sender, EventArgs e)
        {
          // Form f2 = new WebBrowserControl();
          // f2.Show();
        }
        /// <summary>
        /// snapshot yyyyMMdd
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSnapShot_Click(object sender, EventArgs e)
        {
           
            Bitmap screen1 = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            using (Graphics g = Graphics.FromImage(screen1))
            {
                System.Drawing.Size a = new System.Drawing.Size(SystemInformation.VirtualScreen.Width, SystemInformation.VirtualScreen.Height);
                System.Drawing.Size reg = new System.Drawing.Size(this.Width, this.Height);
                System.Drawing.Size def = new System.Drawing.Size(500, 800);

               // g.CopyFromScreen(this.Left, this.Top, int.Parse(textBox1.Text), 100, def);

            }
            pictureBoxIpl1.SizeMode = PictureBoxSizeMode.Zoom;

            pictureBoxIpl1.Image = screen1;

            screen1.Save("C:\\SnapShotFolder\\"  + "screen.bmp", ImageFormat.Bmp);
            int sHeight = screen1.Height;
            int swidth = screen1.Width;
            MessageBox.Show("width:= " + swidth + "  height:= " + sHeight);

            // screen.Save("c:\\button.gif", System.Drawing.Imaging.ImageFormat.Gif);
           /* string fileName = $"{DateTime.Now.ToString("yyyyMMdd_hh:mm:ss")}SnapShot";
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.InitialDirectory = @"C:\\SnapShotFolder";
            saveFile.Title = "snapShot";
            saveFile.DefaultExt = "bmp";
            saveFile.Filter = "Bmp files(*.bmp)|*.bmp";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFile.FileName.ToString();
            }*/
        }
    }
}
