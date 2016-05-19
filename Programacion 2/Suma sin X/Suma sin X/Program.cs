using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Suma_sin_X
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, num2=0, cont=1,cont2=1; 
           
            Console.Write("Digite el numero del que quiere la table: ");            
            num = int.Parse(Console.ReadLine());
            do
            {             
                
                do{ 
                    num2=num2+num;
                    cont2++;
                }while(cont2==cont);
                
                Console.WriteLine("{0}*{1}={2}", cont, num,num2);
                cont++;
            } while (cont <= 12);

            Console.ReadKey();
        }
    }
}
