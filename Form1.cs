using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;//사용한 것.
using OpenCvSharp.Extensions;//사용한 것
using System.Diagnostics;
using FFmpeg;

namespace 내힘으로만들CameraProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rtspaddr = "00";
            VideoCapture capture = new VideoCapture();//비디오 이미지 캡쳐
            capture.Open(rtspaddr);//연결스트링에 해당하는 거 열기

            using (Mat image = new Mat())//오픈 CV에서 이미지 파일을 2차원 배열로 해서 출력.
            {
                while (true)
                {
                    if (!capture.Read(image))//읽지 못하면
                    {
                        Cv2.WaitKey();//키 누르면 대기..기다리게 할것
                    }
                    if (image.Size().Width > 0 && image.Size().Height > 0)//이미지 사이즈가 존재하면 0보다 크면
                    {
                        Bitmap bitmap = BitmapConverter.ToBitmap(image);//비트맵으로 바꿔서 form에 출력
                        pictureBoxIpl1.Image = bitmap;//컨트롤러의 이미지 속성에 대입
                    }
                    if (Cv2.WaitKey(1) >= 0) break;//delay가 1초이상이면 반복문을 탈출함== 화면이 멈춤
                }
            }
        }

        private void LblTime_Click(object sender, EventArgs e)
        {
            Stopwatch timer = new Stopwatch();
            //LblTime.Text
        }
    }
}
