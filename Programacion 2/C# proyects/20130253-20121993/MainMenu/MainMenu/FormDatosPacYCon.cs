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
    public partial class FormDatosPacYCon : Form
    {
        public FormDatosPacYCon()
        {
            InitializeComponent();
        }
        Broker b = new Broker();

        public void actualizardatosdeconsulta(Consulta con)
        {
            txtSintomas.Text = con.Sintomas;
            txtTratamiento.Text = con.Tratamiento;
            txtFechaAlta.Text = con.Fechadealta;

            cmbHabitacion.DataSource = b.ActualizarHabitaciondepaciente(con);
            
            listBoxSelectPatologiaId.DataSource = b.BuscarIDsPatologiasdeconsulta(con);
            List<int> ids = new List<int>();
           for(int i=0; i<= listBoxSelectPatologiaId.Items.Count-1; i++)
           {
               int id;
               listBoxSelectPatologiaId.SelectedIndex = i;
               id = Convert.ToInt32(listBoxSelectPatologiaId.SelectedItem);
               ids.Add(id);
           }
           listBoxSelectPatologiaNombre.DataSource = b.Actualizar_NombrePatologia(ids);

        }

       
        
        private void FormDatosPacYCon_Load(object sender, EventArgs e)
        {
            listBoxSelectPatologiaId.Visible = false;
            cmbPaciente.DataSource = b.ActualizarPaciente();//llama pacientes al combobox

            Paciente pac = new Paciente();
            pac = cmbPaciente.SelectedItem as Paciente;
            cmbFecha.DataSource = b.ActualizarConsultadepaciente(pac);//llama las consultas que ha recibido el paciente al combobox
            Consulta cons = new Consulta();
            cons = cmbFecha.SelectedItem as Consulta;
            actualizardatosdeconsulta(cons);//actualiza los detalles de la consulta
            
            
            
        }

        private void cmbPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            Paciente pac = new Paciente();
            pac = cmbPaciente.SelectedItem as Paciente;
            cmbFecha.DataSource = b.ActualizarConsultadepaciente(pac);//actualiza combobox

            Consulta cons = new Consulta();
            cons = cmbFecha.SelectedItem as Consulta;
            actualizardatosdeconsulta(cons);//actualiza los detalles de la consulta
            //listBoxSelectPatologiaId.DataSource = b.BuscarIDsPatologiasdeconsulta(cons);
            actualizardatosdeconsulta(cons);//actualiza los detalles de la consulta
        }

        private void cmbFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            Consulta cons = new Consulta();
            cons = cmbFecha.SelectedItem as Consulta;
            actualizardatosdeconsulta(cons);//actualiza los detalles de la consulta
            //listBoxSelectPatologiaId.DataSource = b.BuscarIDsPatologiasdeconsulta(cons);
            actualizardatosdeconsulta(cons);//actualiza los detalles de la consulta
        }
    }
}
