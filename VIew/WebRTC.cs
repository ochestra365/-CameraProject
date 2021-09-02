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
    public partial class WebRTC : Form
    {
        public WebRTC()
        {
            InitializeComponent();
        }

        private void WebRTC_Load(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://webrtc.github.io/samples/src/content/getusermedia/getdisplaymedia/");
        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
