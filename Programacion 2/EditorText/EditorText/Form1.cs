using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.XPath;

namespace EditorText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Sizefuente=14;
        private string fuenteselect;
        int PI = 60, PHI = 0, PRI = 60;// Margentes
        
        private void buttoncopiar_Click(object sender, EventArgs e)
        {
            Pantalla.Copy();           
        }

        private void buttonPegar_Click(object sender, EventArgs e)
        {
            Pantalla.Paste();
            Pantalla.SelectionStart = Pantalla.Text.Length;
            Pantalla.Focus();            
        }

        private void buttonCortar_Click(object sender, EventArgs e)
        {
            Pantalla.Cut();
            Pantalla.SelectionStart = Pantalla.Text.Length;
            Pantalla.Focus();
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            Pantalla.Undo();
        }

        private void buttonAdelante_Click(object sender, EventArgs e)
        {
            Pantalla.Redo();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pantalla.Clear();
            label1.Text = "No guardado";
            Pantalla.SelectionStart = Pantalla.Text.Length;
            Pantalla.Focus();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            System.IO.StreamReader myStreamReader = null;
            open.Filter = "RichText[*.rtf*]|*.rtf|text[*.txt*]|*.txt|HTML(*.html*)|*.html|All files[*,*]|*,*";

            open.CheckFileExists = true;
            open.ShowDialog(this);
            try
            {
                open.OpenFile();
                myStreamReader = System.IO.File.OpenText(open.FileName);
                if (Path.GetExtension(open.FileName).ToUpperInvariant() == ".RTF")               
                Pantalla.LoadFile(open.FileName);                
                else
                Pantalla.Text = myStreamReader.ReadToEnd();
                label1.Text = open.FileName;
                
            }
            catch (Exception ex) { MessageBox.Show("Error:" + ex.Message); }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog Save = new SaveFileDialog();
            System.IO.StreamWriter myStreamWriter = null;
            Save.Filter = "RichText[*.rtf*]|*.rtf|text[*.txt*]|*.txt|HTML(*.html*)|*.html|All files[*,*]|*,*";
            Save.CheckPathExists = true;
            Save.Title = "Guardar como";
            Save.ShowDialog();
            try
            {
                myStreamWriter = System.IO.File.AppendText(Save.FileName);
                if (Path.GetExtension(Save.FileName).ToUpperInvariant() == ".RTF")
                myStreamWriter.Write(Pantalla.Rtf);
                else
                myStreamWriter.Write(Pantalla.Text);
                myStreamWriter.Flush();
                label1.Text = Save.FileName;

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error:" + ex.Message);
            }

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCursiva_Click(object sender, EventArgs e)
        {
            if (Pantalla.SelectionFont != null)
            {
                System.Drawing.Font currentFont = Pantalla.SelectionFont;
                System.Drawing.FontStyle newFontStyle;
                if (Pantalla.SelectionFont.Italic == true)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else
                {
                    newFontStyle = FontStyle.Italic;                
                }
                Pantalla.SelectionFont = new Font(
                    currentFont.FontFamily,
                    currentFont.Size, newFontStyle
                    );
                Pantalla.SelectionStart = Pantalla.Text.Length;
                Pantalla.Focus();
            }
        }

        private void buttonNegrita_Click(object sender, EventArgs e)
        {
            if (Pantalla.SelectionFont != null)
            {
                System.Drawing.Font currentFont = Pantalla.SelectionFont;
                System.Drawing.FontStyle newFontStyle;
                if (Pantalla.SelectionFont.Bold == true)
                {
                    newFontStyle = FontStyle.Regular;
                    
                }
                else
                {
                    newFontStyle = FontStyle.Bold;
                }
                Pantalla.SelectionFont = new Font(
                    currentFont.FontFamily,
                    currentFont.Size, newFontStyle
                    );
                Pantalla.SelectionStart = Pantalla.Text.Length;
                Pantalla.Focus();
            }
        }

        private void buttonTachado_Click(object sender, EventArgs e)
        {
            if (Pantalla.SelectionFont != null)
            {
                System.Drawing.Font currentFont = Pantalla.SelectionFont;
                System.Drawing.FontStyle newFontStyle;
                if (Pantalla.SelectionFont.Strikeout == true)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else
                {
                    newFontStyle = FontStyle.Strikeout;
                }
                Pantalla.SelectionFont = new Font(
                    currentFont.FontFamily,
                    currentFont.Size, newFontStyle
                    );
                Pantalla.SelectionStart = Pantalla.Text.Length;
                Pantalla.Focus();
            }
        }

        private void buttonSubrrayado_Click(object sender, EventArgs e)
        {
            if (Pantalla.SelectionFont != null)
            {
                System.Drawing.Font currentFont = Pantalla.SelectionFont;
                System.Drawing.FontStyle newFontStyle;
                if (Pantalla.SelectionFont.Underline == true)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else
                {
                    newFontStyle = FontStyle.Underline;
                }
                Pantalla.SelectionFont = new Font(
                    currentFont.FontFamily,
                    currentFont.Size, newFontStyle
                    );
                Pantalla.SelectionStart = Pantalla.Text.Length;
                Pantalla.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pantalla.SelectionColor = Color.Red;
            CurrentTextColor.ForeColor = Color.Red;
            Pantalla.SelectionStart = Pantalla.Text.Length;
            //Pantalla.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pantalla.SelectionColor = Color.Black;
            CurrentTextColor.ForeColor = Color.Black;
            Pantalla.SelectionStart = Pantalla.Text.Length;
            //Pantalla.Focus();
        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            Pantalla.SelectionColor = Color.Green;
            CurrentTextColor.ForeColor = Color.Green;
            Pantalla.SelectionStart = Pantalla.Text.Length;
            //Pantalla.Focus();
        }

        private void buttonYellow_Click(object sender, EventArgs e)
        {
            Pantalla.SelectionColor = Color.Yellow;
            CurrentTextColor.ForeColor = Color.Yellow;
            Pantalla.SelectionStart = Pantalla.Text.Length;
            //Pantalla.Focus();
        }

        private void buttonBlue_Click(object sender, EventArgs e)
        {
            Pantalla.SelectionColor = Color.Blue;
            CurrentTextColor.ForeColor = Color.Blue;
            Pantalla.SelectionStart = Pantalla.Text.Length;
            //Pantalla.Focus();
        }

        private void buttonFirebrick_Click(object sender, EventArgs e)
        {
            Pantalla.SelectionColor = Color.Firebrick;
            CurrentTextColor.ForeColor = Color.Firebrick;
            Pantalla.SelectionStart = Pantalla.Text.Length;
            //Pantalla.Focus();
        }

        private void buttonGold_Click(object sender, EventArgs e)
        {
            Pantalla.SelectionColor = Color.Gold;            
            CurrentTextColor.ForeColor = Color.Gold;
            Pantalla.SelectionStart = Pantalla.Text.Length;
            //Pantalla.Focus();
        }

        private void buttonDeepSkyblue_Click(object sender, EventArgs e)
        {
            Pantalla.SelectionColor = Color.DeepSkyBlue;
            CurrentTextColor.ForeColor = Color.DeepSkyBlue;
            Pantalla.SelectionStart = Pantalla.Text.Length;
            //Pantalla.Focus();
        }

        private void buttonLime_Click(object sender, EventArgs e)
        {
            Pantalla.SelectionColor = Color.Lime;
            CurrentTextColor.ForeColor = Color.Lime;
            Pantalla.SelectionStart = Pantalla.Text.Length;
           // Pantalla.Focus();
        }

        private void buttonOrange_Click(object sender, EventArgs e)
        {
            Pantalla.SelectionColor = Color.Orange;
            CurrentTextColor.ForeColor = Color.Orange;
            Pantalla.SelectionStart = Pantalla.Text.Length;
            //Pantalla.Focus();
        }

        private void buttonKhaki_Click(object sender, EventArgs e)
        {
            Pantalla.SelectionColor = Color.Khaki;
            CurrentTextColor.ForeColor = Color.Khaki;
            Pantalla.SelectionStart = Pantalla.Text.Length;
            //Pantalla.Focus();
        }

        private void buttonPink_Click(object sender, EventArgs e)
        {
            Pantalla.SelectionColor = Color.Pink;
            CurrentTextColor.ForeColor = Color.Pink;
            Pantalla.SelectionStart = Pantalla.Text.Length;
            //Pantalla.Focus();
        }

        private void buttonPurple_Click(object sender, EventArgs e)
        {
            Pantalla.SelectionColor = Color.Purple;
            CurrentTextColor.ForeColor = Color.Purple;
            Pantalla.SelectionStart = Pantalla.Text.Length;
            //Pantalla.Focus();  
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Pantalla.SelectAll();            
            int valor = Convert.ToInt32(numericUpDown1.Value);
            Sizefuente = valor;
            Pantalla.SelectionFont = new System.Drawing.Font(fuenteselect, Sizefuente);
            Pantalla.SelectionStart = Pantalla.Text.Length;
            Pantalla.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Pantalla.SelectionIndent = PI;
            Pantalla.SelectionHangingIndent = PHI;
            Pantalla.SelectionRightIndent = PRI;
            foreach (FontFamily fuente in System.Drawing.FontFamily.Families)
            {
                if ((fuente.Name != "Aharoni") && (fuente.Name != "Berlin Sans FB Demi") && (fuente.Name != "Brush Script MT")
                    && (fuente.Name != "Harlow Solid Italic") && (fuente.Name != "Magneto") && (fuente.Name != "Palace Script MT")
                    && (fuente.Name != "Vivaldi") && (fuente.Name != "Monotype Corsiva"))
                {
                    comboBox1.Items.Add(fuente.Name);
                }
               
            }
            
           comboBox1.SelectedIndex = 222;
           fuenteselect = Convert.ToString(comboBox1.SelectedIndex);           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pantalla.SelectAll();
            fuenteselect = Convert.ToString(comboBox1.SelectedItem);            
            Pantalla.SelectionFont = new System.Drawing.Font(fuenteselect, Sizefuente);
            Pantalla.SelectionStart = Pantalla.Text.Length;
            Pantalla.Focus();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Pantalla.SelectAll();
            Pantalla.SelectionAlignment = HorizontalAlignment.Center;
            Pantalla.SelectionStart = Pantalla.Text.Length;
            Pantalla.Focus();
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            //Pantalla.SelectAll();
            Pantalla.SelectionAlignment = HorizontalAlignment.Right;
            Pantalla.SelectionStart = Pantalla.Text.Length;
            Pantalla.Focus();
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            //Pantalla.SelectAll();
            Pantalla.SelectionAlignment = HorizontalAlignment.Left;
            Pantalla.SelectionStart = Pantalla.Text.Length;
            Pantalla.Focus();
        }

        private void buttonSubStringgreen_Click(object sender, EventArgs e)
        {
            Pantalla.SelectionBackColor = Color.SpringGreen;
            CurrentResaltado.BackColor = Color.SpringGreen;            
        }

        private void buttonSubYellow_Click(object sender, EventArgs e)
        {
            Pantalla.SelectionBackColor = Color.Yellow;
            CurrentResaltado.BackColor = Color.Yellow;            
        }

        private void buttonSubMagenta_Click(object sender, EventArgs e)
        {
            Pantalla.SelectionBackColor = Color.Magenta;
            CurrentResaltado.BackColor = Color.Magenta;             
        }

        private void CurrentResaltado_Click(object sender, EventArgs e)
        {
            Pantalla.SelectionBackColor = Color.White;
            CurrentResaltado.BackColor = Color.White; 
        }

        private void buttonSelectAll_Click(object sender, EventArgs e)
        {
            Pantalla.SelectAll();
        }

        private void buttongray_Click(object sender, EventArgs e)
        {
            Pantalla.SelectionColor = Color.Gray;
            CurrentTextColor.ForeColor = Color.Gray;
            Pantalla.SelectionStart = Pantalla.Text.Length;
            //Pantalla.Focus(); 
        }

        private void buttonSienna_Click(object sender, EventArgs e)
        {
            Pantalla.SelectionColor = Color.Sienna;
            CurrentTextColor.ForeColor = Color.Sienna;
            Pantalla.SelectionStart = Pantalla.Text.Length;
            //Pantalla.Focus(); 
        }

        private void buttonbullet_Click(object sender, EventArgs e)
        {
                        
                if (Pantalla.SelectionBullet == true)
                {
                    Pantalla.SelectionBullet = false;
                }
                else
                {
                    Pantalla.SelectionBullet = true;
                }
                
                Pantalla.SelectionStart = Pantalla.Text.Length;
                Pantalla.Focus();
            
        }

        private void buttonBackWhite_Click(object sender, EventArgs e)
        {
            Pantalla.BackColor = Color.White;
            CurrentBackColor.BackColor = Color.White;
            Pantalla.Focus();
        }

        private void buttonBackNavajoW_Click(object sender, EventArgs e)
        {
            Pantalla.BackColor = Color.NavajoWhite;
            CurrentBackColor.BackColor = Color.NavajoWhite;
            Pantalla.Focus();
        }

        private void buttonBackPaleGoldenrod_Click(object sender, EventArgs e)
        {
            Pantalla.BackColor = Color.PaleGoldenrod;
            CurrentBackColor.BackColor = Color.PaleGoldenrod;
            Pantalla.Focus();
        }

        private void buttonBackLightPink_Click(object sender, EventArgs e)
        {
            Pantalla.BackColor = Color.LightPink;
            CurrentBackColor.BackColor = Color.LightPink;
            Pantalla.Focus();
        }

        private void buttonBackLightSteelBlue_Click(object sender, EventArgs e)
        {
            Pantalla.BackColor = Color.LightSteelBlue;
            CurrentBackColor.BackColor = Color.LightSteelBlue;
            Pantalla.Focus();
        }

        private void buttonBackLightGray_Click(object sender, EventArgs e)
        {
            Pantalla.BackColor = Color.LightGray;
            CurrentBackColor.BackColor = Color.LightGray;
            Pantalla.Focus();
        }

        private void buttonBackThistle_Click(object sender, EventArgs e)
        {
            Pantalla.BackColor = Color.Thistle;
            CurrentBackColor.BackColor = Color.Thistle;
            Pantalla.Focus();
        }

        private void buttonBackIndianRed_Click(object sender, EventArgs e)
        {
            Pantalla.BackColor = Color.IndianRed;
            CurrentBackColor.BackColor = Color.IndianRed;
            Pantalla.Focus();
        }

        private void buttonBackYellowGreen_Click(object sender, EventArgs e)
        {
            Pantalla.BackColor = Color.YellowGreen;
            CurrentBackColor.BackColor = Color.YellowGreen;
            Pantalla.Focus();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            PI = Convert.ToInt32(numericUpDown4.Value);
            Pantalla.SelectionIndent = PI;
            Pantalla.SelectionHangingIndent = PHI;
            Pantalla.SelectionRightIndent = PRI;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            PHI = Convert.ToInt32(numericUpDown3.Value);
            Pantalla.SelectionIndent = PI;
            Pantalla.SelectionHangingIndent = PHI;
            Pantalla.SelectionRightIndent = PRI;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            PRI = Convert.ToInt32(numericUpDown2.Value);
            Pantalla.SelectionIndent = PI;
            Pantalla.SelectionHangingIndent = PHI;
            Pantalla.SelectionRightIndent = PRI;
        }

        private void CurrentTextColor_Click(object sender, EventArgs e)
        {
            //ColorDialog Coldiag = new ColorDialog();
           // Coldiag.ShowDialog();
            //if (Coldiag.HelpRequest==true)
        }

        private void CurrentBackColor_Click(object sender, EventArgs e)
        {
            /*ColorDialog Coldiag = new ColorDialog();
            Coldiag.ShowDialog();*/
            Pantalla.SelectionBackColor = Color.White;
            CurrentResaltado.BackColor = Color.White;
            Pantalla.SelectionStart = Pantalla.Text.Length;
            Pantalla.Focus();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Pantalla.SelectionBackColor = button7.BackColor;
            CurrentResaltado.BackColor = button7.BackColor;           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ColorDialog Coldiag = new ColorDialog();
            Coldiag.ShowDialog();
            button7.BackColor = Coldiag.Color;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ColorDialog Coldiag = new ColorDialog();
            Coldiag.ShowDialog();
            button6.BackColor = Coldiag.Color;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ColorDialog Coldiag = new ColorDialog();
            Coldiag.ShowDialog();
            button3.BackColor = Coldiag.Color;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pantalla.SelectionColor = button3.BackColor;
            CurrentTextColor.ForeColor = button3.BackColor;
            Pantalla.SelectionStart = Pantalla.Text.Length;
            Pantalla.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Pantalla.BackColor = button6.BackColor;
            CurrentBackColor.BackColor = button6.BackColor;
            Pantalla.Focus();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "No guardado")
            {
                SaveFileDialog Save = new SaveFileDialog();
                System.IO.StreamWriter myStreamWriter = null;
                Save.Filter = "RichText[*.rtf*]|*.rtf|text[*.txt*]|*.txt|HTML(*.html*)|*.html|All files[*,*]|*,*";
                Save.CheckPathExists = true;
                Save.Title = "Guardar como";
                Save.ShowDialog();
                try
                {
                    myStreamWriter = System.IO.File.AppendText(Save.FileName);
                    if (Path.GetExtension(Save.FileName).ToUpperInvariant() == ".RTF")
                        myStreamWriter.Write(Pantalla.Rtf);
                    else
                        myStreamWriter.Write(Pantalla.Text);
                    myStreamWriter.Flush();
                    label1.Text = Save.FileName;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }

            }
            else
            {
                System.IO.StreamWriter myStreamWriter = null;
                try
                {
                    myStreamWriter = System.IO.File.AppendText(label1.Text);
                    if (Path.GetExtension(label1.Text).ToUpperInvariant() == ".RTF")
                        myStreamWriter.Write(Pantalla.Rtf);
                    else
                        myStreamWriter.Write(Pantalla.Text);
                    myStreamWriter.Flush();
                    label1.Text = label1.Text;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
            }
        }

          
                
    }
}
