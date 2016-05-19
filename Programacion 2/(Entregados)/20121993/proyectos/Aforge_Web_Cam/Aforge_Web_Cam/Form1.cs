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
using System.Threading;


namespace Aforge_Web_Cam
{
    public partial class VideoForm : Form
    {
        private FilterInfoCollection VideoCaptureDevices;
        private VideoCaptureDevice FinalVideo = null;
        private VideoCaptureDeviceForm captureDevice;
        private Bitmap video;
        private AVIWriter AVIwriter = new AVIWriter();
        private SaveFileDialog saveAvi;
        string horainicio, horafin;
        bool autotakepicture = false;
        public VideoForm()
        {
            InitializeComponent();
        }

        Image imagen;
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
            VideoCaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            captureDevice = new VideoCaptureDeviceForm();
            string[] filtersName = { "Normal", "Sepia", "Janeiro","EscalaGris", "Soleado", "Orange", "Cloudy", "Aspen", "NeonWhite", "1980", "Wasatch", "Rio" };
            

            for (int i = 0; i < filtersName.Length ; i++)
            {
                domainUpDownFilter.Items.Add(filtersName[i]);                
            }
            domainUpDownFilter.SelectedIndex = 0;
                         
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (captureDevice.ShowDialog(this) == DialogResult.OK)
            {
                VideoCaptureDevice videoSource = captureDevice.VideoDevice;
                FinalVideo = captureDevice.VideoDevice;
                FinalVideo.NewFrame += new NewFrameEventHandler(FinalVideo_NewFrame);
                FinalVideo.Start();
            }
        }

        void FinalVideo_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            
            string filtros;
            filtros = Convert.ToString(domainUpDownFilter.SelectedItem);
            ImagenFiltro filtro = new ImagenFiltro((Bitmap)eventArgs.Frame.Clone(), filtros);
            if (butStop.Text == "Stop Record")
            {
                
                video = filtro.img;//(Bitmap)eventArgs.Frame.Clone();
                pbVideo.Image = filtro.img; //(Bitmap)eventArgs.Frame.Clone();
                AVIwriter.Quality = 0;                
                AVIwriter.AddFrame(video);
            }
            else
            {                
                video = filtro.img;//(Bitmap)eventArgs.Frame.Clone();
                pbVideo.Image = filtro.img; //(Bitmap)eventArgs.Frame.Clone();
            }
        }

        private void butRecord_Click(object sender, EventArgs e)
        {
            saveAvi = new SaveFileDialog();
            saveAvi.Filter = "Avi Files (*.avi)|*.avi";
            if (saveAvi.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                int h = captureDevice.VideoDevice.VideoResolution.FrameSize.Height;
                int w = captureDevice.VideoDevice.VideoResolution.FrameSize.Width;
                AVIwriter.Open(saveAvi.FileName, w, h);
                butStop.Text = "Stop Record";
                //FinalVideo = captureDevice.VideoDevice;
                //FinalVideo.NewFrame += new NewFrameEventHandler(FinalVideo_NewFrame);
                //FinalVideo.Start();
            }
        }

        private void butStop_Click(object sender, EventArgs e)
        {
            if (butStop.Text == "Stop Record")//stop
            {
                butStop.Text = "Stop";
                if (FinalVideo == null)
                { return; }
                if (FinalVideo.IsRunning)
                {
                    //this.FinalVideo.Stop();
                    this.AVIwriter.Close();
                    pbVideo.Image = null;
                }
            }
            else
            {
                this.FinalVideo.Stop();
                this.AVIwriter.Close();
                pbVideo.Image = null;
            }
        }

        private void butCapture_Click(object sender, EventArgs e)
        {
            Photo1.Image = ScaleImage(pbVideo.Image,135,125);
            
            imagen = pbVideo.Image;

           /* SaveFileDialog Saveimg = new SaveFileDialog();
            Saveimg.Title = "Save image Files";
            Saveimg.Filter = "*.jpeg|*.jpeg|bitmap|*.bmp|Gif Image|*.gif|All files(*.*)|*.*";
            if (Saveimg.ShowDialog() == DialogResult.OK)
            {
                imagen.Save(Saveimg.FileName);
            }*/
            //pbVideo.Image.Save("IMG" + DateTime.Now.ToString("hhmmss") + ".jpg");
            
              
        }

        private void VideoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalVideo == null)
            { return; }
            if (FinalVideo.IsRunning)
            {
                this.FinalVideo.Stop();
                this.AVIwriter.Close();
            }
        }

        private void Photo1_DoubleClick(object sender, EventArgs e)
        {
            SaveFileDialog Saveimg = new SaveFileDialog();
            Saveimg.Title = "Save image Files";
            Saveimg.Filter = "*.jpeg|*.jpeg|bitmap|*.bmp|Gif Image|*.gif|All files(*.*)|*.*";
            if (Saveimg.ShowDialog() == DialogResult.OK)
            {
                imagen.Save(Saveimg.FileName);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (autotakepicture == true)
            {
                numericUpDown1.Value -= 1;
                if (numericUpDown1.Value == 0)
                {
                    Photo1.Image = ScaleImage(pbVideo.Image, 135, 125);
                    imagen = pbVideo.Image;
                    numericUpDown1.Value = 5;
                    autotakepicture = false;
                }
            }
           label1.Text=( DateTime.Now.ToString("hh:mm:ss"));
           if (label1.Text == label2.Text)
           {              
                   int h = captureDevice.VideoDevice.VideoResolution.FrameSize.Height;
                   int w = captureDevice.VideoDevice.VideoResolution.FrameSize.Width;                 
                   AVIwriter.Open("Vid"+DateTime.Now.ToString("hhmmsstt")+".avi", w, h);
                   //Thread.Sleep(5000);
                   //this.Hide();
                   MessageBox.Show("Recording");                
                   butStop.Text = "Stop Record";
                                   
           }
            
           if (label1.Text == label3.Text)
            {
                if (butStop.Text == "Stop Record")//stop
                {
                    butStop.Text = "Stop";
                    if (FinalVideo == null)
                    { return; }
                    if (FinalVideo.IsRunning)
                    {
                        //this.FinalVideo.Stop();
                        this.AVIwriter.Close();
                        MessageBox.Show("End Recording");
                        pbVideo.Image = null;
                    }
                }
                else
                {
                    this.FinalVideo.Stop();
                    this.AVIwriter.Close();
                    //MessageBox.Show("End Recording");
                    pbVideo.Image = null;
                }
                
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            horafin = maskedTextBox1.Text;
            horainicio = maskedTextBox2.Text;
            label2.Text = horainicio;;
            label3.Text = horafin;
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            autotakepicture = true;
        }

        

    }
}
