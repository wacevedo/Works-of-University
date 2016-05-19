using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace crear_clase
{
    class Program
    {
        static void Main(string[] args)
        {   Console.Clear();
            cuadro cuad = new cuadro(0,79,5,10);
            Class1 estudiante = new Class1("Willson acevedo","2012-1993");

            /*Console.WriteLine("Introdusca matricula: ");
            estudiante.matricula = Console.ReadLine();

            Console.WriteLine("Introdusca Nombre: ");
            estudiante.nombre = Console.ReadLine();*/


            Console.SetCursorPosition(2, 7);
            Console.WriteLine("Matricula: "+estudiante.matricula);
            Console.SetCursorPosition(2, 8);
            Console.WriteLine("Nombre: " + estudiante.nombre);
            Console.SetCursorPosition(0,11);
            /*int cal;
            cal = int.Parse(Console.ReadLine());
            Class2 nota = new Class2(cal);
            
            Console.WriteLine(" "+nota.letra);*/
            int[] Arreglo = { 8, 4, 1, 7, 2, 9, 3, 5,6 };
            foreach (int mos in Arreglo)
            {
                Console.WriteLine("{0}", mos);
            }
            OrdenarInt Ordint = new OrdenarInt(Arreglo, 8);
            

            Console.ReadKey();            

        }
    }
}
