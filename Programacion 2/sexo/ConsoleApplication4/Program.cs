using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            char sexo;
            string dato;
            int f=0, m=0;

            do{
                Console.SetCursorPosition(0, 0);
                Console.Write("inserte F o M: ");
                dato = Console.ReadLine(); 
                sexo = char.Parse(dato);
                

                if (sexo=='0') break;

                Console.SetCursorPosition(15,0);
                Console.Write("    ");
                Console.SetCursorPosition(15,0);

                if ((sexo=='F') || (sexo=='f'))
                {f++;                  
                }

                if ((sexo=='M') || (sexo=='m'))
                {m++;                  
                }

            } while ((sexo == 'f') || (sexo == 'm'));
            
            Console.WriteLine("Masculinos: {0}",m);
            Console.WriteLine("Femenino: {0}",f);
            Thread.Sleep(1000); //delay
            Console.ReadKey();
           

        }
    }
}
