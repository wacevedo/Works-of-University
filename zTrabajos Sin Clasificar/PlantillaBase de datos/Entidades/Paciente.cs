using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
   
        public class Paciente
        {
            int ID_Paciente;

            public int ID_Paciente1
            {
                get { return ID_Paciente; }
                set { ID_Paciente = value; }
            }

            string Nombres;

            public string Nombres1
            {
                get { return Nombres; }
                set { Nombres = value; }
            }

            string Apellidos;

            public string Apellidos1
            {
                get { return Apellidos; }
                set { Apellidos = value; }
            }

            string Cedula;

            public string Cedula1
            {
                get { return Cedula; }
                set { Cedula = value; }
            }

            double Peso;

            public double Peso1
            {
                get { return Peso; }
                set { Peso = value; }
            }

            string TipoSangre;

            public string TipoSangre1
            {
                get { return TipoSangre; }
                set { TipoSangre = value; }
            }

            public override string ToString()
            {
                return Nombres + " " + Apellidos;
            }


        }
    }

