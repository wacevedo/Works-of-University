using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    class Empresa
    {
        int id_empresa;

        public int Id_empresa
        {
            get { return id_empresa; }
            set { id_empresa = value; }
        }
        string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public override string ToString()
        {
            return id_empresa.ToString();
        }
    }
}
