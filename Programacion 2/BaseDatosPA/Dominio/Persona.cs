using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class Persona
    {
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        string nombres;

        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        string telefono;

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        string sexo;

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        string estado;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public override string ToString()
        {
            return Nombres+" "+Apellido;
        }
    }
}
