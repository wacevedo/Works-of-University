using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sesion
{
    class Encdes
    {
        public string encriptar(string texto)
        {
            string te = texto;

            te = te.Replace('a', '1');

            return te;
 
        }


        public string desencriptar(string texto)
        {
            string te = texto;

            te = te.Replace('1', 'a');
          

            return te;

        }

    }
}
