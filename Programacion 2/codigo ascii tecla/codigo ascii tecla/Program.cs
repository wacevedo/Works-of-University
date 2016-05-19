using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ConsoleKeyInfo tecla;
            char teclado;
            int cod = 1;
            do { Console.Clear();
                //tecla = Console.ReadKey();

                teclado = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("{0}",(int)teclado);
                Thread.Sleep(2500); 
                
            } while (cod != 27);
        }
    }
}
