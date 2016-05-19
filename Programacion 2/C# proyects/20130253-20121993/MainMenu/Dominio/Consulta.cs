using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class Consulta
    {
        int id_consulta;

        public int Id_consulta
        {
            get { return id_consulta; }
            set { id_consulta = value; }
        }
        int id_paciente;

        public int Id_paciente
        {
            get { return id_paciente; }
            set { id_paciente = value; }
        }
        int id_doctor;

        public int Id_doctor
        {
            get { return id_doctor; }
            set { id_doctor = value; }
        }
        int id_habitacion;

        public int Id_habitacion
        {
            get { return id_habitacion; }
            set { id_habitacion = value; }
        }
        string sintomas;

        public string Sintomas
        {
            get { return sintomas; }
            set { sintomas = value; }
        }
        
        string tratamiento;

        public string Tratamiento
        {
            get { return tratamiento; }
            set { tratamiento = value; }
        }
        string fechadealta;

        public string Fechadealta
        {
            get { return fechadealta; }
            set { fechadealta = value; }
        }
        string fechaconsulta;

        public string Fechaconsulta
        {
            get { return fechaconsulta; }
            set { fechaconsulta = value; }
        }
        int id_centro_salud;

        public int Id_centro_salud
        {
            get { return id_centro_salud; }
            set { id_centro_salud = value; }
        }

        public override string ToString()
        {
            return Fechaconsulta;
        }
    }
}
