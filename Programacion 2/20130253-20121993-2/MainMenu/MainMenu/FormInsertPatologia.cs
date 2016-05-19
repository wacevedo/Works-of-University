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
    public partial class FormInsertPatologia : Form
    {
        public FormInsertPatologia()
        {
            InitializeComponent();
        }        

        private void Limpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtSintomas.Clear();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
        Broker b = new Broker();
        private void botonInsertar_Click(object sender, EventArgs e)
        {
            if ((txtNombre.Text == "") || (txtSintomas.Text == ""))
            {
                MessageBox.Show("Debe insertar los datos requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Patologia p = new Patologia();
                p.Nombre = txtNombre.Text;
                p.Descripcion = txtDescripcion.Text;
                p.Sintomas_usuales = txtSintomas.Text;
                b.InsertPatologia(p);
                MessageBox.Show("Se ha insertado exitosamente", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);                
                txtNombre.Clear();
                txtDescripcion.Clear();
                txtSintomas.Clear();
            }

        }
    }
}
