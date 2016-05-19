using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VisualisadorImagen.Properties;



namespace VisualisadorImagen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Image Img;
        //Image imgpantalla;
        bool filtrogenerado = false;
        int PH, PW;
               
        
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Abrir=new OpenFileDialog();
            Abrir.Filter = ".Png|*.png|Jpg|*.jpg|jpeg|*.jpeg|bitmap|*.bmp|Gif Image|*.gif|All files(*.*)|*.*";
            Abrir.Title="Select image";
            if(Abrir.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                Pantalla.Image=new Bitmap(Abrir.FileName);
                Img = Pantalla.Image;
                PH = Pantalla.Image.Height;
                PW = Pantalla.Image.Width;
            }
            
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog Saveimg = new SaveFileDialog();
            Saveimg.Title = "Save image Files";
            Saveimg.Filter = "jpeg|*.jpeg|bitmap|*.bmp|Gif Image|*.gif|All files(*.*)|*.*";
            if (Saveimg.ShowDialog() == DialogResult.OK)
            {
                Pantalla.Image.Save(Saveimg.FileName);
            }
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pantalla.Image = null;
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Error: Impresora no Disponible" );
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* SaveFileDialog Saveimg = new SaveFileDialog();
            Saveimg.Title = "Save image Files";
            Saveimg.Filter = "*.jpeg|*.jpeg|bitmap|*.bmp|Gif Image|*.gif|All files(*.*)|*.*";
            if (Saveimg.ShowDialog() == DialogResult.OK)
            {
                Pantalla.Image.Save(Saveimg.FileName);
            }*/
            Close();
        }

        private void pantallaCompletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int minX, minY, maxX, maxY;
            minX = minY = int.MaxValue;
            maxX = maxY = int.MinValue;

            foreach (Screen screen in Screen.AllScreens)
            {
                var bounds = screen.Bounds;
                minX = Math.Min(minX, bounds.X);
                minY = Math.Min(minY, bounds.Y);
                maxX = Math.Max(maxX, bounds.Right);
                maxY = Math.Max(maxY, bounds.Bottom);
            }
        }

        private void salirPantallaCompletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            WindowState = FormWindowState.Normal;
            menuStrip1.Location = new Point(0, 0);
            //menuStrip1.BackColor=Color.Aquamarine;
        }
        
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
        
        private void ZoomIn_Click(object sender, EventArgs e)
        { 
            PW+=25;
            PH+=25;             
            Pantalla.Image = ScaleImage(Pantalla.Image, PW, PH);//Destruye los picxeles de  la imagen :(
            /*Pantalla.Height += 50;
            Pantalla.Width += 50;*/
        }

        private void ZoomOut_Click(object sender, EventArgs e)
        {
            PW -= 25;
            PH -= 25;
            Pantalla.Image = ScaleImage(Pantalla.Image, PW, PH); //Destruye los picxeles de  la imagen :(
            /*Pantalla.Height -= 50;
            Pantalla.Width -= 50;*/
        }
        
        private void trackBarBrillo_Scroll(object sender, EventArgs e)
        {
            /* Billo.Text = trackBarBrillo.Value.ToString();
            Pantalla.Image=AdjustBrightness((Bitmap)Pantalla.Image*/ //no sirve

            float value = trackBarBrillo.Value * 0.05f;
            float[][] colorMatrixElements = {
	        new float[] {1,0,0,0,0},            
            new float[] {0,1,0,0,0},
            new float[] {0,0,1,0,0},
            new float[] {0,0,0,1,0},
            new float[] {value,value,value,0,1}
            
                                            };
            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            Image _img = Img; //Se iguala una copia de lo que tiene  la pantalla picturebox
            
            Graphics _g = default(Graphics);
            Bitmap bm_dest = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
            _g = Graphics.FromImage(bm_dest);
            _g.DrawImage(_img, new Rectangle(0, 0, bm_dest.Width + 1, bm_dest.Height + 1), 0, 0, bm_dest.Width + 1, bm_dest.Height + 1, GraphicsUnit.Pixel, imageAttributes);
            Pantalla.Image = bm_dest;
            
        }

        private void derecha_Click(object sender, EventArgs e)
        {
            Pantalla.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);            
            Pantalla.Refresh();
        }

        private void izquierda_Click(object sender, EventArgs e)
        {
            Pantalla.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            Pantalla.Refresh();
        }

        private void buttonVertical_Click(object sender, EventArgs e)
        {
            Pantalla.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            Pantalla.Refresh();
        }

        private void buttonHorizontal_Click(object sender, EventArgs e)
        {
            Pantalla.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            Pantalla.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pantalla.AllowDrop = true;
            string[] filtersName = { "Normal","Janeiro", "Soleado", "Orange", "Cloudy", "Aspen", "NeonWhite", "1980", "Wasatch", "Rio" };


            for (int i = 0; i < filtersName.Length; i++)
            {
                domainUpDown1.Items.Add(filtersName[i]);
            }
            domainUpDown1.SelectedIndex=0;
        }

        private void trackBarFrio_Scroll(object sender, EventArgs e)
        {
            float value = trackBarFrio.Value * 0.05f;
            float[][] colorMatrixElements = {
	        new float[] {1,0,0,0,0},
            new float[] {value,	value,value,0,1},
            new float[] {0,1,0,0,0},
            new float[] {0,0,1,0,0},
            new float[] {0,0,0,1,0}
            
                                            };
            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            Image _img = Img; //Se iguala una copia de lo que tiene  la pantalla picturebox

            Graphics _g = default(Graphics);
            Bitmap bm_dest = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
            _g = Graphics.FromImage(bm_dest);
            _g.DrawImage(_img, new Rectangle(0, 0, bm_dest.Width + 1, bm_dest.Height + 1), 0, 0, bm_dest.Width + 1, bm_dest.Height + 1, GraphicsUnit.Pixel, imageAttributes);
            Pantalla.Image = bm_dest;
        }

        private void trackBarAnaranjado_Scroll(object sender, EventArgs e)
        {
            float value = trackBarAnaranjado.Value * 0.05f;
            float[][] colorMatrixElements = {
	        new float[] {1,0,0,0,0},            
            new float[] {0,1,0,0,0},
            new float[] {value,0,1,0,0},
            new float[] {value,0,0,1,0},
            new float[] {value,	value,value,0,1}
            
                                            };
            
            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            Image _img = Img; //Se iguala una copia de lo que tiene  la pantalla picturebox

            Graphics _g = default(Graphics);
            Bitmap bm_dest = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
            _g = Graphics.FromImage(bm_dest);
            _g.DrawImage(_img, new Rectangle(0, 0, bm_dest.Width + 1, bm_dest.Height + 1), 0, 0, bm_dest.Width + 1, bm_dest.Height + 1, GraphicsUnit.Pixel, imageAttributes);
            Pantalla.Image = bm_dest;
            
        }
        private float valueN1, valueN2, valueN3, valueN4, valueN5;
        private float value1, value2, value3, value4, value5;
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            value1 = trackBar2.Value * 0.05f;
            value2 = trackBar3.Value * 0.05f;
            value3 = trackBar1.Value * 0.05f;
            value4 = trackBar4.Value * 0.05f;
            value5= trackBar5.Value * 0.05f;
            valueN1 = Convert.ToSingle(numericUpDown1.Value);
            valueN2 = Convert.ToSingle(numericUpDown2.Value);
            valueN3 = Convert.ToSingle(numericUpDown3.Value);
            valueN4 = Convert.ToSingle(numericUpDown4.Value);
            valueN5 = Convert.ToSingle(numericUpDown5.Value);
            float[][] colorMatrixElements = {
	        new float[] {valueN1,value1,value1,value1,value1},            
            new float[] {value2,valueN2,value2,value2,value2},
            new float[] {value3,value3,valueN3,value3,value3},
            new float[] {value4,value4,value4,valueN4,value4},
            new float[] {value5,value5,value5,value5,valueN5}
            
                                            };
            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            Image _img = Img; //Se iguala una copia de lo que tiene  la pantalla picturebox

            Graphics _g = default(Graphics);
            Bitmap bm_dest = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
            _g = Graphics.FromImage(bm_dest);
            _g.DrawImage(_img, new Rectangle(0, 0, bm_dest.Width + 1, bm_dest.Height + 1), 0, 0, bm_dest.Width + 1, bm_dest.Height + 1, GraphicsUnit.Pixel, imageAttributes);
            Pantalla.Image = bm_dest;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            float value1 = trackBar2.Value * 0.05f;
            float value2 = trackBar3.Value * 0.05f;
            float value3 = trackBar1.Value * 0.05f;
            float value4 = trackBar4.Value * 0.05f;
            float value5 = trackBar5.Value * 0.05f;
            valueN1 = Convert.ToSingle(numericUpDown1.Value);
            valueN2 = Convert.ToSingle(numericUpDown2.Value);
            valueN3 = Convert.ToSingle(numericUpDown3.Value);
            valueN4 = Convert.ToSingle(numericUpDown4.Value);
            valueN5 = Convert.ToSingle(numericUpDown5.Value);
            float[][] colorMatrixElements = {
	        new float[] {valueN1,value1,value1,value1,value1},            
            new float[] {value2,valueN2,value2,value2,value2},
            new float[] {value3,value3,valueN3,value3,value3},
            new float[] {value4,value4,value4,valueN4,value4},
            new float[] {value5,value5,value5,value5,valueN5}
            
                                            };
            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            Image _img = Img; //Se iguala una copia de lo que tiene  la pantalla picturebox

            Graphics _g = default(Graphics);
            Bitmap bm_dest = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
            _g = Graphics.FromImage(bm_dest);
            _g.DrawImage(_img, new Rectangle(0, 0, bm_dest.Width + 1, bm_dest.Height + 1), 0, 0, bm_dest.Width + 1, bm_dest.Height + 1, GraphicsUnit.Pixel, imageAttributes);
            Pantalla.Image = bm_dest;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            float value1 = trackBar2.Value * 0.05f;
            float value2 = trackBar3.Value * 0.05f;
            float value3 = trackBar1.Value * 0.05f;
            float value4 = trackBar4.Value * 0.05f;
            float value5 = trackBar5.Value * 0.05f;
            valueN1 = Convert.ToSingle(numericUpDown1.Value);
            valueN2 = Convert.ToSingle(numericUpDown2.Value);
            valueN3 = Convert.ToSingle(numericUpDown3.Value);
            valueN4 = Convert.ToSingle(numericUpDown4.Value);
            valueN5 = Convert.ToSingle(numericUpDown5.Value);
            float[][] colorMatrixElements = {
	        new float[] {valueN1,value1,value1,value1,value1},            
            new float[] {value2,valueN2,value2,value2,value2},
            new float[] {value3,value3,valueN3,value3,value3},
            new float[] {value4,value4,value4,valueN4,value4},
            new float[] {value5,value5,value5,value5,valueN5}
            
                                            };
            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            Image _img = Img; //Se iguala una copia de lo que tiene  la pantalla picturebox

            Graphics _g = default(Graphics);
            Bitmap bm_dest = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
            _g = Graphics.FromImage(bm_dest);
            _g.DrawImage(_img, new Rectangle(0, 0, bm_dest.Width + 1, bm_dest.Height + 1), 0, 0, bm_dest.Width + 1, bm_dest.Height + 1, GraphicsUnit.Pixel, imageAttributes);
            Pantalla.Image = bm_dest;
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            float value1 = trackBar2.Value * 0.05f;
            float value2 = trackBar3.Value * 0.05f;
            float value3 = trackBar1.Value * 0.05f;
            float value4 = trackBar4.Value * 0.05f;
            float value5 = trackBar5.Value * 0.05f;
            valueN1 = Convert.ToSingle(numericUpDown1.Value);
            valueN2 = Convert.ToSingle(numericUpDown2.Value);
            valueN3 = Convert.ToSingle(numericUpDown3.Value);
            valueN4 = Convert.ToSingle(numericUpDown4.Value);
            valueN5 = Convert.ToSingle(numericUpDown5.Value);
            float[][] colorMatrixElements = {
	        new float[] {valueN1,value1,value1,value1,value1},            
            new float[] {value2,valueN2,value2,value2,value2},
            new float[] {value3,value3,valueN3,value3,value3},
            new float[] {value4,value4,value4,valueN4,value4},
            new float[] {value5,value5,value5,value5,valueN5}
            
                                            };
            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            Image _img = Img; //Se iguala una copia de lo que tiene  la pantalla picturebox

            Graphics _g = default(Graphics);
            Bitmap bm_dest = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
            _g = Graphics.FromImage(bm_dest);
            _g.DrawImage(_img, new Rectangle(0, 0, bm_dest.Width + 1, bm_dest.Height + 1), 0, 0, bm_dest.Width + 1, bm_dest.Height + 1, GraphicsUnit.Pixel, imageAttributes);
            Pantalla.Image = bm_dest;
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            float value1 = trackBar2.Value * 0.05f;
            float value2 = trackBar3.Value * 0.05f;
            float value3 = trackBar1.Value * 0.05f;
            float value4 = trackBar4.Value * 0.05f;
            float value5 = trackBar5.Value * 0.05f;
            valueN1 = Convert.ToSingle(numericUpDown1.Value);
            valueN2 = Convert.ToSingle(numericUpDown2.Value);
            valueN3 = Convert.ToSingle(numericUpDown3.Value);
            valueN4 = Convert.ToSingle(numericUpDown4.Value);
            valueN5 = Convert.ToSingle(numericUpDown5.Value);
            float[][] colorMatrixElements = {
	        new float[] {valueN1,value1,value1,value1,value1},            
            new float[] {value2,valueN2,value2,value2,value2},
            new float[] {value3,value3,valueN3,value3,value3},
            new float[] {value4,value4,value4,valueN4,value4},
            new float[] {value5,value5,value5,value5,valueN5}
            
                                            };
            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            Image _img = Img; //Se iguala una copia de lo que tiene  la pantalla picturebox

            Graphics _g = default(Graphics);
            Bitmap bm_dest = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
            _g = Graphics.FromImage(bm_dest);
            _g.DrawImage(_img, new Rectangle(0, 0, bm_dest.Width + 1, bm_dest.Height + 1), 0, 0, bm_dest.Width + 1, bm_dest.Height + 1, GraphicsUnit.Pixel, imageAttributes);
            Pantalla.Image = bm_dest;
        }

        private void buttonValorOrg_Click(object sender, EventArgs e)
        {
            trackBarAnaranjado.Value = 0;
            trackBarBrillo.Value = 0;
            trackBarEscalaGrises.Value = 0;
            trackBarFrio.Value = 0;
            trackBarNegativo.Value = 0;
            trackBarPolaroid.Value = 0;
            trackBarSepia.Value = 0;
            trackBarSingleTrans.Value = 0;
            trackBar1.Value = 0;
            trackBar2.Value = 0;
            trackBar3.Value = 0;            
            trackBar4.Value = 0;
            trackBar5.Value = 0;
            numericUpDown1.Value = 1;
            numericUpDown2.Value = 1;
            numericUpDown3.Value=1;
            numericUpDown4.Value=1;
            numericUpDown5.Value=1;

            float value1 = trackBar2.Value * 0.05f;
            float value2 = trackBar3.Value * 0.05f;
            float value3 = trackBar1.Value * 0.05f;
            float value4 = trackBar4.Value * 0.05f;
            float value5 = trackBar5.Value * 0.05f;
            valueN1 = Convert.ToSingle(numericUpDown1.Value);
            valueN2 = Convert.ToSingle(numericUpDown2.Value);
            valueN3 = Convert.ToSingle(numericUpDown3.Value);
            valueN4 = Convert.ToSingle(numericUpDown4.Value);
            valueN5 = Convert.ToSingle(numericUpDown5.Value);

            float[][] colorMatrixElements = {
	        new float[] {valueN1,value1,value1,value1,value1},            
            new float[] {value2,valueN2,value2,value2,value2},
            new float[] {value3,value3,valueN3,value3,value3},
            new float[] {value4,value4,value4,valueN4,value4},
            new float[] {value5,value5,value5,value5,valueN5}            
                                            };
            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            Image _img = Img; //Se iguala una copia de lo que tiene  la pantalla picturebox

            Graphics _g = default(Graphics);
            Bitmap bm_dest = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
            _g = Graphics.FromImage(bm_dest);
            _g.DrawImage(_img, new Rectangle(0, 0, bm_dest.Width + 1, bm_dest.Height + 1), 0, 0, bm_dest.Width + 1, bm_dest.Height + 1, GraphicsUnit.Pixel, imageAttributes);
            Pantalla.Image = bm_dest;
        }

        private void trackBarEscalaGrises_Scroll(object sender, EventArgs e)
        {
            float value = trackBarEscalaGrises.Value * 0.05f;
            float[][] colorMatrixElements = {
	        new float[] {.3f, .3f, .3f, 0, 0},
            new float[] {.59f, .59f, .59f, 0, 0},
            new float[] {.11f, .11f, .11f, 0, 0},
            new float[] {0,0,0,1,0},
            new float[] {value,	value,value,0,1}            
                                            };
            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            Image _img = Img; //Se iguala una copia de lo que tiene  la pantalla picturebox

            Graphics _g = default(Graphics);
            Bitmap bm_dest = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
            _g = Graphics.FromImage(bm_dest);
            _g.DrawImage(_img, new Rectangle(0, 0, bm_dest.Width + 1, bm_dest.Height + 1), 0, 0, bm_dest.Width + 1, bm_dest.Height + 1, GraphicsUnit.Pixel, imageAttributes);
            Pantalla.Image = bm_dest;
        }

        private void trackBarSepia_Scroll(object sender, EventArgs e)
        {
            float value = trackBarSepia.Value * 0.05f;
            float[][] colorMatrixElements = {
	        new float[] {.393f, .349f, .272f, 0, 0},
            new float[] {.769f, .686f, .534f, 0, 0},
            new float[] {.189f, .168f, .131f, 0, 0},
            new float[] {0,0,0,1,0},
            new float[] {value,	value,value,0,1}            
                                            };
            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            Image _img = Img; //Se iguala una copia de lo que tiene  la pantalla picturebox

            Graphics _g = default(Graphics);
            Bitmap bm_dest = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
            _g = Graphics.FromImage(bm_dest);
            _g.DrawImage(_img, new Rectangle(0, 0, bm_dest.Width + 1, bm_dest.Height + 1), 0, 0, bm_dest.Width + 1, bm_dest.Height + 1, GraphicsUnit.Pixel, imageAttributes);
            Pantalla.Image = bm_dest;
        }

        private void trackBarNegativo_Scroll(object sender, EventArgs e)
        {
            float value = trackBarNegativo.Value * 0.05f;
            float[][] colorMatrixElements = {
	        new float[] {-1, 0, 0,0 , 0},
            new float[] {0, -1, 0, 0, 0},
            new float[] {value, value, -1, value, value},
            new float[] {0,0,0,1,0},
            new float[] {1,1,1,1,1},          
                                            };
            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            Image _img = Img; //Se iguala una copia de lo que tiene  la pantalla picturebox

            Graphics _g = default(Graphics);
            Bitmap bm_dest = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
            _g = Graphics.FromImage(bm_dest);
            _g.DrawImage(_img, new Rectangle(0, 0, bm_dest.Width + 1, bm_dest.Height + 1), 0, 0, bm_dest.Width + 1, bm_dest.Height + 1, GraphicsUnit.Pixel, imageAttributes);
            Pantalla.Image = bm_dest;
        }

        private void buttonRestaurar_Click(object sender, EventArgs e)
        {
            Pantalla.Image = Img;
        }

        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            float valuec = trackBar6.Value * 0.25f;
            float valuet = ((1.0f - trackBar6.Value) / 2.0f)*0.05f;
            float[][] colorMatrixElements = {
	        new float[] {valuec, 0, 0,0 , 0},
            new float[] {0, valuec, 0, 0, 0},
            new float[] {0, 0, valuec, 0, 0},
            new float[] {0,0,0,1,0},
            new float[] {valuet,valuet,valuet,0,1},          
                                            };
            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            Image _img = Img; //Se iguala una copia de lo que tiene  la pantalla picturebox

            Graphics _g = default(Graphics);
            Bitmap bm_dest = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
            _g = Graphics.FromImage(bm_dest);
            _g.DrawImage(_img, new Rectangle(0, 0, bm_dest.Width + 1, bm_dest.Height + 1), 0, 0, bm_dest.Width + 1, bm_dest.Height + 1, GraphicsUnit.Pixel, imageAttributes);
            Pantalla.Image = bm_dest;
        }

        private void trackBarSaturacion_Scroll(object sender, EventArgs e)
        {
            float lumR = 0.3086f;  //or  0.2125
            float lumG = 0.6094f;  //or  0.7154
            float lumB = 0.0820f;  //or  0.0721
            float S = trackBarSaturacion.Value*0.25f;  
            float Sr = (1-S)*lumR;
            float Sg = (1 - S) * lumG;
            float Sb = (1 - S) * lumB;

            float[][] colorMatrixElements = {
	        new float[] {Sr+S, Sr, Sr,0 , 0},
            new float[] {Sg, Sg+S, Sg , 0, 0},
            new float[] {Sb,  Sb, Sb+S, 0, 0},
            new float[] {0,0,0,1,0},
            new float[] {0,0,0,0,1},          
                                            };
            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            Image _img = Img; //Se iguala una copia de lo que tiene  la pantalla picturebox

            Graphics _g = default(Graphics);
            Bitmap bm_dest = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
            _g = Graphics.FromImage(bm_dest);
            _g.DrawImage(_img, new Rectangle(0, 0, bm_dest.Width + 1, bm_dest.Height + 1), 0, 0, bm_dest.Width + 1, bm_dest.Height + 1, GraphicsUnit.Pixel, imageAttributes);
            Pantalla.Image = bm_dest;
        }

        private void trackBarPolaroid_Scroll(object sender, EventArgs e)
        {
            //Polaroid Color

            float value = trackBarPolaroid.Value * 0.05f;
            float[][] colorMatrixElements = {
	        new float[] {1.438f,-0.062f+value,-0.062f+value,0,0},
            new float[] {-0.122f,1.378f	,-0.122f,0,0},
            new float[] {-0.016f+value,-0.016f+value,1.483f,0,0},
            new float[] {0,0,0,1,0},
            new float[] {(-0.03f+value),(0.05f+value),(-0.02f+value),0,1}
           
                                            };
            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            Image _img = Img; //Se iguala una copia de lo que tiene  la pantalla picturebox

            Graphics _g = default(Graphics);
            Bitmap bm_dest = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
            _g = Graphics.FromImage(bm_dest);
            _g.DrawImage(_img, new Rectangle(0, 0, bm_dest.Width + 1, bm_dest.Height + 1), 0, 0, bm_dest.Width + 1, bm_dest.Height + 1, GraphicsUnit.Pixel, imageAttributes);
            Pantalla.Image = bm_dest;

        }

        private void trackBarSingleTrans_Scroll(object sender, EventArgs e)
        {
               /*R  [c(sr+s) c(sr)  c(sr)    0      0   ]
                 G  [ c(sg) c(sg+s) c(sg)    0      0   ]
         ===>    B  [ c(sb)  c(sb) c(sb+s)   0      0   ]
                 A  [   0      0      0      1      0   ]
                 W  [  t+b    t+b    t+b     0      1   ]
                c=s=b*/
            float lumR = 0.3086f;  //or  0.2125
            float lumG = 0.6094f;  //or  0.7154
            float lumB = 0.0820f;  //or  0.0721
            

            float V = trackBarSingleTrans.Value * 0.05f;
            float Sr = (1 - V) * lumR;
            float Sg = (1 - V) * lumG;
            float Sb = (1 - V) * lumB;
            float t = ((1.0f - trackBarSingleTrans.Value) / 2.0f) * 0.05f;
            float[][] colorMatrixElements = {
	        new float[] {1.25f+V,(V*Sr),(V*Sr),0,0},            
            new float[] {0.2f+V,(V*Sg)+1,(V*Sg),0,0},
            new float[] {(V*Sb),(V*Sb),(V*Sb)+1f,0,0},
            new float[] {0,0.1f,0,1,0},
            new float[] {t,t,t,0,1}
            
                                            };

            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            Image _img = Img; //Se iguala una copia de lo que tiene  la pantalla picturebox

            Graphics _g = default(Graphics);
            Bitmap bm_dest = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
            _g = Graphics.FromImage(bm_dest);
            _g.DrawImage(_img, new Rectangle(0, 0, bm_dest.Width + 1, bm_dest.Height + 1), 0, 0, bm_dest.Width + 1, bm_dest.Height + 1, GraphicsUnit.Pixel, imageAttributes);
            Pantalla.Image = bm_dest;

        }

        

        Colormatrix GenerarColor = new Colormatrix();
         
        private void generarColorDeMatrisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            GenerarColor.PantallaPrueba.Image = ScaleImage(Pantalla.Image, 230, 200);
            GenerarColor.Img = GenerarColor.PantallaPrueba.Image;
            GenerarColor.PantallaCopia = Img;
            GenerarColor.PantallaCopiaImg = Img;
            GenerarColor.Show();
            filtrogenerado = true;
                       
        }

        private void generarColorDeMatris()
        {
            GenerarColor.PantallaPrueba.Image = ScaleImage(Pantalla.Image, 230, 200);
            GenerarColor.Img = GenerarColor.PantallaPrueba.Image;
            GenerarColor.PantallaCopia = Img;
            GenerarColor.PantallaCopiaImg = Img;
            GenerarColor.Show();
            filtrogenerado = true;
        }
        private void buttonAplicarColor_Click(object sender, EventArgs e)
        {
            if (filtrogenerado == false)
            {
                 var Error = MessageBox.Show("No se ha Generado ningun Filtro, Desea generar uno?", "Error de Generacion", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                 if (Error == DialogResult.Yes)
                 {
                     generarColorDeMatris();                     
                 }
            }
            else
            {
               Pantalla.Image = GenerarColor.PantallaCopia;
            }

        }

        # region "-----------------------------Crop Image------------------------------------"

        public bool Makeselection = false;
        int cropX;
        int cropY;
        int cropWidth;
        int cropHeight;
        /*int oCropX;
        int oCropY;*/
        public bool CreateText = false;
        public Pen cropPen;
        public DashStyle cropDashStyle = DashStyle.DashDot;

        
        private void btnMakeSelection_Click(object sender, EventArgs e)
        {
            Makeselection = true;
            buttonCortar.Enabled = true;
            
        }

        private void buttonCortar_Click(object sender, EventArgs e)
        {

            Cursor = Cursors.Default;

            try
            {
                if (cropWidth < 1)
                {
                    return;
                }
                Rectangle rect = new Rectangle(cropX, cropY, cropWidth, cropHeight);
                //First we define a rectangle with the help of already calculated points
                Bitmap OriginalImage = new Bitmap(Pantalla.Image, Pantalla.Width, Pantalla.Height);
                //Original image
                Bitmap _img = new Bitmap(cropWidth, cropHeight);
                // for cropinf image
                Graphics g = Graphics.FromImage(_img);
                // create graphics
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                //set image attributes
                g.DrawImage(OriginalImage, 0, 0, rect, GraphicsUnit.Pixel);

                Pantalla.Image = _img;
                Pantalla.Width = _img.Width;
                Pantalla.Height = _img.Height;
                //PictureBoxLocation();
                buttonCortar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:"+ex.Message);
            }
        }


        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (tabControl1.SelectedIndex == 8)
            {
                Point TextStartLocation = e.Location;
                if (CreateText)
                {
                    Cursor = Cursors.IBeam;
                }
            }
            else
            {
                Cursor = Cursors.Default;
                if (Makeselection)
                {

                    try
                    {
                        if (e.Button == System.Windows.Forms.MouseButtons.Left)
                        {
                            Cursor = Cursors.Cross;
                            cropX = e.X;
                            cropY = e.Y;

                            cropPen = new Pen(Color.Black, 1);
                            cropPen.DashStyle = DashStyle.DashDotDot;


                        }
                        Pantalla.Refresh();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex.Message);
                    }
                }
            }


        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (Makeselection)
            {
                Cursor = Cursors.Default;
            }

        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (tabControl1.SelectedIndex == 8)
            {
                Point TextStartLocation = e.Location;
                if (CreateText)
                {
                    Cursor = Cursors.IBeam;
                }
            }
            else
            {
                Cursor = Cursors.Default;
                if (Makeselection)
                {

                    try
                    {
                        if (Pantalla.Image == null)
                            return;


                        if (e.Button == System.Windows.Forms.MouseButtons.Left)
                        {
                            Cursor = Cursors.Cross;
                            Pantalla.Refresh();
                            cropWidth = e.X - cropX;
                            cropHeight = e.Y - cropY;
                            Pantalla.CreateGraphics().DrawRectangle(cropPen, cropX, cropY, cropWidth, cropHeight);
                        }



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex.Message);
                        //if (ex.Number == 5)
                        //    return;
                    }
                }
            }

        }
        # endregion

        private void Pantalla_DragDrop(object sender, DragEventArgs e)
        {
            string[] Filelist =(string[])e.Data.GetData(DataFormats.FileDrop,false);
            Pantalla.Image=Image.FromFile(Filelist[0]);            
            Img = Pantalla.Image;
            PH = Pantalla.Image.Height;
            PW = Pantalla.Image.Width;
        }

        private void Pantalla_DragEnter(object sender, DragEventArgs e)
        {
            //{
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
            //}
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            Pantalla.Image = Img;
            ImagenFiltro imgfilter = new ImagenFiltro(Pantalla.Image, Convert.ToString(domainUpDown1.SelectedItem));
            Pantalla.Image = imgfilter.img;

        }

       

       

       

        
    }
}
