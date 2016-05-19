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
    public partial class FormInsertEspecialidad : Form
    {
        public FormInsertEspecialidad()
        {
            InitializeComponent();
        }
        Broker b = new Broker();
        private void botonInsertar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe insertar los datos requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Especialidad p = new Especialidad();
                p.Nombre = txtNombre.Text;
                p.Descripcion = txtDescripcion.Text;
                b.InsertEspecialidad(p);
                MessageBox.Show("Se ha insertado exitosamente", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Clear();
                txtDescripcion.Clear();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
