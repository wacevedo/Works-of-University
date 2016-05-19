using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            double anoact = 0, anonac = 0, ano = 0, mes = 0, sem = 0, dias = 0, horas = 0;
            Console.Clear();
            Console.SetCursorPosition(1, 5); Console.Write("Digite el ano actual: ");
            anoact=double.Parse(Console.ReadLine());
            Console.SetCursorPosition(1, 6); Console.Write("Digite el ano de nacimiento: ");
            anonac=double.Parse(Console.ReadLine());
            ano = anoact - anonac;
            mes = 12 * ano;
            sem = 52.14 * ano;
            dias = 365 * ano;
            horas = 8765.812 * ano;

            Console.SetCursorPosition(1, 9); Console.Write("Su edad en año: {0}", ano);
            Console.SetCursorPosition(1, 10); Console.Write("Su edad en meses: {0}", mes);
            Console.SetCursorPosition(1, 11); Console.Write("Su edad en semana: {0}", sem);
            Console.SetCursorPosition(1, 12); Console.Write("Su edad en dias: {0}", dias);
            Console.SetCursorPosition(1, 13); Console.Write("Su edad en horas: {0}", horas);
            Console.ReadKey();
        }
    }
}
