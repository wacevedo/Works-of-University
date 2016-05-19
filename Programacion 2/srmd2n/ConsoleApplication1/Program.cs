using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0, suma,resta,mult,divid;
            string dato;

                
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(1, 5);
                Console.Write("inserte el primer numero: ");
                dato = Console.ReadLine();                
                n1 = int.Parse(dato);

                Console.SetCursorPosition(1,6);
                Console.Write("inserte el segundo numero: ");
                dato = Console.ReadLine();
                n2 = int.Parse(dato);

                suma = n1 + n2;
                resta = n1 - n2;
                mult = n1 * n2;
                divid = n1 / n2;

                Console.SetCursorPosition(1, 8);
                Console.WriteLine("{0}+{1}={2}", n1, n2, suma);
                Console.WriteLine("{0}-{1}={2}", n1, n2, resta);
                Console.WriteLine("{0}*{1}={2}", n1, n2, mult);
                Console.WriteLine("{0}/{1}={2}", n1, n2, divid);

                Console.ReadKey();
            
        }
    }
}
