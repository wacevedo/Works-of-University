using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dominio;
using Sesion;

namespace MainMenu
{
    public partial class Habitacion : Form
    {
        public Habitacion()
        {
            InitializeComponent();
        }
        Broker b = new Broker();
        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            if ((txtNombreNum.Text == "") || (txtCapacidad.Text == "") || (txtDescripcion.Text == "") ) 
            {
                MessageBox.Show("Debe insertar los datos requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CentroSalud id = new CentroSalud();
                id = cmbClinica.SelectedItem as CentroSalud;
                Dominio.Habitacion p = new Dominio.Habitacion();
                p.Numero_habi = txtNombreNum.Text;
                p.Capacidad = Convert.ToInt32(txtCapacidad.Text);
                p.Descripcion = txtDescripcion.Text;              

                b.InsertHabitacion(p, id);
                MessageBox.Show("Se ha insertado exitosamente", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombreNum.Clear();
                txtCapacidad.Clear();
                txtDescripcion.Clear();              
            }
        }

        private void Habitacion_Load(object sender, EventArgs e)
        {
            cmbClinica.DataSource = b.ActualizarCentroSalud(); 
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        
    }
}
