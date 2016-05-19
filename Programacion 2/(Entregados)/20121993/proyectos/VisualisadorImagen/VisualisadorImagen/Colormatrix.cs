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


namespace VisualisadorImagen
{
    public partial class Colormatrix : Form
    {
        public Colormatrix()
        {
            InitializeComponent();
        }
        public Image PantallaCopia, Img, PantallaCopiaImg;
        private void Colormatrix_Load(object sender, EventArgs e)
        {
           
        }
       

        

        public void buttonAplicar_Click(object sender, EventArgs e)
        {
            float r1 = Convert.ToSingle(R1.Value);
            float r2 = Convert.ToSingle(R2.Value);
            float r3 = Convert.ToSingle(R3.Value);
            float r4 = Convert.ToSingle(R4.Value);
            float r5 = Convert.ToSingle(R5.Value);
            float g1 = Convert.ToSingle(G1.Value);
            float g2 = Convert.ToSingle(G2.Value);
            float g3 = Convert.ToSingle(G3.Value);
            float g4 = Convert.ToSingle(G4.Value);
            float g5 = Convert.ToSingle(G5.Value);
            float b1 = Convert.ToSingle(B1.Value);
            float b2 = Convert.ToSingle(B2.Value);
            float b3 = Convert.ToSingle(B3.Value);
            float b4 = Convert.ToSingle(B4.Value);
            float b5 = Convert.ToSingle(B5.Value);
            float a1 = Convert.ToSingle(A1.Value);
            float a2 = Convert.ToSingle(A2.Value);
            float a3 = Convert.ToSingle(A3.Value);
            float a4 = Convert.ToSingle(A4.Value);
            float a5 = Convert.ToSingle(A5.Value);
            float w1 = Convert.ToSingle(W1.Value);
            float w2 = Convert.ToSingle(W2.Value);
            float w3 = Convert.ToSingle(W3.Value);
            float w4 = Convert.ToSingle(W4.Value);
            float w5 = Convert.ToSingle(W5.Value);



            float[][] colorMatrixElements = {
	        new float[] {r1,r2,r3,r4,r5},            
            new float[] {g1,g2,g3,g4,g5},
            new float[] {b1,b2,b3,b4,b5},
            new float[] {a1,a2,a3,a4,a5},
            new float[] {w1,w2,w3,w4,w5}
                                            };

            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            Image _img = PantallaCopiaImg; //Se iguala una copia de lo que tiene  la pantalla picturebox

            Graphics _g = default(Graphics);
            Bitmap bm_dest = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
            _g = Graphics.FromImage(bm_dest);
            _g.DrawImage(_img, new Rectangle(0, 0, bm_dest.Width + 1, bm_dest.Height + 1), 0, 0, bm_dest.Width + 1, bm_dest.Height + 1, GraphicsUnit.Pixel, imageAttributes);
            PantallaCopia = bm_dest;
            MessageBox.Show("Filtro Generado, Ya puede Aplicar el Filtro generado", "Notificacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Hide();
        }

        private void R1_ValueChanged(object sender, EventArgs e)
        {
            float r1 = Convert.ToSingle(R1.Value);
            float r2 = Convert.ToSingle(R2.Value);
            float r3 = Convert.ToSingle(R3.Value);
            float r4 = Convert.ToSingle(R4.Value);
            float r5 = Convert.ToSingle(R5.Value);
            float g1 = Convert.ToSingle(G1.Value);
            float g2 = Convert.ToSingle(G2.Value);
            float g3 = Convert.ToSingle(G3.Value);
            float g4 = Convert.ToSingle(G4.Value);
            float g5 = Convert.ToSingle(G5.Value);
            float b1 = Convert.ToSingle(B1.Value);
            float b2 = Convert.ToSingle(B2.Value);
            float b3 = Convert.ToSingle(B3.Value);
            float b4 = Convert.ToSingle(B4.Value);
            float b5 = Convert.ToSingle(B5.Value);
            float a1 = Convert.ToSingle(A1.Value);
            float a2 = Convert.ToSingle(A2.Value);
            float a3 = Convert.ToSingle(A3.Value);
            float a4 = Convert.ToSingle(A4.Value);
            float a5 = Convert.ToSingle(A5.Value);
            float w1 = Convert.ToSingle(W1.Value);
            float w2 = Convert.ToSingle(W2.Value);
            float w3 = Convert.ToSingle(W3.Value);
            float w4 = Convert.ToSingle(W4.Value);
            float w5 = Convert.ToSingle(W5.Value);



            float[][] colorMatrixElements = {
	        new float[] {r1,r2,r3,r4,r5},            
            new float[] {g1,g2,g3,g4,g5},
            new float[] {b1,b2,b3,b4,b5},
            new float[] {a1,a2,a3,a4,a5},
            new float[] {w1,w2,w3,w4,w5}
            
                                            };

            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            Image _img = Img; //Se iguala una copia de lo que tiene  la pantalla picturebox

            Graphics _g = default(Graphics);
            Bitmap bm_dest = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
            _g = Graphics.FromImage(bm_dest);
            _g.DrawImage(_img, new Rectangle(0, 0, bm_dest.Width + 1, bm_dest.Height + 1), 0, 0, bm_dest.Width + 1, bm_dest.Height + 1, GraphicsUnit.Pixel, imageAttributes);
            PantallaPrueba.Image = bm_dest;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            R1.Value=1;
            R2.Value=0;
            R3.Value=0;
            R4.Value=0;
            R5.Value=0;
            G1.Value=0;
            G2.Value=1;
            G3.Value=0;
            G4.Value=0;
            G5.Value=0;
            B1.Value=0;
            B2.Value=0;
            B3.Value=1;
            B4.Value=0;
            B5.Value=0;
            A1.Value=0;
            A2.Value=0;
            A3.Value=0;
            A4.Value=1;
            A5.Value=0;
            W1.Value=0;
            W2.Value=0;
            W3.Value=0;
            W4.Value=0;
            W5.Value=1;

            float r1 = Convert.ToSingle(R1.Value);
            float r2 = Convert.ToSingle(R2.Value);
            float r3 = Convert.ToSingle(R3.Value);
            float r4 = Convert.ToSingle(R4.Value);
            float r5 = Convert.ToSingle(R5.Value);
            float g1 = Convert.ToSingle(G1.Value);
            float g2 = Convert.ToSingle(G2.Value);
            float g3 = Convert.ToSingle(G3.Value);
            float g4 = Convert.ToSingle(G4.Value);
            float g5 = Convert.ToSingle(G5.Value);
            float b1 = Convert.ToSingle(B1.Value);
            float b2 = Convert.ToSingle(B2.Value);
            float b3 = Convert.ToSingle(B3.Value);
            float b4 = Convert.ToSingle(B4.Value);
            float b5 = Convert.ToSingle(B5.Value);
            float a1 = Convert.ToSingle(A1.Value);
            float a2 = Convert.ToSingle(A2.Value);
            float a3 = Convert.ToSingle(A3.Value);
            float a4 = Convert.ToSingle(A4.Value);
            float a5 = Convert.ToSingle(A5.Value);
            float w1 = Convert.ToSingle(W1.Value);
            float w2 = Convert.ToSingle(W2.Value);
            float w3 = Convert.ToSingle(W3.Value);
            float w4 = Convert.ToSingle(W4.Value);
            float w5 = Convert.ToSingle(W5.Value);



            float[][] colorMatrixElements = {
	        new float[] {r1,r2,r3,r4,r5},            
            new float[] {g1,g2,g3,g4,g5},
            new float[] {b1,b2,b3,b4,b5},
            new float[] {a1,a2,a3,a4,a5},
            new float[] {w1,w2,w3,w4,w5}
            
                                            };

            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            Image _img = Img; //Se iguala una copia de lo que tiene  la pantalla picturebox

            Graphics _g = default(Graphics);
            Bitmap bm_dest = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
            _g = Graphics.FromImage(bm_dest);
            _g.DrawImage(_img, new Rectangle(0, 0, bm_dest.Width + 1, bm_dest.Height + 1), 0, 0, bm_dest.Width + 1, bm_dest.Height + 1, GraphicsUnit.Pixel, imageAttributes);
            PantallaPrueba.Image = bm_dest;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
