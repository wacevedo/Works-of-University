using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;

namespace ConsoleApplication1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //ConsoleKeyInfo tecla;
            //int teclado;
            ArrayList lstNumbers = new ArrayList();
            // The Random class will be used to generate numbers
            Random rnd = new Random();
            int number;
            int max = 10;

            do
            {
                
                //tecla = Console.ReadKey();

                //teclado = Convert.ToInt32(Console.ReadLine());
                number = rnd.Next(0, max);
                if (lstNumbers.Count == max)
                {
                    lstNumbers.Clear();
                    Console.WriteLine("De nuevo");
                }

                // If the newly generated number in not yet in the list...
                if (!lstNumbers.Contains(number))
                {
                    // ... add it
                    lstNumbers.Add(number);
                    Console.WriteLine("{0}", (int)number);
                    Console.ReadKey();
                                        
                }

            } while (true);
        }
    }
}
