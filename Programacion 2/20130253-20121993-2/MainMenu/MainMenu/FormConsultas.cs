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
    public partial class FormConsultas : Form
    {
        public FormConsultas()
        {
            InitializeComponent();
        }
        Broker b = new Broker();
        
        private void FormConsultas_Load(object sender, EventArgs e)
        {
            labelFecha.Text = DateTime.Today.ToString("dd/MM/yyyy"); //Fecha del sistema
           
           
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            cmbClinica.DataSource = b.ActualizarCentroSalud();//llama los centros de salud al comobox de clinica
            cmbPaciente.DataSource = b.ActualizarPaciente();//llama los pacientes al combobox de paciente
            cmbDoctor.DataSource = b.ActualizarDoctores();//llama los doctores al combobox de doctores

            listTodasPatologias.DataSource = b.Actualizar_Patologia(); //llama todas las patologias al listbox
            listTodosIDs.DataSource = b.IDsPatologias(); //llama todos los IDs de patologia

            for (int x = 0; x <= listTodosIDs.Items.Count - 1; x++) //for que agrega los itemes de los listboxes a los comboboxes
            {
                listTodasPatologias.SelectedIndex = x;
                listTodosIDs.SelectedIndex = x;

                cmbPatologia.Items.Add(listTodasPatologias.SelectedItem);
                cmbIDPat.Items.Add(listTodosIDs.SelectedItem);
            }
            
            cmbClinica.SelectedIndex = 0;

            CentroSalud cs = new CentroSalud();
            cs = cmbClinica.SelectedItem as CentroSalud;
            cmbHabitacion.DataSource = b.ActualizarHabitacion(cs);//llama las habitaciones al combobox de habitacion  
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxInternar.Checked == true)
                groupBox1.Enabled = true;
            else
                groupBox1.Enabled = false;
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            txtSintomas.Clear();
            txtTratamiento.Clear();
            MaskedTxtFechaAlta.Clear();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbClinica_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            CentroSalud cs = new CentroSalud();
            cs = cmbClinica.SelectedItem as CentroSalud;
            cmbHabitacion.DataSource = b.ActualizarHabitacion(cs);//llama las habitaciones al combobox de habitacion
        }

        private void botonInsertar_Click(object sender, EventArgs e)
        {
            if ((txtSintomas.Text == "") || (txtTratamiento.Text == ""))
            {
                MessageBox.Show("Debe insertar los datos requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Consulta p = new Consulta();

                CentroSalud cs = new CentroSalud();
                cs = cmbClinica.SelectedItem as CentroSalud;
                p.Id_centro_salud = cs.Id;

                Doctor doc = new Doctor();
                doc=cmbDoctor.SelectedItem as Doctor;
                p.Id_doctor = doc.Id;

                Paciente pac = new Paciente();
                pac = cmbPaciente.SelectedItem as Paciente;
                p.Id_paciente = pac.Id;

                if (checkBoxInternar.Checked == true)
                {
                Dominio.Habitacion hab = new Dominio.Habitacion();
                hab = cmbHabitacion.SelectedItem as Dominio.Habitacion;
                p.Id_habitacion = hab.Id;

                p.Fechadealta = MaskedTxtFechaAlta.Text;
                }

                p.Sintomas = txtSintomas.Text;
                p.Tratamiento = txtTratamiento.Text;
                p.Fechaconsulta = labelFecha.Text;
                
                b.InsertConsulta(p);

                if (checkDetPat.Checked == true)
                {
                        int id;
                        /*HACER QUE SE INSERTEN LOS DATOS EN LA RESULTANTE*/
                        listaConsulta.DataSource = b.ActualizarConsulta(); //llena el listbox doctores con todos los doctores
                        listaConsulta.SelectedIndex = listaConsulta.Items.Count - 1; //selecciona el ultimo doctor
                        Consulta Con = new Consulta();
                        Con = listaConsulta.SelectedItem as Consulta; //guarda en la variable Doc, todos los datos del ultimo doctor.
                        for (int x = 0; x <= listBoxSelectPatologia.Items.Count - 1; x++)//for del insert
                        {
                            listBoxSelectID.SelectedIndex = x;
                            id = Convert.ToInt32(listBoxSelectID.SelectedItem);
                            b.Insert_PAT_CONSU(Con, id); //codigo insert, parametros: (Doc, id); se le pasa Doc entero para especificar el ID en el broker
                        }
                    
                }
              
                MessageBox.Show("Se ha insertado exitosamente", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkDetPat.Checked == true)
                groupBox2.Enabled = true;
            else
                groupBox2.Enabled = false;
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            if (cmbPatologia.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un item a insertar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cmbIDPat.SelectedIndex = cmbPatologia.SelectedIndex; //Iguala los index de los dos combobox para que puedan agregarse simultaneamente

                listBoxSelectPatologia.Items.Add(cmbPatologia.SelectedItem); //Agrega al listbox, el item del combobox
                cmbPatologia.Items.Remove(cmbPatologia.SelectedItem); //remueve del combobox, el item agregado

                listBoxSelectID.Items.Add(cmbIDPat.SelectedItem); //Agrega al listbox, el item del combobox
                cmbIDPat.Items.Remove(cmbIDPat.SelectedItem); //remueve del combobox, el item agregado
            }
        }

        private void botonQuitar_Click(object sender, EventArgs e)
        {
            if ((listBoxSelectPatologia.SelectedIndex < 0) || (listBoxSelectPatologia.SelectedItem == null))
            {
                MessageBox.Show("Seleccione un item a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listBoxSelectID.SelectedIndex = listBoxSelectPatologia.SelectedIndex; //Iguala los index de los dos listbox para que puedan borrarse simultaneamente

                cmbPatologia.Items.Add(listBoxSelectPatologia.SelectedItem); //Agrega al combobox el item seleccionado del listbox
                listBoxSelectPatologia.Items.Remove(listBoxSelectPatologia.SelectedItem); //Remueve el item seleccionado del listbox

                cmbIDPat.Items.Add(listBoxSelectID.SelectedItem); //Agrega al combobox el item seleccionado del listbox
                listBoxSelectID.Items.Remove(listBoxSelectID.SelectedItem); //Remueve el item seleccionado del listbox 
            }
        }

      

     
        
    }
}
