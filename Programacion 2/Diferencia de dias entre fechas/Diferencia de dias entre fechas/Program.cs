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
            int dia,mes,ano;
            Console.Write("introdusca el # dia de la primera fecha: ");
            dia=int.Parse(Console.ReadLine());
            Console.Write("introdusca el # mes de la primera fecha: ");
            mes=int.Parse(Console.ReadLine());
            Console.Write("introdusca el # año de la primera fecha: ");
            ano=int.Parse(Console.ReadLine());
            DateTime Fecha1 = new DateTime(ano, mes, dia);
            Console.Clear();
            Console.WriteLine("Primera fecha: {0}",Fecha1);

            Console.Write("introdusca el # dia de la segunda fecha: ");
            dia=int.Parse(Console.ReadLine());
            Console.Write("introdusca el # mes de la segunda fecha: ");
            mes=int.Parse(Console.ReadLine());
            Console.Write("introdusca el # año de la segunda fecha: ");
            ano=int.Parse(Console.ReadLine());
            DateTime Fecha2 = new DateTime(ano, mes, dia);
            Console.Clear();
            Console.WriteLine("Primera fecha: {0}", Fecha1);
            Console.WriteLine("Segunda fecha: {0}", Fecha2);

            // Calculo de diferencia de fechas
            TimeSpan dt= Fecha1 - Fecha2;

            // asignacion de diferencia de dias
            int diferenciadia = dt.Days;
            

            Console.WriteLine("La diferencia de dias es: {0} ", diferenciadia);
            Console.ReadKey();
        }
    }
}
