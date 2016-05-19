using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication6
{
    class Program
    {
        static void Linea(int y1, int y2, int x)
        {
            int y;

            for (y = y1; y <= y2; y++)
            {
                Console.SetCursorPosition(x,y);
                Console.Write("|");
            }
 
        }

        static void Main(string[] args)
        {
            float precio, subtotal,total=0;
            int cantidad=0,num=0,deseo=1,y=4;
            string producto, dato;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            do
            {num++;
                Console.Clear();
              
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("SUPERMERCADO LA SOLUCION");
                Console.WriteLine("No. Factura: {0}", num);
                Console.SetCursorPosition(1,3);
                Console.Write("producto:"); 
                Console.SetCursorPosition(22, 3);
                Console.WriteLine("cantidad:"); 
                Console.SetCursorPosition(34, 3);
                Console.WriteLine("precio:"); 
                Console.SetCursorPosition(45, 3);
                Console.WriteLine("SubTotal:");




                do
                {
                   Linea(3, y, 20);
                   Linea(3, y, 32);
                   Linea(3, y, 43);
                   Console.SetCursorPosition(1, y);
                   producto = Console.ReadLine();
                   if (producto == "0") break;
                   Console.SetCursorPosition(22, y);
                   dato = Console.ReadLine();
                   cantidad = int.Parse(dato);
                   Console.SetCursorPosition(34, y);
                   dato = Console.ReadLine();
                   precio = float.Parse(dato);
                   subtotal = cantidad * precio;
                   Console.SetCursorPosition(45, y);
                   Console.WriteLine("{0}",subtotal);
                   total = total + subtotal;
                   y++;
               }while (producto!="0");
               Console.SetCursorPosition(1, y);
               Console.Write("_____________________________________________________");
               Console.SetCursorPosition(2,y+1);
               Console.WriteLine("El total de la factura es:                 {0}",total);

                 
               Console.SetCursorPosition(10, 16);
                Console.Write("Desea hacer otra factura? <1= si  ; 0 = no> : ");
                dato=Console.ReadLine();
                deseo = int.Parse(dato);
            } while (deseo == 1);


        }
    }
}
