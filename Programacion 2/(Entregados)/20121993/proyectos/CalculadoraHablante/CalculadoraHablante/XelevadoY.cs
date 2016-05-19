using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculadoraHablante
{
    class XelevadoY
    {
        private int x, y, i;
        public int PotencResult;
        public XelevadoY(int num1, int num2)
        {
            x = num1;
            y = num2;
            for ( i = 1; i <= y-1; i++)
            {
                x *= num1;
            }
            PotencResult = x;
        }
    }
}
