using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Imaging;
namespace DATN_App_Windows
{
    
    public partial class Form1 : Form
    {
        MJPEGStream stream;
        public Form1()
        {
            InitializeComponent();
           // InitializeComponent();
            stream = new MJPEGStream("http://192.168.1.49:4747/video");
            stream.NewFrame += Stream_NewFrame;
        }

        private void Stream_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //throw new NotImplementedException();
            Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = bmp;
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stream.Start();
        }
    }
}
