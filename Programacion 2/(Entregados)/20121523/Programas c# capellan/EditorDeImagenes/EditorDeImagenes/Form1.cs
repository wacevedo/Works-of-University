using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing.Drawing2D;

namespace EditorDeImagenes
{
    public partial class Form1 : Form
    {

        int anc, lar;
        Image img;
        Item currItem;
        Color dibujarcolor;
        int x, y;
        public Form1()
        {
            InitializeComponent();
        }
        public enum Item
        {
            Text, None
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "Png files|*.png|jpeg files|*jpg|bitmaps|*.bmp";
            if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Pantalla.Image = (Image)Image.FromFile(o.FileName).Clone();
                anc = Pantalla.Image.Width;
                lar = Pantalla.Image.Height;
                img = Pantalla.Image;
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(Pantalla.Width, Pantalla.Height);
            Graphics g = Graphics.FromImage(bmp);
            Rectangle rect = Pantalla.RectangleToScreen(Pantalla.ClientRectangle);
            g.CopyFromScreen(rect.Location, Point.Empty, Pantalla.Size);
            g.Dispose();
            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "Png files|*.png|jpeg files|*.jpg|bitmaps|*.bmp";
            if (s.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (File.Exists(s.FileName))
                {
                    File.Delete(s.FileName);
                }
                if (s.FileName.Contains(".jpg"))
                {
                    bmp.Save(s.FileName, ImageFormat.Jpeg);
                }
                else if (s.FileName.Contains(".png"))
                {
                    bmp.Save(s.FileName, ImageFormat.Png);
                }
                else if (s.FileName.Contains(".bmp"))
                {
                    bmp.Save(s.FileName, ImageFormat.Bmp);
                }
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pantalla.Refresh();
            Pantalla.Image = null;
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RotarDer_Click(object sender, EventArgs e)
        {
            Pantalla.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            Pantalla.Refresh();
        }

        private void RotarIzq_Click(object sender, EventArgs e)
        {
            Pantalla.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            Pantalla.Refresh();
        }

        private void Horizontal_Click(object sender, EventArgs e)
        {
            Pantalla.Image.RotateFlip(RotateFlipType.Rotate90FlipX);
            Pantalla.Refresh();
        }

        private void Vertical_Click(object sender, EventArgs e)
        {
            Pantalla.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            Pantalla.Refresh();
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
                MessageBox.Show("Error:" + ex.Message);
            }
        }


        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.TabIndex == 28)
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
            if (this.TabIndex == 28)
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

        private void button2_Click(object sender, EventArgs e)
        {
            anc += 25;
            lar += 25;
            Pantalla.Image = ScaleImage(Pantalla.Image, anc, lar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            anc -= 25;
            lar -= 25;
            Pantalla.Image = ScaleImage(Pantalla.Image, anc, lar);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            float value = trackBarB.Value * 0.05f;
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

            Image _img = img;

            Graphics _g = default(Graphics);
            Bitmap bm_dest = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
            _g = Graphics.FromImage(bm_dest);
            _g.DrawImage(_img, new Rectangle(0, 0, bm_dest.Width + 1, bm_dest.Height + 1), 0, 0, bm_dest.Width + 1, bm_dest.Height + 1, GraphicsUnit.Pixel, imageAttributes);
            Pantalla.Image = bm_dest;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            float c = trackBarC.Value * 0.25f;
            float t = ((1.0f - trackBarC.Value) / 2.0f) * 0.05f;
            float[][] colorMatrixElements = {
	        new float[] {c,0,0,0,0},            
            new float[] {0,c,0,0,0},
            new float[] {0,0,c,0,0},
            new float[] {0,0,0,1,0},
            new float[] {t,t,t,0,1}
            
                                            };
            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            Image _img = img;

            Graphics _g = default(Graphics);
            Bitmap bm_dest = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
            _g = Graphics.FromImage(bm_dest);
            _g.DrawImage(_img, new Rectangle(0, 0, bm_dest.Width + 1, bm_dest.Height + 1), 0, 0, bm_dest.Width + 1, bm_dest.Height + 1, GraphicsUnit.Pixel, imageAttributes);
            Pantalla.Image = bm_dest;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            float R = 0.3086f;  //or  0.2125
            float G = 0.6094f;  //or  0.7154
            float B = 0.0820f;  //or  0.0721
            float S = trackBarS.Value*0.25f;  
            float R1 = (1-S)*R;
            float G1 = (1 - S) * G;
            float B1 = (1 - S) * B;

            float[][] colorMatrixElements = {
	        new float[] {R1+S, R1, R1,0 , 0},
            new float[] {G1, G1+S, G1 , 0, 0},
            new float[] {B1, B1, B1+S, 0, 0},
            new float[] {0,0,0,1,0},
            new float[] {0,0,0,0,1},
                                            };

            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            Image _img = img;

            Graphics _g = default(Graphics);
            Bitmap bm_dest = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
            _g = Graphics.FromImage(bm_dest);
            _g.DrawImage(_img, new Rectangle(0, 0, bm_dest.Width + 1, bm_dest.Height + 1), 0, 0, bm_dest.Width + 1, bm_dest.Height + 1, GraphicsUnit.Pixel, imageAttributes);
            Pantalla.Image = bm_dest;

        }

        private void restaurarImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pantalla.Image = img;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currItem = Item.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pantalla.AllowDrop = true;
            FontFamily[] family = FontFamily.Families;
            foreach (FontFamily font in family)
            {
                toolStripComboBox2.Items.Add(font.GetName(1).ToString());
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Graphics g = Pantalla.CreateGraphics();
            if (currItem == Item.Text)
            {
                if (toolStripComboBox4.Text == "Regular")
                {
                    g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Regular), new SolidBrush(dibujarcolor), new PointF(x, y));
                }
                else if (toolStripComboBox4.Text == "Bold")
                {
                    g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Bold), new SolidBrush(dibujarcolor), new PointF(x, y));
                }
                else if (toolStripComboBox4.Text == "Underline")
                {
                    g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Underline), new SolidBrush(dibujarcolor), new PointF(x, y));
                }
                else if (toolStripComboBox4.Text == "Strikeout")
                {
                    g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Strikeout), new SolidBrush(dibujarcolor), new PointF(x, y));
                }
                else if (toolStripComboBox4.Text == "Italic")
                {
                    g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Italic), new SolidBrush(dibujarcolor), new PointF(x, y));
                }
                if (toolStripComboBox1.Text == "SE")
                {
                    if (toolStripComboBox4.Text == "Regular")
                    {
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Regular), new SolidBrush(Color.Gray), new PointF(x + 5, y + 5));
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Regular), new SolidBrush(dibujarcolor), new PointF(x, y));
                    }
                    else if (toolStripComboBox4.Text == "Bold")
                    {
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Bold), new SolidBrush(Color.Gray), new PointF(x + 5, y + 5));
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Bold), new SolidBrush(dibujarcolor), new PointF(x, y));
                    }
                    else if (toolStripComboBox4.Text == "Underline")
                    {
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Underline), new SolidBrush(Color.Gray), new PointF(x + 5, y + 5));
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Underline), new SolidBrush(dibujarcolor), new PointF(x, y));
                    }
                    else if (toolStripComboBox4.Text == "Strikeout")
                    {
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Strikeout), new SolidBrush(Color.Gray), new PointF(x + 5, y + 5));
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Strikeout), new SolidBrush(dibujarcolor), new PointF(x, y));
                    }
                    else if (toolStripComboBox4.Text == "Italic")
                    {
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Italic), new SolidBrush(Color.Gray), new PointF(x + 5, y + 5));
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Italic), new SolidBrush(dibujarcolor), new PointF(x, y));
                    }
                }
                else if (toolStripComboBox1.Text == "SW")
                {
                    if (toolStripComboBox4.Text == "Regular")
                    {
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Regular), new SolidBrush(Color.Gray), new PointF(x - 5, y + 5));
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Regular), new SolidBrush(dibujarcolor), new PointF(x, y));
                    }
                    else if (toolStripComboBox4.Text == "Bold")
                    {
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Bold), new SolidBrush(Color.Gray), new PointF(x - 5, y + 5));
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Bold), new SolidBrush(dibujarcolor), new PointF(x, y));
                    }
                    else if (toolStripComboBox4.Text == "Underline")
                    {
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Underline), new SolidBrush(Color.Gray), new PointF(x - 5, y + 5));
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Underline), new SolidBrush(dibujarcolor), new PointF(x, y));
                    }
                    else if (toolStripComboBox4.Text == "Strikeout")
                    {
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Strikeout), new SolidBrush(Color.Gray), new PointF(x - 5, y + 5));
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Strikeout), new SolidBrush(dibujarcolor), new PointF(x, y));
                    }
                    else if (toolStripComboBox4.Text == "Italic")
                    {
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Italic), new SolidBrush(Color.Gray), new PointF(x - 5, y + 5));
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Italic), new SolidBrush(dibujarcolor), new PointF(x, y));
                    }
                }
                else if (toolStripComboBox1.Text == "NE")
                {
                    if (toolStripComboBox4.Text == "Regular")
                    {
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Regular), new SolidBrush(Color.Gray), new PointF(x + 5, y - 5));
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Regular), new SolidBrush(dibujarcolor), new PointF(x, y));
                    }
                    else if (toolStripComboBox4.Text == "Bold")
                    {
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Bold), new SolidBrush(Color.Gray), new PointF(x + 5, y - 5));
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Bold), new SolidBrush(dibujarcolor), new PointF(x, y));
                    }
                    else if (toolStripComboBox4.Text == "Underline")
                    {
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Underline), new SolidBrush(Color.Gray), new PointF(x + 5, y - 5));
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Underline), new SolidBrush(dibujarcolor), new PointF(x, y));
                    }
                    else if (toolStripComboBox4.Text == "Strikeout")
                    {
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Strikeout), new SolidBrush(Color.Gray), new PointF(x + 5, y - 5));
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Strikeout), new SolidBrush(dibujarcolor), new PointF(x, y));
                    }
                    else if (toolStripComboBox4.Text == "Italic")
                    {
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Italic), new SolidBrush(Color.Gray), new PointF(x + 5, y - 5));
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Italic), new SolidBrush(dibujarcolor), new PointF(x, y));
                    }
                }
                else if (toolStripComboBox1.Text == "NW")
                {
                    if (toolStripComboBox4.Text == "Regular")
                    {
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Regular), new SolidBrush(Color.Gray), new PointF(x - 5, y - 5));
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Regular), new SolidBrush(dibujarcolor), new PointF(x, y));
                    }
                    else if (toolStripComboBox4.Text == "Bold")
                    {
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Bold), new SolidBrush(Color.Gray), new PointF(x - 5, y - 5));
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Bold), new SolidBrush(dibujarcolor), new PointF(x, y));
                    }
                    else if (toolStripComboBox4.Text == "Underline")
                    {
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Underline), new SolidBrush(Color.Gray), new PointF(x - 5, y - 5));
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Underline), new SolidBrush(dibujarcolor), new PointF(x, y));
                    }
                    else if (toolStripComboBox4.Text == "Strikeout")
                    {
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Strikeout), new SolidBrush(Color.Gray), new PointF(x - 5, y - 5));
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Strikeout), new SolidBrush(dibujarcolor), new PointF(x, y));
                    }
                    else if (toolStripComboBox4.Text == "Italic")
                    {
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Italic), new SolidBrush(Color.Gray), new PointF(x - 5, y - 5));
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Italic), new SolidBrush(dibujarcolor), new PointF(x, y));
                    }
                }
                else if (toolStripComboBox1.Text == "S")
                {
                    if (toolStripComboBox4.Text == "Regular")
                    {
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Regular), new SolidBrush(Color.Gray), new PointF(x, y + 5));
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Regular), new SolidBrush(dibujarcolor), new PointF(x, y));
                    }
                    else if (toolStripComboBox4.Text == "Bold")
                    {
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Bold), new SolidBrush(Color.Gray), new PointF(x, y + 5));
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Bold), new SolidBrush(dibujarcolor), new PointF(x, y));
                    }
                    else if (toolStripComboBox4.Text == "Underline")
                    {
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Underline), new SolidBrush(Color.Gray), new PointF(x, y + 5));
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Underline), new SolidBrush(dibujarcolor), new PointF(x, y));
                    }
                    else if (toolStripComboBox4.Text == "Strikeout")
                    {
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Strikeout), new SolidBrush(Color.Gray), new PointF(x, y + 5));
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Strikeout), new SolidBrush(dibujarcolor), new PointF(x, y));
                    }
                    else if (toolStripComboBox4.Text == "Italic")
                    {
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Italic), new SolidBrush(Color.Gray), new PointF(x, y + 5));
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Italic), new SolidBrush(dibujarcolor), new PointF(x, y));
                    }
                }
                else if (toolStripComboBox1.Text == "N")
                {
                    if (toolStripComboBox4.Text == "Regular")
                    {
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Regular), new SolidBrush(Color.Gray), new PointF(x, y - 5));
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Regular), new SolidBrush(dibujarcolor), new PointF(x, y));
                    }
                    else if (toolStripComboBox4.Text == "Bold")
                    {
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Bold), new SolidBrush(Color.Gray), new PointF(x, y - 5));
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Bold), new SolidBrush(dibujarcolor), new PointF(x, y));
                    }
                    else if (toolStripComboBox4.Text == "Underline")
                    {
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Underline), new SolidBrush(Color.Gray), new PointF(x, y - 5));
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Underline), new SolidBrush(dibujarcolor), new PointF(x, y));
                    }
                    else if (toolStripComboBox4.Text == "Strikeout")
                    {
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Strikeout), new SolidBrush(Color.Gray), new PointF(x, y - 5));
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Strikeout), new SolidBrush(dibujarcolor), new PointF(x, y));
                    }
                    else if (toolStripComboBox4.Text == "Italic")
                    {
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Italic), new SolidBrush(Color.Gray), new PointF(x, y - 5));
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Italic), new SolidBrush(dibujarcolor), new PointF(x, y));
                    }
                }
                else if (toolStripComboBox1.Text == "W")
                {
                    if (toolStripComboBox4.Text == "Regular")
                    {
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Regular), new SolidBrush(Color.Gray), new PointF(x - 5, y));
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Regular), new SolidBrush(dibujarcolor), new PointF(x, y));
                    }
                    else if (toolStripComboBox4.Text == "Bold")
                    {
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Bold), new SolidBrush(Color.Gray), new PointF(x - 5, y));
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Bold), new SolidBrush(dibujarcolor), new PointF(x, y));
                    }
                    else if (toolStripComboBox4.Text == "Underline")
                    {
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Underline), new SolidBrush(Color.Gray), new PointF(x - 5, y));
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Underline), new SolidBrush(dibujarcolor), new PointF(x, y));
                    }
                    else if (toolStripComboBox4.Text == "Strikeout")
                    {
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Strikeout), new SolidBrush(Color.Gray), new PointF(x - 5, y));
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Strikeout), new SolidBrush(dibujarcolor), new PointF(x, y));
                    }
                    else if (toolStripComboBox4.Text == "Italic")
                    {
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Italic), new SolidBrush(Color.Gray), new PointF(x - 5, y));
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Italic), new SolidBrush(dibujarcolor), new PointF(x, y));
                    }
                }
                else if (toolStripComboBox1.Text == "E")
                {
                    if (toolStripComboBox4.Text == "Regular")
                    {
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Regular), new SolidBrush(Color.Gray), new PointF(x + 5, y));
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Regular), new SolidBrush(dibujarcolor), new PointF(x, y));
                    }
                    else if (toolStripComboBox4.Text == "Bold")
                    {
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Bold), new SolidBrush(Color.Gray), new PointF(x + 5, y));
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Bold), new SolidBrush(dibujarcolor), new PointF(x, y));
                    }
                    else if (toolStripComboBox4.Text == "Underline")
                    {
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Underline), new SolidBrush(Color.Gray), new PointF(x + 5, y));
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Underline), new SolidBrush(dibujarcolor), new PointF(x, y));
                    }
                    else if (toolStripComboBox4.Text == "Strikeout")
                    {
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Strikeout), new SolidBrush(Color.Gray), new PointF(x + 5, y));
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Strikeout), new SolidBrush(dibujarcolor), new PointF(x, y));
                    }
                    else if (toolStripComboBox4.Text == "Italic")
                    {
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Italic), new SolidBrush(Color.Gray), new PointF(x + 5, y));
                        g.DrawString(toolStripTextBox2.Text, new Font(toolStripComboBox2.Text, Convert.ToInt32(toolStripComboBox3.Text), FontStyle.Italic), new SolidBrush(dibujarcolor), new PointF(x, y));
                    }
                }
                g.Dispose();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            currItem = Item.Text;
        }

        private void Pantalla_DragDrop(object sender, DragEventArgs e)
        {
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            Pantalla.Image = Image.FromFile(FileList[0]);
            img = Pantalla.Image;
        }

        private void Pantalla_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Pantalla_MouseClick(object sender, MouseEventArgs e)
        {
            if (currItem == Item.Text)
            {
                x = e.X;
                y = e.Y;
                currItem = Item.None;
                
            }
        }
    }
    
}
