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

    {    // Listas de Favoritos 

        List<String> Favoritos = new List<string>();

        

        
        
        
        ArrayList listapestana = new ArrayList();
        int contarpestana = 0;
        public WebBrowser nuevowebbroser = new WebBrowser();
        public TabPage nuevapestana = new TabPage("nueva pestana");
        public Form1()
        {
            InitializeComponent();
            tabPage1.Text = "Google";
            tabPage1.Controls.Add(nuevowebbroser);
            nuevowebbroser.Dock = DockStyle.Fill;
            nuevowebbroser.Navigate("https://www.google.com.do");

           
        }

        

        public void crearpestana()
        {
            
            
            contarpestana++;
            nuevapestana = new TabPage("Nueva Pestana" + contarpestana);
            listapestana.Add(nuevapestana);
            tabControl1.TabPages.Add(nuevapestana);
            tabControl1.SelectedTab = nuevapestana;
            nuevapestana.Controls.Add(nuevowebbroser);
            nuevowebbroser.Dock = DockStyle.Fill;

            
                        
        }

        public void eliminarpestana()
        {
            TabPage current_tab = tabControl1.SelectedTab;
            listapestana.Remove(current_tab);
            tabControl1.TabPages.Remove(current_tab);
            contarpestana--;

        }

        
        
        public void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "google.com";
            
         }

        public void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevowebbroser.GoHome();
        }

        public void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevowebbroser.GoBack();
        }

        public void adelanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevowebbroser.GoForward();
        }

        public void escribirURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.Focus();

        }

        public void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void button1_Click(object sender, EventArgs e)
        {
           
            
        }

       

        public void button3_Click(object sender, EventArgs e)
        {
            nuevowebbroser.GoHome();
        }

        public void button6_Click(object sender, EventArgs e)
        {
            nuevowebbroser.Refresh();
        }

        public void button7_Click(object sender, EventArgs e)
        {
            this.nuevowebbroser.Navigate(this.comboBox1.Text);
        }

        public void button4_Click(object sender, EventArgs e)
        {
            
        }

        public void button5_Click(object sender, EventArgs e)
        {
            
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Favoritos.Add(nuevowebbroser.Url.ToString());
            
            
            if (e.KeyChar == (char)13)
            {
                comboBox1.Items.Add(comboBox1.Text);
                this.nuevowebbroser.Navigate(this.comboBox1.Text);
                
            }

            
        
        
        }

        public void button8_Click(object sender, EventArgs e)
        {
            nuevowebbroser.GoBack();
        }

        public void button9_Click(object sender, EventArgs e)
        {
            nuevowebbroser.GoForward();
        }

        public void button5_Click_1(object sender, EventArgs e)
        {
            nuevowebbroser.Refresh();
        }

        public void button4_Click_1(object sender, EventArgs e)
        {
            crearpestana();
            comboBox1.Focus();
        }

        public void button6_Click_1(object sender, EventArgs e)
        {
            eliminarpestana();
        }

        public void button1_Click_1(object sender, EventArgs e)
        {
            
            /*Favoritos.Add(nuevowebbroser.Url.ToString());
            
            cmbFavoritos.Items.Clear();
            actualizarcmbfavorito(); */

            cmbFavoritos.Items.Add(comboBox1.Text);
            
            
        }

        //Almacena el combobox Favoritos
        public void actualizarcmbfavorito() {

            cmbFavoritos.Items.Add(nuevowebbroser.Url.ToString());
            
                   
                
                //cmbFavoritos.Items.Add(direccion);
            
           
        }

       



        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            nuevowebbroser.Navigate(comboBox1.Text);
        }

        public void cmbFavoritos_SelectedIndexChanged(object sender, EventArgs e)
        {
          nuevowebbroser.Navigate(cmbFavoritos.SelectedItem.ToString());
        }

        public void cmbFavoritos_Enter(object sender, EventArgs e)
        {

        }

        public void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
                     

            frm2.Show();
           
        }

       
       
       
       }

              
        
        
        }


        

       
    
