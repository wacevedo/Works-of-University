using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            float valor, prom, count=0, acum=0;

            Console.Clear();
            do
            {
                Console.Write("inserte un valor: ");
                valor = int.Parse(Console.ReadLine());
                if(valor==0)
                { break; }
                acum = acum + valor;
                count++;

            } while (valor != 0);
            Console.WriteLine();
            prom = acum / count;
            Console.WriteLine("Su promedio es: {0}", prom);
            Console.ReadKey();

        }
    }
}
