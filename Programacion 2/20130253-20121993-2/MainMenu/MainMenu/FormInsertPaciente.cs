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
    public partial class FormInsertPaciente : Form
    {
        public FormInsertPaciente()
        {
            InitializeComponent();
        }        

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            MaskedTxtFechaNac.Clear();
            MaskedTxtCedula.Clear(); ;
            txtPeso.Clear();
            cbmSexo.SelectedIndex = 0;
        }

        private void bindingNavigatorCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Broker b = new Broker();
        private void botonInsertar_Click(object sender, EventArgs e)
        {
            if ((txtNombre.Text == "") || (txtApellido.Text == "")  || (MaskedTxtFechaNac.Text == "") || (txtPeso.Text == ""))
            {
                MessageBox.Show("Debe insertar los datos requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Paciente p = new Paciente();
                p.Nombre = txtNombre.Text;
                p.Apellido = txtApellido.Text;
                p.Direccion = txtDireccion.Text;
                p.Fechanac = MaskedTxtFechaNac.Text;
                p.Cedula = MaskedTxtCedula.Text;
                p.Peso = Convert.ToInt32(txtPeso.Text);
                p.Sexo = cbmSexo.Text;
                b.InsertPaciente(p);
                MessageBox.Show("Se ha insertado exitosamente", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Clear();
                txtApellido.Clear();
                txtDireccion.Clear();
                MaskedTxtFechaNac.Clear();
                MaskedTxtCedula.Clear(); ;
                txtPeso.Clear();
                cbmSexo.SelectedIndex = 0;  
            }
        }

        private void FormInsertPaciente_Load(object sender, EventArgs e)
        {
            cbmSexo.SelectedIndex = 0;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }    
    }
}
