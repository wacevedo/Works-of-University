using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programacion2
{
    class Cliente
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
        string cedula;

        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        public override string ToString()
        {
            return Id.ToString() +" "+ Nombre;
        }


    }
}
