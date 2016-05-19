using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace menu
{
    class Program
    {
           
        
        static void clrpar()
        {
            int x, y;    // para for de limpiar

            for (y = 7; y <= 20; y++)
            {
                for (x = 0; x <= 79; x++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine(" ");    //limpiando la parte central de pantalla
                }
            } 
 
        }
        static int cuadro(int x1, int x2, int y1, int y2)
        {
            int x, y;
            for (x = x1; x <= x2; x++)
            {
                Console.SetCursorPosition(x, y1);
                Console.Write("*");
                Console.SetCursorPosition(x, y2);
                Console.Write("*");
                Thread.Sleep(1);
            }
            for (y = y1; y <= y2; y++)
            {
                Console.SetCursorPosition(x1, y);
                Console.Write("*");
                Console.SetCursorPosition(x2, y);
                Console.Write("*");
                Thread.Sleep(1);
            }
            return 0;
        }
        static void ascii()
        {
            int x = 0, y = 0;
            Console.Clear();
            for (int i = 0; i <= 255; i++)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine("{0}= {1}", i, (char)i);
                y++;
                if (y == 24)
                { x += 7; y = 0; }

            }
            Console.ReadKey();
        }

        static void binario()
        { 
            int num, alm, j, i;
            int[] bin = new int[15];            
 
	        clrpar();
	        Console.SetCursorPosition(10,9);
            Console.Write("Digite el numeto que quiere convertir a binario: ");
            num= int.Parse(Console.ReadLine());
	        alm=num;
            for(i=0;i<=14;i++) 
            { 
              bin[i]=num%2; 
              num=num/2; 
            } 
            Console.SetCursorPosition(10,11);
            Console.Write("{0}  en binario es: ",alm);
           for(j=14;j>=0;j--) 
            { 
            Console.Write("{0}",bin[j]); 
            }
           Console.ReadKey();
 
        }
        static void titulo()
        {
            
            
	    Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;
	    cuadro(0,79,0,5);cuadro(0,79,21,23);
        Console.SetCursorPosition(33, 1);
        Console.Write("PROGRAMACION 2");
        Console.SetCursorPosition(48, 22);
        Console.Write("Willson Neris Acevedo Sanchez");
        Console.SetCursorPosition(8, 2);
        Console.Write(" 2012-1993                                        <ESC  = salir>");
        Console.SetCursorPosition(37, 4);
        Console.Write("MENU");


        Console.SetCursorPosition(10, 9); Console.Write("  Tabla del Codigo ascii");
        Console.SetCursorPosition(10, 10); Console.Write("  Maximo comun divisor y minimo comun multiplo");
        Console.SetCursorPosition(10, 11); Console.Write("  Conversor de decimal a binario");
        Console.SetCursorPosition(10, 12); Console.Write("  Tipo de Triangulo");
        Console.SetCursorPosition(10, 13); Console.Write("  Calculador de unidades, decenas, centena y millares");
        Console.SetCursorPosition(10, 14); Console.Write("  Salir");


        Console.SetCursorPosition(10, 22); Console.Write("   estado: ");
        
         }

        static void mcmmcd()
        {
	    float num1,num2,a,b,MCM;
	    clrpar();
	do{
        Console.SetCursorPosition(10, 9);
        Console.Write("Digite un numero: ");  num1=float.Parse(Console.ReadLine());
        Console.SetCursorPosition(10, 10);
        Console.Write("Digite el otro numero: "); num2 = float.Parse(Console.ReadLine());
		if ((num1>0) && (num2>0)) {break;}
        Console.SetCursorPosition(10, 9);
        Console.Write("                     ");
        Console.SetCursorPosition(10, 10);
        Console.Write("                         ");
        Console.SetCursorPosition(10, 9);
        Console.Write("ERROR FATAL! los numero no pueden ser igual o menor que 0");
		Thread.Sleep(1500);
        Console.SetCursorPosition(10, 9);
        Console.Write("                                                          ");

	}while((num1<=0) && (num2<=0));

	a=num1;//almacena las variables
	b=num2;

	do{
		if (a>b)
		{
			a-=b;
			b=b;
		}
		if (a<b)
		{
			a=a+b;
			b=a-b;
			a=a-b;
		}

	}while(a!=b);

    Console.SetCursorPosition(10, 11);
    Console.Write("El MCD entre {0} y {1} es: {2}", num1, num2, a);
	MCM=num1*num2/a;
    Console.SetCursorPosition(10, 12);
    Console.Write("El MCM entre {0} y {1} es: {2}", num1, num2, MCM);
	Console.ReadKey();
}
       static void udcm()

{
	
	int valor, uni=0, dec=0, cent=0, mill=0;
	clrpar();
	do{
	Console.SetCursorPosition(10,9);	
	Console.Write("Calculador de unidades, decenas, centena y millares ");
	Console.SetCursorPosition(10,10);
	Console.Write("Digite el valor que desee: ");
    valor = int.Parse(Console.ReadLine());
	if (valor>9999) 
	 {
	  Console.SetCursorPosition(10,10);
	  Console.Write("ERROR intente de nuevo con valores inferiores a 999,999");
      Thread.Sleep(2500);
      Console.SetCursorPosition(10,10);
	  Console.Write("                                                       ");
     }
    
	} while (valor>9999);
	
	if (valor>1000)	
	{
	  uni=valor;
	  dec=valor/10;
	  cent=valor/100;
	  mill=valor/1000;
	}
	if ((valor<1000)&& (valor>100))
	{
	  uni=valor;
	  dec=valor/10;
	  cent=valor/100;
	}
	
	if (valor<100)
	{
	  uni=valor;
	  dec=valor/10;
	}
	if (valor<10)	
	{
	  uni=valor;
	}
	Console.SetCursorPosition(10,13);
	Console.Write("Hay: {0} unidades, {1} decenas, {2} centenas, {3} millares.", uni, dec, cent, mill);

	Console.ReadKey();
	
}
       static void triangulo()
{
	int a=0,b=0,c=0;

	clrpar();
    Console.SetCursorPosition(10, 9);
    Console.Write("Lado A: ");
    a=int.Parse(Console.ReadLine());
    Console.SetCursorPosition(10, 10);
    Console.Write("Lado B: ");
    b=int.Parse(Console.ReadLine());
    Console.SetCursorPosition(10, 11);
    Console.Write("Lado C: ");
    c = int.Parse(Console.ReadLine());
    Console.SetCursorPosition(10, 13);
	if ((a==b) && (b==c) && (c==a))
    {
        Console.Write("El triangulo es: Equilatero");
    }
    if ((a==b && c!=a) || (a==c && b!=c) || (a!=b && b==c))
  //if ((a==b && b==a && c!=a) || (a==c && b!=c && c==a) || (a!=b && b==c && c==b))
    {
        Console.Write("El traingulo es: Escaleno");
    }
     if ((a!=b && b!=c && c!=a))
    {
        Console.Write("El triangulo es: Is%csceles", 162);
    }
    Console.ReadKey();
}

        static void Main(string[] args)
        {
            int f = 9, c = 7;
            ConsoleKeyInfo t;
            int cod=1;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            titulo();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(c, f - 1); Console.Write("   ");
            Console.SetCursorPosition(c, f); Console.Write("{1}{0}", (char)16, (char)173);
            Console.SetCursorPosition(c, f + 1); Console.Write("   ");
            Console.ForegroundColor = ConsoleColor.White;
            
            
            do
            {
                t=Console.ReadKey();

                switch (t.Key)
                {
                    case ConsoleKey.UpArrow://72
                        {
                            if (f > 9)
                            { f--; }
                            else
                            {
                                Console.SetCursorPosition(c, f); Console.Write("   ");
                                f = 14;
                            } //cambiar si se agregan mas opciones
                            break;
                        }
                    case ConsoleKey.DownArrow://80
                        {
                            if (f < 14)//cambiar si se agregan mas opciones
                            { f++; }
                            else
                            {
                                Console.SetCursorPosition(c, f); Console.Write("   ");
                                f = 9;
                            }
                            break;
                        }
                    case ConsoleKey.Enter:
                        {
                            if (f == 9)
                            {
                                Console.SetCursorPosition(21, 22); Console.Write(" 1 opcion ascii");
                                Thread.Sleep(1000);
                                Console.SetCursorPosition(21, 22); Console.Write("                   ");
                                ascii();
                                titulo();
                            }
                            if (f == 10)
                            {
                                Console.SetCursorPosition(21, 22); Console.Write(" 2 opcion mcmmcd");
                                Thread.Sleep(1000);
                                Console.SetCursorPosition(21, 22); Console.Write("                   ");
                                mcmmcd();
                                titulo();
                            }
                            if (f == 11)
                            {
                                Console.SetCursorPosition(21, 22); Console.Write(" 3 opcion binario");
                                Thread.Sleep(1000);
                                Console.SetCursorPosition(21, 22); Console.Write("                   ");
                                binario();
                                titulo();
                            }
                            if (f == 12)
                            {
                                Console.SetCursorPosition(21, 22); Console.Write(" 4 opcion triangulo");
                                Thread.Sleep(1000);
                                Console.SetCursorPosition(21, 22); Console.Write("                   ");
                                triangulo();
                                titulo();
                            }
                            if (f == 13)
                            {
                                Console.SetCursorPosition(21, 22); Console.Write(" 5 opcion udcm");
                                Thread.Sleep(1000);
                                Console.SetCursorPosition(21, 22); Console.Write("                   ");
                                udcm();
                                titulo();
                            }
                            if (f == 14)
                            {
                                Console.SetCursorPosition(21, 22); Console.Write(" saliendo...");
                                Thread.Sleep(1000);
                                Console.SetCursorPosition(21, 22); Console.Write("                   ");
                                cod = 27;
                            }
                            break;
                    }
                    case ConsoleKey.Escape:
                        { cod = 27; break; }
                    default:
                        {
                            /*gotoxy(21,14);printf(" Comando invalido");
                            delay(1000);
                            gotoxy(21,14);printf("                   ");*/
                            break;
                        }
                }
                
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(c, f - 1); Console.Write("   ");
                Console.SetCursorPosition(c, f); Console.Write("{1}{0}", (char)16, (char)173);
                Console.SetCursorPosition(c, f + 1); Console.Write("   ");
                Console.ForegroundColor = ConsoleColor.White;
            } while (cod != 27);          
                        
        }
    }
}
