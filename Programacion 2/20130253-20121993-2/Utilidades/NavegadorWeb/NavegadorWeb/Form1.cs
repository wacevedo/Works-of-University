using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace NavegadorWeb
{
    public partial class Form1 : Form
    {
        ArrayList listapestagna = new ArrayList();
        //ArrayList historial; 
        string valnuevoweb;
        int countpestagna=0;
        public WebBrowser nuevowebbrowser = new WebBrowser();
        public TabPage nuevapestagna = new TabPage("Nueva Pestaña");
        public Form1()
        {
            InitializeComponent();                    
        }
        private void Crearpestagna()
        {
            countpestagna++;
            nuevapestagna = new TabPage("Nueva Pestaña"+countpestagna);
            nuevowebbrowser = new WebBrowser();
            listapestagna.Add(nuevapestagna);
            tabControl1.TabPages.Add(nuevapestagna);
            tabControl1.SelectedTab = nuevapestagna;
            nuevapestagna.Controls.Add(nuevowebbrowser);
            nuevowebbrowser.Dock = DockStyle.Fill;
            nuevowebbrowser.ProgressChanged += new WebBrowserProgressChangedEventHandler(Form1_ProgressChanged);

            //nuevowebbrowser.Navigate(comboBox1.Text/*+".com"*/);
            /*comboBox1.Text = Convert.ToString(nuevowebbrowser.Url);
            comboBox1.Items.Add(Convert.ToString(nuevowebbrowser.Url));
            nuevapestagna.Text = comboBox1.Text;
            if (comboBox1.Text == "about:blank")
            {
                comboBox1.Text = "listo";
            }*/
        }

        private void Eliminarpestagna()
        {
            TabPage current_tab = tabControl1.SelectedTab;
            listapestagna.Remove(current_tab);
            tabControl1.TabPages.Remove(current_tab);
            countpestagna--;
        }

        private void buttoninicio_Click(object sender, EventArgs e)
        {   
            nuevowebbrowser.GoHome();
            comboBox1.Text = Convert.ToString(nuevowebbrowser.Url.AbsoluteUri);
            if (countpestagna == 0)
            {
                tabPage1.Text = "HOME";
            }
            else
            {
                nuevapestagna.Text = "HOME";
            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevowebbrowser.GoHome();
            comboBox1.Text = Convert.ToString(nuevowebbrowser.Url.AbsoluteUri);
            if (countpestagna == 0)
            {
                tabPage1.Text = "HOME";
            }
            else
            {
                nuevapestagna.Text = "HOME";
            } 
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            nuevowebbrowser.GoBack();
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevowebbrowser.GoBack();
        }

        private void adelanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevowebbrowser.GoForward();
        }

        private void buttonAdelante_Click(object sender, EventArgs e)
        {
            nuevowebbrowser.GoForward();
        }

        private void escribirURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.Focus();
            //textBox1.Focus();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonPestaña_Click(object sender, EventArgs e)
        {
            Crearpestagna();
            //textBox1.Focus(); 
            comboBox1.Focus();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            Eliminarpestagna();
        }

        private void buttonIr_Click(object sender, EventArgs e)
        {
            
            //nuevapestagna.Text = textBox1.Text;
            //nuevowebbrowser.Navigate(textBox1.Text/*+".com"*/);          
            //textBox1.Text =Convert.ToString(nuevowebbrowser.Url);
                      
           nuevowebbrowser.Navigate(comboBox1.Text/*+".com"*/);
            //getCurrentTab().Navigate(comboBox1.Text);
           //historial.Add(comboBox1.Text);
           //comboBox1.Text = Convert.ToString(nuevowebbrowser.Url.AbsoluteUri);
            valnuevoweb=Convert.ToString(nuevowebbrowser.Url);
            if ((valnuevoweb != "about:blank") && (valnuevoweb != " ") && (valnuevoweb != ""))
            {
                comboBox1.Items.Add(Convert.ToString(nuevowebbrowser.Url));
            }

            if (countpestagna == 0)
            {
                tabPage1.Text = comboBox1.Text;
            }
            else
            {
                nuevapestagna.Text = comboBox1.Text;
            }          
        }
        private void evento_Ir()
        {
            //nuevapestagna.Text = textBox1.Text;
            //nuevowebbrowser.Navigate(textBox1.Text/*+".com"*/);          
            //textBox1.Text =Convert.ToString(nuevowebbrowser.Url);

            nuevowebbrowser.Navigate(comboBox1.Text/*+".com"*/);
            //historial.Add(comboBox1.Text);
            //comboBox1.Text = Convert.ToString(nuevowebbrowser.Url.AbsoluteUri);
            valnuevoweb = Convert.ToString(nuevowebbrowser.Url);
            if ((valnuevoweb != "about:blank") && (valnuevoweb != " ") && (valnuevoweb != ""))
            {
                comboBox1.Items.Add(Convert.ToString(nuevowebbrowser.Url));
            }

            if (countpestagna == 0)
            {
                tabPage1.Text = comboBox1.Text;
            }
            else
            {
                nuevapestagna.Text = comboBox1.Text;
            } 
        }

        private void buttonActualiza_Click(object sender, EventArgs e)
        {
            nuevowebbrowser.Refresh();
        }

        private void nuevaPestañaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Crearpestagna();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProgressBar1.Hide();
            tabPage1.Controls.Add(nuevowebbrowser);
            nuevowebbrowser.Dock = DockStyle.Fill;
            //nuevowebbrowser.Navigate("http://google.com.do");
            //tabPage1.Text = "http://google.com.do"; 
            comboBox1.Text = "http://google.com.do";
            //nuevowebbrowser.Navigate(comboBox1.Text/*+".com"*/);
            getCurrentTab().Navigate(comboBox1.Text);
            valnuevoweb = Convert.ToString(nuevowebbrowser.Url);
            if ((valnuevoweb != "about:blank") && (valnuevoweb != " ") && (valnuevoweb != ""))
            {
                comboBox1.Items.Add(Convert.ToString(nuevowebbrowser.Url));
            }
            tabPage1.Text = comboBox1.Text; 

        }
        protected void myCombo_OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                getCurrentTab().Navigate(comboBox1.Text);
                //evento_Ir();
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.SelectAll();
        }
       
        private WebBrowser getCurrentTab()
        {
           // if (tabControl1.SelectedTab.Controls!=0)
            return (WebBrowser)tabControl1.SelectedTab.Controls[0];
        }
        private void Form1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {

             ProgressBar1.Show();
            if ((e.CurrentProgress < e.MaximumProgress) && (e.CurrentProgress > 0) && (e.CurrentProgress < ProgressBar1.Maximum))
            {
                ProgressBar1.Maximum = Convert.ToInt32(e.MaximumProgress/13);
                if (e.CurrentProgress == e.MaximumProgress)
                { ProgressBar1.Value = ProgressBar1.Maximum;}
                else
                ProgressBar1.Value = (int)e.CurrentProgress;
            }
            else
            {
                ProgressBar1.Value = ProgressBar1.Minimum;
                ProgressBar1.Hide();
            }

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
             if ((valnuevoweb != "about:blank") && (valnuevoweb != " ") && (valnuevoweb != ""))
            {
                if ((comboBox1.Text != Convert.ToString(nuevowebbrowser.Url)) && (textBox1.Text !="Complete"))
                {
                    comboBox1.Text = Convert.ToString(nuevowebbrowser.Url);                    
                }
                
                textBox1.Text =Convert.ToString(nuevowebbrowser.ReadyState);

            }
        }
    }
}
