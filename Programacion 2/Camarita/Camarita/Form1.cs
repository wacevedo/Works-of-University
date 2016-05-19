using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Video.VFW;
using AForge.Video.FFMPEG;
using System.Drawing.Imaging;
using System.IO.Ports;

namespace Camarita
{
    public partial class Form1 : Form
    {
        //para foto 
        private FilterInfoCollection Dispositipos;
        private VideoCaptureDevice FuenteDeVideo;//=null;
        //para video
        private FilterInfoCollection VideoCaptureDevices;
        private VideoCaptureDevice FinalVideo = null;
        private VideoCaptureDeviceForm captureDevice;
        private Bitmap video;
        private AVIWriter AVIwriter = new AVIWriter();
        private SaveFileDialog saveAvi;
        public Form1()
        {
            InitializeComponent();
            
        }
        
        Bitmap imagen;
        public static Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);
            Graphics.FromImage(newImage).DrawImage(image, 0, 0, newWidth, newHeight);
            return newImage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dispositipos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo x in Dispositipos)
            {
                comboBox1.Items.Add(x.Name);
            }
            comboBox1.SelectedIndex = 0;
            FuenteDeVideo = new VideoCaptureDevice(Dispositipos[comboBox1.SelectedIndex].MonikerString);
            videoSourcePlayer1.VideoSource = FuenteDeVideo;
            videoSourcePlayer1.Start();
            //para video
            VideoCaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            captureDevice = new VideoCaptureDeviceForm();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            FuenteDeVideo =new VideoCaptureDevice(Dispositipos[comboBox1.SelectedIndex].MonikerString);
            videoSourcePlayer1.VideoSource = FuenteDeVideo;
            videoSourcePlayer1.Start();           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            videoSourcePlayer1.SignalToStop();

        }

        private void buttonphoto_Click(object sender, EventArgs e)
        {
            Bitmap img = videoSourcePlayer1.GetCurrentVideoFrame();
            imagen = img;
            Photo1.Image = ScaleImage(img, 115, 115);
            /*var image = Image.FromFile(@"c:\logo.png");
            var newImage = ScaleImage(image, 300, 400);
            newImage.Save(@"c:\test.png", ImageFormat.Png);*/
             
        }

        private void Photo1_MouseDoubleClick(object sender, EventArgs e)
        { 
            SaveFileDialog Saveimg = new SaveFileDialog();
            Saveimg.Title = "Save image Files";
            Saveimg.Filter = "*.jpeg|*.jpeg|bitmap|*.bmp|Gif Image|*.gif|All files(*.*)|*.*";
            if (Saveimg.ShowDialog() == DialogResult.OK)
            {
                imagen.Save(Saveimg.FileName);
            }
            //Photo1.Image.Save("IMG" + DateTime.Now.ToString("hhmmss") + ".jpg");
        }

                
        
        private void buttonVideo_Click(object sender, EventArgs e)
        {
            

        }
    }
}
 