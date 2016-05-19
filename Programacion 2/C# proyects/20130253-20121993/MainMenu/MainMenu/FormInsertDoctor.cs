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
    public partial class FormInsertDoctor : Form
    {
        public FormInsertDoctor()
        {
            InitializeComponent();
        }
        Broker b = new Broker();
        private void FormInsertDoctor_Load(object sender, EventArgs e)
        {
            listBoxEspecialidadInsert.Enabled = false;
            buttonAddEspecialidad.Enabled = false;
            buttonRemoveEspecialidad.Enabled = false;
            cbmEspecialidad.Enabled = false;
            cmbSexo.SelectedIndex = 0;

            //ocultar los listbox innecesarios v
            listBoxIDEspecialidad.Visible = false;
            listBoxEspecialidad.Visible = false;
            listDoctores.Visible = false;
            listBoxIDsEspecialidadesInsert.Visible = false;
            cbmIdEspecialidad.Visible = false;
            //ocultar los listbox innecesarios ^
            
            listBoxEspecialidad.DataSource = b.ActualizarEspecialidad(); //llama las especialidades en el listbox escondido
            listBoxIDEspecialidad.DataSource = b.IDsEspecialidades(); //llama los ID de las especialidades en el listobx escondido

            for (int x = 0; x <= listBoxEspecialidad.Items.Count - 1; x++)
                cbmEspecialidad.Items.Add(listBoxEspecialidad.Items[x]); 
            //agrega al combobox de especialidades, las especialidades en el listbox escondido que fueron llamadas anteriormente

            for (int x = 0; x <= listBoxIDEspecialidad.Items.Count - 1; x++)
                cbmIdEspecialidad.Items.Add(listBoxIDEspecialidad.Items[x]);
            //agrega al combobox de id de especialidades, los IDS en el listbox escondido que fueron llamados anteriormente      
           
        }

        private void botonInsertar_Click(object sender, EventArgs e)
        {
            if ((txtNombre.Text == "") || (txtApellido.Text == "") || (MaskedTxtCedula.Text == "") || (MaskedTxtFechaNac.Text == ""))
            {
                MessageBox.Show("Debe insertar los datos requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Doctor p = new Doctor();
                p.Nombre = txtNombre.Text;
                p.Apellido = txtApellido.Text;
                p.Cedula = MaskedTxtCedula.Text;
                p.Fechanac = MaskedTxtFechaNac.Text;
                p.Sexo = cmbSexo.Text;
                b.InsertDoctor(p);                
                //Llamar Limpiar
                if (checkEspecialidad.Checked == true)
                {
                    int id;
                    /*HACER QUE SE INSERTEN LOS DATOS EN LA RESULTANTE*/
                    listDoctores.DataSource = b.ActualizarDoctores(); //llena el listbox doctores con todos los doctores
                    listDoctores.SelectedIndex = listDoctores.Items.Count - 1; //selecciona el ultimo doctor
                    Doctor Doc = new Doctor();
                    Doc = listDoctores.SelectedItem as Doctor; //guarda en la variable Doc, todos los datos del ultimo doctor.
                    for (int x = 0; x <= listBoxEspecialidadInsert.Items.Count - 1; x++ )//for del insert
                    {
                        listBoxIDsEspecialidadesInsert.SelectedIndex= x;
                        id = Convert.ToInt32(listBoxIDsEspecialidadesInsert.SelectedItem);
                        b.Insert_Doc_ESPACIALIDAD(Doc, id); //codigo insert, parametros: (Doc, id); se le pasa Doc entero para especificar el ID en el broker
                    }    
                }

                MessageBox.Show("Se ha insertado exitosamente", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonAddEspecialidad_Click(object sender, EventArgs e)
        {
            if (cbmEspecialidad.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un item a insertar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listBoxEspecialidadInsert.Items.Add(cbmEspecialidad.SelectedItem); //Agrega al listbox, el item del combobox
                cbmEspecialidad.Items.Remove(cbmEspecialidad.SelectedItem); //remueve del combobox, el item agregado

                listBoxIDsEspecialidadesInsert.Items.Add(cbmIdEspecialidad.SelectedItem); //Agrega al listbox, el item del combobox
                cbmIdEspecialidad.Items.Remove(cbmIdEspecialidad.SelectedItem); //remueve del combobox, el item agregado
            }            
        }

        private void buttonRemoveEspecialidad_Click(object sender, EventArgs e)
        {
            if ((listBoxEspecialidadInsert.SelectedIndex < 0) || (listBoxEspecialidadInsert.SelectedItem == null))
            {
                MessageBox.Show("Seleccione un item a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listBoxIDsEspecialidadesInsert.SelectedIndex = listBoxEspecialidadInsert.SelectedIndex; //Iguala los index de los dos listbox para que puedan borrarse simultaneamente

                cbmEspecialidad.Items.Add(listBoxEspecialidadInsert.SelectedItem); //Agrega al combobox el item seleccionado del listbox
                listBoxEspecialidadInsert.Items.Remove(listBoxEspecialidadInsert.SelectedItem); //Remueve el item seleccionado del listbox

                cbmIdEspecialidad.Items.Add(listBoxIDsEspecialidadesInsert.SelectedItem); //Agrega al combobox el item seleccionado del listbox
                listBoxIDsEspecialidadesInsert.Items.Remove(listBoxIDsEspecialidadesInsert.SelectedItem); //Remueve el item seleccionado del listbox               
            }
        }

        private void checkEspecialidad_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEspecialidad.Checked == true)
            {
                listBoxEspecialidadInsert.Enabled = true;
                buttonAddEspecialidad.Enabled = true;
                buttonRemoveEspecialidad.Enabled = true;
                cbmEspecialidad.Enabled = true;
            }
            else
            {
                listBoxEspecialidadInsert.Enabled = false;
                buttonAddEspecialidad.Enabled = false;
                buttonRemoveEspecialidad.Enabled = false;
                cbmEspecialidad.Enabled = false;
            }
        }

        private void cbmEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbmIdEspecialidad.SelectedIndex = cbmEspecialidad.SelectedIndex;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        
        
    }
}
