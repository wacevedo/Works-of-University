using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace Editor_de_Texto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string fuenteselect;
        private int Sizefuente = 9;
        int PI = 60, PHI = 0, PRI = 60;// Margenes

         //contador de palabras
      /*  public static int WordCount (this string s)
        {
            s = s.TrimEnd();
            if (String.IsNullOrEmpty(s)) return 0;
            int count = 0;
            bool lastWasWordChar = false;
            foreach (char c in s)
            {
                if (Char.IsLetterOrDigit(c) || c == '_' || c == '\'' || c == '-')
                {
                    lastWasWordChar = true;
                    continue;
                }
                if (lastWasWordChar)
                {
                    lastWasWordChar = false;
                    count++;
                }
            }
            if (!lastWasWordChar) count--;
            return count + 1;
        }

        */


        //Zoom in richTexBox
      /*  private void ZoomMyRichTextBox()
        {
            // Enable users to select entire word when double clicked.
            pantalla.AutoWordSelection = true;
            // Clear contents of control.
            pantalla.Clear();
            // Set the right margin to restrict horizontal text.
            pantalla.RightMargin = 800;
            // Set the text for the control.
            pantalla.SelectedText = "Alpha Bravo Charlie Delta Echo Foxtrot";
            // Zoom by 2 points.
            pantalla.ZoomFactor = 2.0f;
        } */

        

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            pantalla.Clear();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            System.IO.StreamReader myStreamReader = null;
            open.Filter = "text(*.txt*)|*.txt|HTML(*.html*)|*.html|All files(*,*)|*,*";

            open.CheckFileExists = true;
            open.ShowDialog(this);
            try
            {
                open.OpenFile();
                myStreamReader = System.IO.File.OpenText(open.FileName);
                pantalla.Text = myStreamReader.ReadToEnd();

            }
            catch (Exception) { }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog Save = new SaveFileDialog();
            System.IO.StreamWriter myStreamWritter = null;
            Save.Filter = "text(*.txt*)|*.txt|HTML(*.html*)|*.html|All files(*,*)|*,*";
            Save.CheckPathExists = true;
            Save.Title = "Guardar Como";
            Save.ShowDialog(this);
            try
            {

                myStreamWritter = System.IO.File.AppendText(Save.FileName);
                myStreamWritter.Write(pantalla.Text);
                myStreamWritter.Flush();

            }
            catch (Exception) { }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog Save = new SaveFileDialog();
            System.IO.StreamWriter myStreamWritter = null;
            Save.Filter = "text(*.txt*)|*.txt|HTML(*.html*)|*.html|All files(*,*)|*,*";
            Save.CheckPathExists = true;
            Save.Title = "Guardar Como";
            Save.ShowDialog(this);
            try
            {

                myStreamWritter = System.IO.File.AppendText(Save.FileName);
                myStreamWritter.Write(pantalla.Text);
                myStreamWritter.Flush();

            }
            catch (Exception) { }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if

            (MessageBox.Show("¿Seguro que dese salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
            
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pantalla.Undo();
        }

        private void adelanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pantalla.Redo();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pantalla.Copy();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pantalla.Paste();
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pantalla.Cut();
        }
               

        private void seleccionarTodoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pantalla.SelectAll();
        }

        private void deshacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pantalla.SelectionFont = new System.Drawing.Font(pantalla.SelectionFont, FontStyle.Bold);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pantalla.SelectionFont = new System.Drawing.Font(pantalla.SelectionFont, FontStyle.Underline); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pantalla.SelectionFont = new System.Drawing.Font(pantalla.SelectionFont, FontStyle.Italic); 
        }

        private void button4_Click(object sender, EventArgs e)
        {            
          pantalla.SelectionFont = new System.Drawing.Font(pantalla.SelectionFont, FontStyle.Regular);                       
        }
      
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (SeleccionCombobox.SelectedIndex == 0)
            {
                pantalla.SelectionColor = System.Drawing.Color.Black;
            }
            if (SeleccionCombobox.SelectedIndex == 1)
            {
                pantalla.BackColor = Color.Black;
                pantalla.Focus();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            
            if (SeleccionCombobox.SelectedIndex == 0)
            {
                pantalla.SelectionColor = System.Drawing.Color.Blue;
            }
            if (SeleccionCombobox.SelectedIndex == 1)
            {
                pantalla.BackColor = Color.Blue;
                pantalla.Focus();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pantalla.SelectionColor = System.Drawing.Color.Purple;
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (SeleccionCombobox.SelectedIndex == 0)/*Este es si elijes "letra"*/
            {
                pantalla.SelectionColor = System.Drawing.Color.Purple;
            }
            if (SeleccionCombobox.SelectedIndex == 1)
            {
                pantalla.BackColor = Color.Purple;
                pantalla.Focus();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (SeleccionCombobox.SelectedIndex == 0)
            {
                pantalla.SelectionColor = System.Drawing.Color.Red;
            }
            if (SeleccionCombobox.SelectedIndex == 1)
            {
                pantalla.BackColor = Color.Red;
                pantalla.Focus();
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (SeleccionCombobox.SelectedIndex == 0)
            {
                pantalla.SelectionColor = System.Drawing.Color.LightBlue;
            }
            if (SeleccionCombobox.SelectedIndex == 1)
            {
                pantalla.BackColor = Color.LightBlue;
                pantalla.Focus();
            };
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (SeleccionCombobox.SelectedIndex == 0)
            {
                pantalla.SelectionColor = System.Drawing.Color.Green;
            }
            if (SeleccionCombobox.SelectedIndex == 1)
            {
                pantalla.BackColor = Color.Green;
                pantalla.Focus();
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (SeleccionCombobox.SelectedIndex == 0)
            {
                pantalla.SelectionColor = System.Drawing.Color.Yellow;
            }
            if (SeleccionCombobox.SelectedIndex == 1)
            {
                pantalla.BackColor = Color.Yellow;
                pantalla.Focus();
            }
        }
               
        private void button5_Click_2(object sender, EventArgs e)
        {
           
            pantalla.SelectionAlignment = HorizontalAlignment.Center;

        }

        private void button7_Click(object sender, EventArgs e)
        {   
            
            pantalla.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            pantalla.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void comboFuente_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            pantalla.SelectAll();
            fuenteselect = Convert.ToString(comboFuente.SelectedItem);            
            pantalla.SelectionFont = new System.Drawing.Font(fuenteselect, Sizefuente);
            pantalla.SelectionStart = pantalla.Text.Length;
            pantalla.Focus();
            
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pantalla.SelectionIndent = PI;
            pantalla.SelectionHangingIndent = PHI;
            pantalla.SelectionRightIndent = PRI;
            SeleccionCombobox.SelectedIndex = 0;
            foreach (FontFamily fuente in System.Drawing.FontFamily.Families)
            {
                if ((fuente.Name != "Aharoni") && (fuente.Name != "Berlin Sans FB Demi") && (fuente.Name != "Brush Script MT")
                    && (fuente.Name != "Harlow Solid Italic") && (fuente.Name != "Magneto") && (fuente.Name != "Palace Script MT")
                    && (fuente.Name != "Vivaldi") && (fuente.Name != "Monotype Corsiva"))
                {
                    comboFuente.Items.Add(fuente.Name);
                    fuenteToolStripMenuItem.DropDownItems.Add(fuente.Name);
                }

            }
            comboSize.SelectedIndex = 1; 
            comboFuente.SelectedIndex = 222;
            fuenteselect = Convert.ToString(comboFuente.SelectedIndex);
        }

        private void comboSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            pantalla.SelectAll();
            int valor = Convert.ToInt32(comboSize.SelectedItem);
            Sizefuente = valor;
            pantalla.SelectionFont = new System.Drawing.Font(fuenteselect, Sizefuente);
            pantalla.SelectionStart = pantalla.Text.Length;
            pantalla.Focus();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            if (SeleccionCombobox.SelectedIndex == 0)
            {
                pantalla.SelectionColor = System.Drawing.Color.White;
            }
            if (SeleccionCombobox.SelectedIndex == 1)
            {
                pantalla.BackColor = Color.White ;
                pantalla.Focus();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (pantalla.SelectionBullet == true)
            {
                pantalla.SelectionBullet = false;
            }
            else
            {
                pantalla.SelectionBullet = true;
            }

            pantalla.SelectionStart = pantalla.Text.Length;
            pantalla.Focus();
        }

        private void SeleccionCombobox_Click(object sender, EventArgs e)
        {

        }

        

        

       

                     

        
    }
}
