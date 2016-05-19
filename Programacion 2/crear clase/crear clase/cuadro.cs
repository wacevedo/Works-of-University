using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace crear_clase
{
    class cuadro
    {
       public cuadro(int x1, int x2, int y1, int y2)
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
            
          }   
    }
}
