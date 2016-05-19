using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    class Estudiante
    {
            int Id_estudiante;

            public int Id_estudiante1
            {
                get { return Id_estudiante; }
                set { Id_estudiante = value; }
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

            string matricula;

            public string Matricula
            {
                get { return matricula; }
                set { matricula = value; }
            }
            int id_proyecto;

            public int Id_proyecto
            {
                get { return id_proyecto; }
                set { id_proyecto = value; }
            }
            public override string ToString()
            {
                return nombre;
            }
        }
}
