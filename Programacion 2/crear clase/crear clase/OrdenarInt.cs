using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace crear_clase
{
    class OrdenarInt
    {
        //private int[] t;
        private int x, y,t1; 
        
        public int[] OrdenarInt(int[] array,int limit)
        {
            for (x = 0; x <= limit; x++)
            {
                for (y = 0; y <= limit - 1; y++)
                {
                    t1 = array[y];
                    array[y] = array[y + 1];
                    array[y + 1] = t1; 
                }
            }
            return array;
        }   
    
    } 
}
