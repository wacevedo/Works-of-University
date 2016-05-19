using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sesion;
using Dominio;

namespace MainMenu
{
    public partial class FormInsertCentroS : Form
    {
        Broker b = new Broker();
        public FormInsertCentroS()
        {
            InitializeComponent();
        }
        private void Limpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtDireccion.Clear();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonInsertar_Click(object sender, EventArgs e)
        {
            if ((txtNombre.Text == "") || (txtDireccion.Text == ""))
            {
                MessageBox.Show("Debe insertar los datos requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CentroSalud p = new CentroSalud();
                p.Nombre = txtNombre.Text;
                p.Direccion = txtDireccion.Text;
                b.InsertCentroS(p);
                MessageBox.Show("Se ha insertado exitosamente", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Clear();
                txtDireccion.Clear();
            }
        }

      
    }
}
