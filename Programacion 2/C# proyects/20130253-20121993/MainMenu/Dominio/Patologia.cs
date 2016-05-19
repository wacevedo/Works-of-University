using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class Patologia
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
        string sintomas_usuales;

        public string Sintomas_usuales
        {
            get { return sintomas_usuales; }
            set { sintomas_usuales = value; }
        }
        string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
