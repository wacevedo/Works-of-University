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
            
            // Timer 2 para hora
            timer2.Start();
            VideoCaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            captureDevice = new VideoCaptureDeviceForm();                         
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
            if (butStop.Text == "Stop Record")
            {
                video = (Bitmap)eventArgs.Frame.Clone();
                pbVideo.Image = (Bitmap)eventArgs.Frame.Clone();
                AVIwriter.Quality = 0;                
                AVIwriter.AddFrame(video);
            }
            else
            {
                video = (Bitmap)eventArgs.Frame.Clone();
                pbVideo.Image = (Bitmap)eventArgs.Frame.Clone();
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

        // Timer1

        private void timer1_Tick(object sender, EventArgs e) //Timer 1
        {
            string horaevento;


            horaevento = textBox1.Text;

            //Hacer Validacion que cuando la hora de inicio sea menor a la hora actual, MessageBox.Show("La hora inicial debe ser mayor o igual a la hora actual"); 
            // if (textBox1.Text <= textBox2.Text) { }


            //Incio Grabacion
            if (textBox1.Text == textBox2.Text)
            {
                
                if (captureDevice.ShowDialog(this) == DialogResult.OK) // Si la confg de la camara es OK , graba
                {
                    VideoCaptureDevice videoSource = captureDevice.VideoDevice;
                    FinalVideo = captureDevice.VideoDevice;
                    FinalVideo.NewFrame += new NewFrameEventHandler(FinalVideo_NewFrame);
                    FinalVideo.Start();
                }            

            }
            
            //Final Grabacion
            if (textBox5.Text == textBox2.Text)
            {
                if (butStop.Text == "Stop Record")//stop grabacion
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
        }
            

        private void pbVideo_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            textBox2.Text = string.Format("{0:HH:mm:ss}", DateTime.Now);
            textBox3.Text = Convert.ToString(DateTime.Now);
           

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Para el ListBox
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox5.Text);
            timer1.Start();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(listBox1.SelectedItem);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox5.Text = Convert.ToString(listBox2.SelectedItem);
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

       

    }
}
