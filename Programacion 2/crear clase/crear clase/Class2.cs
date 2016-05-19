using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace crear_clase
{
    class Class2
    {
        //public float Primerparcialc, Segundoparcialc, Examenfinalc, Laboratirioc, Trabajoic;
        public int calif;
        
        public string letra,Calificacion;
        public Class2(int calif/*string Primerparcial, string Segundoparcial, string Examenfinal, string Laboratirio, string Trabajoi*/)
        {
            /*this.Primerparcialc = float.Parse(Primerparcial);
            this.Segundoparcialc = float.Parse(Segundoparcial);
            this.Examenfinalc = float.Parse(Examenfinal);
            this.Laboratirioc = float.Parse(Laboratirio);
            this.Trabajoic = float.Parse(Trabajoi);

            Primerparcialc = float.Parse(Primerparcial);
            Segundoparcialc = float.Parse(Segundoparcial);
            Examenfinalc = float.Parse(Examenfinal);
            Laboratirioc = float.Parse(Laboratirio);
            Trabajoic = float.Parse(Trabajoi);

            calif= Primerparcialc + Segundoparcialc + Examenfinalc + Laboratirioc+ Trabajoic;*/
            
            Calificacion = Convert.ToString(calif);
            
            if ((calif >= 70) && (calif <= 79))
            { letra=("su nota es C"); }
            if ((calif < 60))
            { letra = ("su nota es F"); }
            if ((calif >= 80) && (calif <= 89))
            { letra = ("su nota es B"); }
            if ((calif >= 90) && (calif <= 100))
            { letra = ("su nota es A"); }
            if ((calif >= 60) && (calif <= 69))
            { letra = ("su nota es D"); }

        }
    }
}
