using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class mcmmcd
    {
        private int num1, num2;
        public int MCM, MCD;
        public mcmmcd(int a, int b)
        {
            num1 = a;//almacena las variables
            num2 = b;

            do
            {
                if (a > b)
                {
                    a -= b;
                    //b=b;
                }
                if (a < b)
                {
                    a = a + b;
                    b = a - b;
                    a = a - b;
                }

            } while (a != b);
            MCD = a;
            MCM = num1 * num2 / a;

        }
    }
}
