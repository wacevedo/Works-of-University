using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    class Profesor
    {
        int id_profesor;

        public int Id_profesor
        {
            get { return id_profesor; }
            set { id_profesor = value; }
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
        string estado;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public override string ToString()
        {
            return id_profesor.ToString();
        }
    }
}
