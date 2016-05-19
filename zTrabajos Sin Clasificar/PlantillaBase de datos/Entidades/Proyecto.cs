using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    class Proyecto
    {
        int id_proyecto;

        public int Id_proyecto
        {
            get { return id_proyecto; }
            set { id_proyecto = value; }
        }
        string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        string tipo_proyecto;

        public string Tipo_proyecto
        {
            get { return tipo_proyecto; }
            set { tipo_proyecto = value; }
        }

        string fecha_inicio;

        public string Fecha_inicio
        {
            get { return fecha_inicio; }
            set { fecha_inicio = value; }
        }
        int id_empresa;

        public int Id_empresa
        {
            get { return id_empresa; }
            set { id_empresa = value; }
        }
        string estado;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        string fecha_entrega;

        public string Fecha_entrega
        {
            get { return fecha_entrega; }
            set { fecha_entrega = value; }
        }

        int id_profesor;

        public int Id_profesor
        {
            get { return id_profesor; }
            set { id_profesor = value; }
        }
        public override string ToString()
        {
            return nombre;
        }
    }
}
