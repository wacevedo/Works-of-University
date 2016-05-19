using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programlineal
{
    class CalcularDatosRegresionLinealSimple
    {
        public RegresionLinealSimpleClass RLS;
        
        public CalcularDatosRegresionLinealSimple(double x, double y) 
        {
           double X2 = x * x;
           double Y2 = y * y;
           double XY = x * y;

           RLS = new RegresionLinealSimpleClass(x, y, XY, X2, Y2);
        }

        public double calcularB(double n,double sxy, double sx, double sy, double sx2) 
        {
            double b = (sxy - (sx*sy)) / (n*sx2 - (sx*sx));
            return b;
        }

        public double calcularXpro(double n, double sx) 
        {
            double X = sx / n;
            return X;
        }

        public double calcularYpro(double n, double sy)
        {
            double Y = sy / n;
            return Y;
        }

        public double calcularY(double a, double b, double xpro)
        {
            double Y = a+ b*xpro;
            return Y;
        }

        public double calcularA(double ypro, double xpro, double b)
        {
            double A = ypro-b*xpro;
            return A;
        }

        public double calcularR(double n,double sxy, double sx, double sy, double sx2,double sy2)
        {
            double R = (n*sxy-sx*sy)/((Math.Sqrt(n*sx2-(sx*sx)))*(Math.Sqrt(n*sy2-(sy*sy))));
            return R;
        }

        public double calcularR2(double n, double sxy, double sx, double sy, double sx2, double sy2)
        {
            double R = (n * sxy - sx * sy) / ((Math.Sqrt(n * sx2 - (sx * sx))) * (Math.Sqrt(n * sy2 - (sy * sy))));
            R = R * R;
            return R;
        }
    }
}
