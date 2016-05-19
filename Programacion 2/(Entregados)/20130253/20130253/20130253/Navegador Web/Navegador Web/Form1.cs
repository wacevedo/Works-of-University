using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Navegador_Web
{
    public partial class Form1 : Form
    {
        ArrayList listapestana = new ArrayList();
        ArrayList listafavoritos = new ArrayList();
        int contarpestana = 0;
        public WebBrowser nuevoweb = new WebBrowser();
        public TabPage nuevapestana = new TabPage();
        
        
        public Form1()
        {
            InitializeComponent();
            tabPage1.Controls.Add(nuevoweb);
            nuevoweb.Dock = DockStyle.Fill;
            nuevoweb.Navigate("http://www.google.com.do");
         }
        private void crearpestana()
        {
            contarpestana++;
            nuevapestana = new TabPage();
            nuevoweb = new WebBrowser();
            listapestana.Add(nuevapestana);
            tabControl1.TabPages.Add(nuevapestana);
            tabControl1.SelectedTab = nuevapestana;
            nuevapestana.Controls.Add(nuevoweb);
            nuevoweb.Dock = DockStyle.Fill;
            nuevoweb.Navigate("http://www.google.com");
            tabControl1.SelectedTab.Text = "google.com";
        }

        private void eliminarpestana()
        {
            TabPage current_tab = tabControl1.SelectedTab;
            listapestana.Remove(current_tab);
            tabControl1.TabPages.Remove(current_tab);
            contarpestana--;
        }
        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevoweb.GoHome();
        }

        private void atrásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevoweb.GoBack();
        }

        private void adelanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevoweb.GoForward();
        }

        private void escribirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.Focus();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Pestana_Click(object sender, EventArgs e)
        {
            crearpestana();
            comboBox1.Focus();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            eliminarpestana();
            comboBox1.Focus();
        }

        private void Inicio_Click(object sender, EventArgs e)
        {
            nuevoweb.GoHome();
            comboBox1.Focus();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            nuevapestana.Text = comboBox1.Text;
            nuevoweb.Navigate(comboBox1.Text); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedTab.Text = "Google.com";
            comboBox1.Items.Add("google.com");
            comboBox1.SelectedIndex = 0;
            nuevoweb.Navigate("http://www.google.com.do");            
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {   
                nuevoweb.Navigate(comboBox1.Text);
                comboBox1.Items.Add(comboBox1.Text);
                comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
                tabControl1.SelectedTab.Text = comboBox1.Text;                
            }
            else
            { }
        }

        private void botonActualizar_Click(object sender, EventArgs e)
        {

            nuevoweb.Refresh();
        }

        private void BotonAtras_Click(object sender, EventArgs e)
        {
            
            
            if (comboBox1.SelectedIndex == 0)
            {
                
            }
            else
            {
                nuevoweb.GoBack();
                comboBox1.SelectedIndex = comboBox1.SelectedIndex - 1;    
            }

        }

        private void botonAdelante_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedIndex == comboBox1.Items.Count - 1)
            { }
            else
            {
                nuevoweb.GoForward();
                comboBox1.SelectedIndex = comboBox1.SelectedIndex + 1;
                
            }
        }
        
        private void botonFav_Click(object sender, EventArgs e)
        {            
            comboBox2.Items.Add(comboBox1.Text);            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            comboBox1.Text = Convert.ToString( comboBox2.SelectedItem);
            nuevoweb.Navigate(comboBox1.Text);
            comboBox1.Items.Add(comboBox1.Text);
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {            
            nuevoweb.Navigate(comboBox1.Text);
            tabControl1.SelectedTab.Text = comboBox1.Text;            
        }

        

        

        


        

        
        

        








    }
}
