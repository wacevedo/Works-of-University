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

namespace BaseDatosPA
{
    public partial class BaseDato : Form
    {
        Broker b = new Broker();

        public BaseDato()
        {
            InitializeComponent();
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            Persona p = new Persona();
            p.Nombres = TxtNombre.Text;
            p.Apellido = TxtApellido.Text;
            p.Direccion = TxtDireccion.Text;
            p.Estado = comboBoxEstado.Text;
            p.Sexo = comboBoxEstado.Text;
            p.Telefono = maskedTextTel.Text;

            b.insert(p);
            comboBoxSelecionPersona.DataSource = b.ActualiazarCombobox();
        }

        private void BaseDato_Load(object sender, EventArgs e)
        {
            comboBoxSelecionPersona.DataSource = b.ActualiazarCombobox();
            comboBoxSexo.SelectedIndex = 0;
            comboBoxEstado.SelectedIndex = 0;
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            Persona viejapersona = new Persona();
            Persona nuevapersona = new Persona();
            viejapersona = comboBoxSelecionPersona.SelectedItem as Persona;
            nuevapersona.Nombres = TxtNuevoNombre.Text;
            nuevapersona.Apellido = TxtNuevoApellido.Text;
            nuevapersona.Direccion = TxtNuevoDirecc.Text;
            nuevapersona.Telefono = maskedTextNuevoTel.Text;
            nuevapersona.Sexo = Convert.ToString(comboBoxNuevoSexo.SelectedItem);
            nuevapersona.Estado = Convert.ToString(comboBoxNuevoEstado.SelectedItem);


            b.update(viejapersona, nuevapersona);
            comboBoxSelecionPersona.DataSource = b.ActualiazarCombobox();

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            p = comboBoxSelecionPersona.SelectedItem as Persona;
            b.Delete(p);
            comboBoxSelecionPersona.DataSource = b.ActualiazarCombobox();
        }

        
    }
}
