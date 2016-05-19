using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    class Lenguaje
    {
        int id_lenguaje; 

        public int Id_lenguaje
        {
            get { return id_lenguaje; }
            set { id_lenguaje = value; }
        }
        string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public override string ToString()
        {
            return id_lenguaje.ToString();
        }
    }
}
