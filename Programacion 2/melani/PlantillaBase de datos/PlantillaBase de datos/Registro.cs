using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using ClassLibrary1;

namespace PlantillaBase_de_datos
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }        

        private void Registro_Load(object sender, EventArgs e)
        {
            cmbSangre.SelectedIndex = 0;
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCedula.Clear();
            txtPeso.Clear();
            cmbSangre.SelectedIndex = 0;
        }
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();   
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            Paciente p = new Paciente();
            p.Nombres1 = txtNombre.Text;
            p.Apellidos1 = txtApellido.Text;
            p.Cedula1 = txtCedula.Text;
            p.TipoSangre1 = cmbSangre.Text;
            p.Peso1 = Convert.ToDouble(txtPeso.Text);

            Sentencias sent = new Sentencias();
            sent.InsertPaciente(p);

            //Poner un cuadro confirmando que se inserto.
            Limpiar();
            
        }

        private void Registro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Principal p = new Principal();
            p.Show();
        }


    }
}
