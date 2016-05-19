using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace menu_cursor
{
    class Program
    {
        static void Main(string[] args)
        {
            char t;
            int c=10, f=9;
            
            Console.SetCursorPosition(10, 8); Console.WriteLine(" 1- vacio:");
            Console.SetCursorPosition(10, 9); Console.WriteLine(" 2- vacio :");
            Console.SetCursorPosition(10, 10); Console.WriteLine(" 3- vacio :");
            Console.SetCursorPosition(10, 11); Console.WriteLine(" 4- salir:");

            do{
                t=Console.ReadLine().get

            }while(t!='0');

        }
    }
}
