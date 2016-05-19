using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
   
    public class CentroSalud
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
        string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        
        public override string ToString()
        {
            return Nombre;
        }

        

       

    }
}
