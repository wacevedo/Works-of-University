using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace NumeroLed
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, c, f, g, p;
            string num, cant;
            string[] numero;        //declaracion del arreglo tipo string 
            numero = new string[10]; //Cuantos elementos tiene el arreglo
            numero[0]= "1111110";
            numero[1]= "0011000";
            numero[2]= "0110111";
            numero[3]= "0111101";
            numero[4]= "1011001";
            numero[5]= "1101101";
            numero[6]= "1101111";
            numero[7]= "0111000";
            numero[8]= "1111111";
            numero[9]= "1111101";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            do {
                x = 0; y = 0;
                c = 0; p = 0;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(10,2); Console.Write("Digite un numero << -1 para salir >>: "); cant = Console.ReadLine();
                Console.Clear();
                if (cant == "-1")
                   break;
               for (g = 0; g <= cant.Length-1; g++)
                {
                    c = Convert.ToInt32(cant[g]-'0');   //porque C# representa los numeros por su valor Ascii al restarle el valor 
                                                        //ascii del 0 (que es 48) da el numero correcto. 
                    if ((c >= 0) && (c <= 9))
                    {
                        num = numero[c];
                        for (f = 0; f <= 6; f++)
                        {
                            if ((f == 0) || (f == 1))
                            {
                                x = 5;
                                y = 4;
                            }
                            if (f == 2)
                            {
                                x = 10;
                                y = 4;
                            }
                            if (f == 3)
                            {
                                x = 10;
                                y = 8;
                            }
                            if (f == 4)
                            {
                                x = 5;
                                y = 12;
                            }
                            if ((f == 5) || (f == 6))
                            {
                                x = 5;
                                y = 8;
                            }
                            if (num[f] == '0')
                                Console.ForegroundColor = ConsoleColor.Black;
                            else
                                Console.ForegroundColor = ConsoleColor.Green;

                            if ((f == 1) || (f == 4) || (f == 6)) //el 1, el 4 y el 6
                                horizontal(p + x, y);
                            else
                                vertical(p + x, y);
                        } //FOR F
                    }
                    p = p + 7;
                } //For G
             }while(cant!="-1"); //Fin del do
          }
        //Mis funciones
   public static void horizontal(int col, int fila)
     {
        int x1;
       
         for (x1=1; x1<=4; x1++)
         {
           Console.SetCursorPosition(col+x1,fila);Console.Write('█');
           Thread.Sleep(5);
         }
     }

   public static void vertical(int col, int fila)
     {
       int y1;
       for (y1 = 1; y1 <= 3; y1++)
       {
           Console.SetCursorPosition(col, fila + y1); Console.Write('█');
           Thread.Sleep(5);
       }
     }
   }
}
