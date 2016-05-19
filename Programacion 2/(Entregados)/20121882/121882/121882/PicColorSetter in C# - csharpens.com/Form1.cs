using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//adding reference to library
using System.Drawing.Imaging;

namespace PicColorSetter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //setting initial values
            RedSelection.Value = 255;
            GreenSelection.Value = 255;
            BlueSelection.Value = 255;
            BrightnessSelection.Value = 126;
            SelectedColor.BackColor = Color.FromArgb(RedSelection.Value, GreenSelection.Value, BlueSelection.Value);
            ColorPictur();
            
            RedSelection.Enabled = false;
            GreenSelection.Enabled = false;
            BlueSelection.Enabled = false;
            BrightnessSelection.Enabled = false;
            
            Izquierda.Enabled = false;
            Derecha.Enabled = false;
            Vertical.Enabled = false;
            Horizontal.Enabled = false;
            button2.Enabled = false;
            SavePicBtn.Enabled = false;

        }
        private void scrColorComponent_Scroll(object sender, ScrollEventArgs e)
        {
            //redrawing & adjusting the selected color
            SelectedColor.BackColor = Color.FromArgb(RedSelection.Value, GreenSelection.Value, BlueSelection.Value);
            ColorPictur();
        }
        private void ColorPictur()
        {
            //applyig color
            picToned.Image = ToColorTone(picOriginal.Image, SelectedColor.BackColor);
        }
        private Bitmap ToColorTone(Image image, Color color)
        {
            //creating a new bitmap image with selected color.
            float scale = BrightnessSelection.Value / 128f;

            float r = color.R / 255f * scale;
            float g = color.G / 255f * scale;
            float b = color.B / 255f * scale;

            // Color Matrix
            ColorMatrix cm = new ColorMatrix(new float[][]
            {
                new float[] {r, 0, 0, 0, 0},
                new float[] {0, g, 0, 0, 0},
                new float[] {0, 0, b, 0, 0},
                new float[] {0, 0, 0, 1, 0},
                new float[] {0, 0, 0, 0, 1}
            });
            ImageAttributes ImAttribute = new ImageAttributes();
            ImAttribute.SetColorMatrix(cm);

            //Color Matrix on new bitmap image
            Point[] points =
            {
                new Point(0, 0),
                new Point(image.Width - 1, 0),
                new Point(0, image.Height - 1),
            };
            Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);

            Bitmap myBitmap = new Bitmap(image.Width, image.Height);
            using (Graphics graphics = Graphics.FromImage(myBitmap))
            {
                graphics.DrawImage(image, points, rect, GraphicsUnit.Pixel, ImAttribute);
            }
            return myBitmap;
        }

        private void SavePicBtn_Click(object sender, EventArgs e)
        {
            //saving image file
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";

            sfd.ShowDialog();
            string filename = sfd.FileName;
            picToned.Image.Save(filename);
            
        }

        private void Derecha_Click(object sender, EventArgs e)
        {
            picToned.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            picToned.Refresh();
        }

        private void Izquierda_Click(object sender, EventArgs e)
        {
            picToned.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            picToned.Refresh();
        }

        private void Vertical_Click(object sender, EventArgs e)
        {
            picToned.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            picToned.Refresh();
        }

        private void Horizontal_Click(object sender, EventArgs e)
        {
            picToned.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            picToned.Refresh();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "";
            abrir.Title = "Select image";
            
            


            if (abrir.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                picOriginal.Image = new Bitmap(abrir.FileName);
                RedSelection.Enabled = true;
                GreenSelection.Enabled = true;
                BlueSelection.Enabled = true;
                BrightnessSelection.Enabled = true;
                
                Izquierda.Enabled = true;
                Derecha.Enabled = true;
                Vertical.Enabled = true;
                Horizontal.Enabled = true; 
                button2.Enabled = true;
                SavePicBtn.Enabled = true;                
                picToned.Image = picOriginal.Image;
            }


           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            picToned.Image = picOriginal.Image;
            RedSelection.Value = 255;
            GreenSelection.Value = 255;
            BlueSelection.Value = 255;
            BrightnessSelection.Value = 126;
        }
    }
}
