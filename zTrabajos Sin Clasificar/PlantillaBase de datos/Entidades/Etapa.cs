using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    class Etapa
    {
        int id_etapas;

        public int Id_etapas
        {
            get { return id_etapas; }
            set { id_etapas = value; }
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
        string estado;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        string fecha_inicio;

        public string Fecha_inicio
        {
            get { return fecha_inicio; }
            set { fecha_inicio = value; }
        }
        string fecha_final;

        public string Fecha_final
        {
            get { return fecha_final; }
            set { fecha_final = value; }
        }
        int id_proyecto;

        public int Id_proyecto
        {
            get { return id_proyecto; }
            set { id_proyecto = value; }
        }
        public override string ToString()
        {
            return id_etapas.ToString();
        }
    }
}
