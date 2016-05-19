using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public
        class Habitacion
    {
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        string numero_habi;

        public string Numero_habi
        {
            get { return numero_habi; }
            set { numero_habi = value; }
        }
        int capacidad;

        public int Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }
        string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        int id_centro_salud;

        public int Id_centro_salud
        {
            get { return id_centro_salud; }
            set { id_centro_salud = value; }
        }

        public override string ToString()
        {
            return Numero_habi;
        }
    }
}
