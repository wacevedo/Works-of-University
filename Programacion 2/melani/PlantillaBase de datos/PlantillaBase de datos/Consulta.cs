using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClassLibrary1;
using Entidades;
namespace PlantillaBase_de_datos
{
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            Sentencias b = new Sentencias();
            
           comboBox1.DataSource = b.SelectPaciente();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Paciente p = new Paciente();
            p = comboBox1.SelectedItem as Paciente;
            gridPaciente.Rows[0].Cells[0].Value = p.Nombres1;
            gridPaciente.Rows[0].Cells[1].Value = p.Apellidos1;
            gridPaciente.Rows[0].Cells[2].Value = p.Cedula1;
            gridPaciente.Rows[0].Cells[3].Value = p.Peso1;
            gridPaciente.Rows[0].Cells[4].Value = p.TipoSangre1;



        }

        private void buttonGenera_Click(object sender, EventArgs e)
        {
           
            Plantilla p = new Plantilla(comboBox1.SelectedItem as Paciente);
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Consulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Principal p = new Principal();
            p.Show();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal p = new Principal();
            p.Show();
        }

        
    }
}
