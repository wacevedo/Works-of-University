using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalcLosas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Losa> aLosas = new List<Losa>();

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int x = 0; x <= 59; x++)
            {
                Losa l = new Losa();
                l.Nombre= "L" + (x+1);
                aLosas.Add(l);
            }
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            cmbLosas.Items.Clear();
            //Borra items del combobox

            for (int x = 0; x <= numericUpDown1.Value - 1; x++)                
            {
                cmbLosas.Items.Add(aLosas[x]);
            }
            //Inserta los itemes del arreglo al combobox
            dataGridView1.DataSource = cmbLosas;
            
        }

        private void cmbLosas_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtLx.Text = Convert.ToString(aLosas[cmbLosas.SelectedIndex].Lx);
            txtLy.Text = Convert.ToString(aLosas[cmbLosas.SelectedIndex].Ly);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cuanti g = new Cuanti();
            g.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cuanti2 g = new Cuanti2();
            g.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Espesores g = new Espesores();
            g.Show();
        }

        
    }
}
