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
    public partial class FormInsertEspecialidadDoc : Form
    {
        public FormInsertEspecialidadDoc()
        {
            InitializeComponent();
        }

        Broker b = new Broker();
        private void FormInsertEspecialidad_Load(object sender, EventArgs e)
        {
            cmbNombre.DataSource = b.ActualizarDoctores();
            groupBox1.Visible = false;
            
            especialidades_doc.DataSource = b.ActualizarEspecialidad();//llama las especialidades en el listbox escondido
            especialidades_id.DataSource = b.IDsEspecialidades();//llama los ID de las especialidades en el listobx escondido

            for (int x = 0; x <= especialidades_doc.Items.Count - 1; x++)
                cbmEspecialidad.Items.Add(especialidades_doc.Items[x]);
            //agrega al combobox de especialidades, las especialidades en el listbox escondido que fueron llamadas anteriormente

            for (int x = 0; x <= especialidades_id.Items.Count - 1; x++)
                cmbIdEspecialidad.Items.Add(especialidades_id.Items[x]);
            //agrega al combobox de id de especialidades, los IDS en el listbox escondido que fueron llamados anteriormente   

            int f;
            f = cmbNombre.SelectedIndex;
            cmbNombre.SelectedIndex = cmbNombre.Items.Count - 1;
            cmbNombre.SelectedIndex = f;
            

            
        }

        private void buttonAddEspecialidad_Click(object sender, EventArgs e)
        {
            if (cbmEspecialidad.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un item a insertar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listBoxEspecialidad.Items.Add(cbmEspecialidad.SelectedItem); //Agrega al listbox, el item del combobox
                cbmEspecialidad.Items.Remove(cbmEspecialidad.SelectedItem); //remueve del combobox, el item agregado

                Especialidades_IdSelected.Items.Add(cmbIdEspecialidad.SelectedItem); //Agrega al listbox, el item del combobox
                cmbIdEspecialidad.Items.Remove(cmbIdEspecialidad.SelectedItem); //remueve del combobox, el item agregado
            }      
        }
        
        private void cmbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbmEspecialidad.Items.Clear();
            Doctor p = new Doctor();
            p = cmbNombre.SelectedItem as Doctor;
            listDoctores.DataSource = b.ActualizarEspecialidad();
            especialidades_doc.DataSource = b.Select_Especialidad_Doctor(p);

            for (int x = 0; x <= listDoctores.Items.Count - 1; x++)
            {
                listDoctores.SelectedIndex = x;
                int z =0;
                for (int y = 0; y < especialidades_doc.Items.Count - 1; y++)
                {
                    especialidades_doc.SelectedIndex = y;
                    if (especialidades_doc.SelectedItem.ToString() == listDoctores.SelectedItem.ToString())
                    {
                        z++;
                    }
                }

                if (z == 0)
                {
                    listDoctores.SelectedIndex = x;
                    cbmEspecialidad.Items.Add(listDoctores.SelectedItem);
                }
            }



        }

        private void botonInsertar_Click(object sender, EventArgs e)
        {
            int id;

            if ((cbmEspecialidad.SelectedIndex < 0) || (cmbNombre.SelectedIndex < 0) || (cmbNombre.SelectedItem == null))
            {
                MessageBox.Show("Debe insertar los datos requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Doctor Doc = new Doctor();

                Doc = cmbNombre.SelectedItem as Doctor; //guarda en la variable Doc, todos los datos del doctor.
                for (int x = 0; x <= Especialidades_IdSelected.Items.Count - 1; x++)//for del insert
                {
                    Especialidades_IdSelected.SelectedIndex = x;
                    id = Convert.ToInt32(Especialidades_IdSelected.SelectedItem);
                    b.Insert_Doc_ESPACIALIDAD(Doc, id); //codigo insert, parametros: (Doc, id); se le pasa Doc entero para especificar el ID en el broker
                }

                MessageBox.Show("Se ha insertado exitosamente", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonRemoveEspecialidad_Click(object sender, EventArgs e)
        {
            if ((listBoxEspecialidad.SelectedIndex < 0) || (listBoxEspecialidad.SelectedItem == null))
            {
                MessageBox.Show("Seleccione un item a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Especialidades_IdSelected.SelectedIndex = listBoxEspecialidad.SelectedIndex; //Iguala los index de los dos listbox para que puedan borrarse simultaneamente

                cbmEspecialidad.Items.Add(listBoxEspecialidad.SelectedItem); //Agrega al combobox el item seleccionado del listbox
                listBoxEspecialidad.Items.Remove(listBoxEspecialidad.SelectedItem); //Remueve el item seleccionado del listbox

                cmbIdEspecialidad.Items.Add(Especialidades_IdSelected.SelectedItem); //Agrega al combobox el item seleccionado del listbox
                Especialidades_IdSelected.Items.Remove(Especialidades_IdSelected.SelectedItem); //Remueve el item seleccionado del listbox               
            }

        }

        private void cbmEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIdEspecialidad.SelectedIndex = cbmEspecialidad.SelectedIndex;

        }

        private void listBoxEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
           // Especialidades_IdSelected.SelectedIndex = listBoxEspecialidad.SelectedIndex;
        }

    }
}
