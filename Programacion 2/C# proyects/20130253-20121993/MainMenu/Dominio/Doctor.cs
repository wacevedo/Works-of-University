using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class Doctor
    {
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        string cedula;

        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        string fechanac;

        public string Fechanac
        {
            get { return fechanac; }
            set { fechanac = value; }
        }

        string sexo;

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
