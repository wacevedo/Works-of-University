using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Drawing.Text;





namespace EditorDeTexto
{
    public partial class Form1 : Form
    {
        string Archivo;
        string fuenten;
        float TamanoFuente=10;
        int md=30, mi=30, mc=0;

        public Form1()
        {
            InitializeComponent();
        }

        public HorizontalAlignment TextAlign { get; set; }


        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog AbrirNew = new OpenFileDialog();
            AbrirNew.Filter = "Texto |*.txt";
            if (AbrirNew.ShowDialog() == DialogResult.OK)
            {
                Archivo = AbrirNew.FileName;

                using (StreamReader sr = new StreamReader(Archivo))
                {
                    richTexto.Text = sr.ReadToEnd();
                }
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog Guardar = new SaveFileDialog();
            System.IO.StreamWriter mystream=null;
            Guardar.Filter = "Texto |*.txt";
            Guardar.CheckPathExists = true;
            Guardar.Title = "Guardar Como";
            Guardar.ShowDialog();
            try
            {
                mystream = System.IO.File.AppendText(Guardar.FileName);
                mystream.Write(richTexto.Text);
                mystream.Flush();
            }
            catch (Exception) { }

           /* if (Archivo != null)
            {
                using (StreamWriter sw = new StreamWriter(Archivo))
                {
                    sw.Write(richTexto.Text);
                }
            }
            else
            {
                if (Guardar.ShowDialog() == DialogResult.OK)
                {
                    Archivo = Guardar.FileName;
                    using (StreamWriter sw = new StreamWriter(Guardar.FileName))
                    {
                        sw.Write(richTexto.Text);
                    }
                }
            }*/
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
          richTexto.Clear();
          Archivo = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void BCortar_Click(object sender, EventArgs e)
        {
            richTexto.Cut();
        }

        private void BCopiar_Click(object sender, EventArgs e)
        {
            richTexto.Copy();
        }

        private void BPegar_Click(object sender, EventArgs e)
        {
            richTexto.Paste();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Font f = richTexto.Font;
            TamanoFuente = 8.0f;
            richTexto.Font = new Font(f.SystemFontName, TamanoFuente, f.Style);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Font f = richTexto.Font;
            TamanoFuente = 10.0f;
            richTexto.Font = new Font(f.SystemFontName, TamanoFuente, f.Style);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTexto.SelectionIndent = mi;
            richTexto.SelectionHangingIndent = mc;
            richTexto.SelectionRightIndent = md;
            FontFamily[] family = FontFamily.Families;
            foreach (FontFamily fuente in family)
            {
                ComboFuentes.Items.Add(fuente.GetName(1).ToString());    
            }
            ComboFuentes.SelectedIndex = 222;
            fuenten = Convert.ToString(ComboFuentes.SelectedIndex);
        }

        private void ComboFuentes_Click(object sender, EventArgs e)
        {
            //richTexto.SelectAll();
            fuenten = Convert.ToString(ComboFuentes.SelectedItem);
            richTexto.SelectionFont = new System.Drawing.Font(fuenten, TamanoFuente);
            richTexto.SelectionStart = richTexto.Text.Length;
            

        }

        private void ComboFuentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Cambiamos la font por la seleccionada en el Listbox
                richTexto.Font = new Font("" + ComboFuentes.Items[this.ComboFuentes.SelectedIndex].ToString() + "", 12); // se asigna el tipo de letra y el tamaño
            }
            catch
            {
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Font f = richTexto.Font;
            TamanoFuente = 12.0f;
            richTexto.Font = new Font(f.SystemFontName, TamanoFuente, f.Style);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Font f = richTexto.Font;
            TamanoFuente = 14.0f;
            richTexto.Font = new Font(f.SystemFontName, TamanoFuente, f.Style);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Font f = richTexto.Font;
            TamanoFuente = 16.0f;
            richTexto.Font = new Font(f.SystemFontName, TamanoFuente, f.Style);
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Font f = richTexto.Font;
            TamanoFuente = 18.0f;
            richTexto.Font = new Font(f.SystemFontName, TamanoFuente, f.Style);
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Font f = richTexto.Font;
            TamanoFuente = 24.0f;
            richTexto.Font = new Font(f.SystemFontName, TamanoFuente, f.Style);
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Font f = richTexto.Font;
            TamanoFuente = 28.0f;
            richTexto.Font = new Font(f.SystemFontName, TamanoFuente, f.Style);
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Font f = richTexto.Font;
            TamanoFuente = 32.0f;
            richTexto.Font = new Font(f.SystemFontName, TamanoFuente, f.Style);
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Font f = richTexto.Font;
            TamanoFuente = 48.0f;
            richTexto.Font = new Font(f.SystemFontName, TamanoFuente, f.Style);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (richTexto.SelectionFont != null)
            {
                System.Drawing.Font FuenteActual = richTexto.SelectionFont;
                System.Drawing.FontStyle NuevoEstFuente;
                if (richTexto.SelectionFont.Bold == true)
                {
                    NuevoEstFuente = FontStyle.Regular;
                }
                else
                {
                    NuevoEstFuente = FontStyle.Bold;
                }
                richTexto.SelectionFont = new Font(
                    FuenteActual.FontFamily, FuenteActual.Size, NuevoEstFuente);
                richTexto.SelectionStart = richTexto.Text.Length;
                richTexto.Focus();

            }


                
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (richTexto.SelectionFont != null)
            {
                System.Drawing.Font FuenteActual = richTexto.SelectionFont;
                System.Drawing.FontStyle NuevoEstFuente;
                if (richTexto.SelectionFont.Italic == true)
                {
                    NuevoEstFuente = FontStyle.Regular;
                }
                else
                {
                    NuevoEstFuente = FontStyle.Italic;
                }
                richTexto.SelectionFont = new Font(
                    FuenteActual.FontFamily, FuenteActual.Size, NuevoEstFuente);
                richTexto.SelectionStart = richTexto.Text.Length;
                richTexto.Focus();

            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (richTexto.SelectionFont != null)
            {
                System.Drawing.Font FuenteActual = richTexto.SelectionFont;
                System.Drawing.FontStyle NuevoEstFuente;
                if (richTexto.SelectionFont.Underline == true)
                {
                    NuevoEstFuente = FontStyle.Regular;
                }
                else
                {
                    NuevoEstFuente = FontStyle.Underline;
                }
                richTexto.SelectionFont = new Font(
                    FuenteActual.FontFamily, FuenteActual.Size, NuevoEstFuente);
                richTexto.SelectionStart = richTexto.Text.Length;
                richTexto.Focus();

            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (richTexto.SelectionFont != null)
            {
                System.Drawing.Font FuenteActual = richTexto.SelectionFont;
                System.Drawing.FontStyle NuevoEstFuente;
                if (richTexto.SelectionFont.Strikeout == true)
                {
                    NuevoEstFuente = FontStyle.Regular;
                }
                else
                {
                    NuevoEstFuente = FontStyle.Strikeout;
                }
                richTexto.SelectionFont = new Font(
                    FuenteActual.FontFamily, FuenteActual.Size, NuevoEstFuente);
                richTexto.SelectionStart = richTexto.Text.Length;
                richTexto.Focus();

            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            //richTexto.SelectAll();
            richTexto.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            //richTexto.SelectAll();
            //richTexto.SelectionStart = richTexto.Text.Length;            
            richTexto.SelectionAlignment = HorizontalAlignment.Center;
                      

        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            //richTexto.SelectAll();
            richTexto.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void ElegirColores_Click(object sender, EventArgs e)
        {
            ColorDialog ColorD = new ColorDialog();
            //Obtiene o establece la posibilidad de utilizar colores personalizados.
            ColorD.AllowFullOpen = false;
            ColorD.ShowHelp = true;
            //Obtiene o establece el color utilizado por el usuario.
            ColorD.Color = richTexto.ForeColor;
            //Si se eligió un color y se presionó OK
            if ((ColorD.ShowDialog() == System.Windows.Forms.DialogResult.OK))
            {
                //asignamos el color
                richTexto.ForeColor = ColorD.Color;
                richTexto.SelectionStart = richTexto.Text.Length;
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            ColorDialog ColorFondo = new ColorDialog();
            ColorFondo.AllowFullOpen = false;
            ColorFondo.ShowHelp = true;
            
            ColorFondo.Color = richTexto.BackColor;
             if ((ColorFondo.ShowDialog() == System.Windows.Forms.DialogResult.OK))
            {
                richTexto.BackColor = ColorFondo.Color;
                
            }

        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            richTexto.SelectAll();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            md = Convert.ToInt32(numericUpDown1.Value);
            mi = Convert.ToInt32(numericUpDown1.Value);
            richTexto.SelectionIndent = mi;
            richTexto.SelectionRightIndent = md;
        }

       
                
        
    }
}
