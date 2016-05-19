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
            int op=100;
            
           Console.SetCursorPosition(10,8); Console.WriteLine(" 1- vacio:");
           Console.SetCursorPosition(10,9); Console.WriteLine(" 2- vacio :");
           Console.SetCursorPosition(10,10); Console.WriteLine(" 3- vacio :");
           Console.SetCursorPosition(10,11); Console.WriteLine(" 4- salir:");
           Console.SetCursorPosition(10,13); Console.WriteLine(" Opcion: ");

            do{
                Console.SetCursorPosition(18,13);
                op=int.Parse(Console.ReadLine());

                switch(op)
                {
                    case 1:
                      
                            Console.SetCursorPosition(10, 14);
                            Console.WriteLine("vacio...");
                            break;                       
                    case 2:
                       
                    case 3:
                       
                    case 4:
                            op = 0;
                            break;

                    default:
                            break;
                      
                    
                        
                        
                }



                

  
            }while(op!=0);
            Console.ReadKey();
        }
    }
}
