using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programlineal
{
    public class RegresionLinealSimpleClass
    {
        public double X { get; set; }

        public double Y{ get; set; } 

        public double XY{ get; set; }

        public double X2 { get; set; }

        public double Y2 { get; set; }


        public RegresionLinealSimpleClass(double x, double y, double xy, double x2, double y2)
        {
            this.X = x;
            this.Y = y;
            this.XY = xy;
            this.X2 = x2;
            this.Y2 = y2;
        }
    }
}
