using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            float valor, prom, count = 0, acum = 0,mayor=0,menor=0;

            Console.Clear();
            do
            {
                Console.Write("inserte un valor: ");
                valor = int.Parse(Console.ReadLine());
                if ((mayor==0)&&(menor==0))
                 {
      	           mayor=valor;
      	            menor=valor;
                 }
                if (valor == 0)
                { break; }
                if (valor >= mayor)
                {
                    mayor = valor;
                }

                if (valor <= menor)
                {
                    menor = valor;
                }
                acum = acum + valor;
                count++;

            } while (valor != 0);
            Console.WriteLine();
            prom = acum / count;
            Console.WriteLine("Su promedio es: {0}", prom);
            Console.WriteLine("El numero mayor es: {0}", mayor);
            Console.WriteLine("El numero menor es: {0}", menor);
            Console.WriteLine("La cantidad de numeros insertados es: {0}", count);
            Console.WriteLine("La sumatoria de los numeros es: {0}", acum);
            Console.ReadKey();
        }
    }
}
