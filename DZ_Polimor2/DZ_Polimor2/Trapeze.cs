using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DZ_Polimor2
{
    class Trapeze:Figure
    {
        private int x1, y1, x2, y2, x3, y3, x4, y4;
        private double AB, BC, CD, AD , AC, BD ;
        public Trapeze(int _x1,int  _y1,int  _x2, int  _y2,int  _x3, int  _y3, int  _x4, int  _y4)
        {
            x1 = _x1;
            x2 = _x2;
            x3 = _x3;
            x4 = _x4;
            y1 = _y1;
            y2 = _y2;
            y3 = _y3;
            y4 = _y4;


            AB = (double)Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            BC = (double)Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
            CD = (double)Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));
            AD = (double)Math.Sqrt(Math.Pow((x4 - x1), 2) + Math.Pow((y4 - y1), 2));
            AC = (double)Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));
            BD = (double)Math.Sqrt(Math.Pow((x2 - x4), 2) + Math.Pow((y2 - y4), 2));

        }


        public void isTrapez()
        {
            if (Math.Round(AC,3) == Math.Round(BD,3)) { Console.WriteLine("Трапецiя рiвнобiчна");}
            else { Console.WriteLine("Трапецiя не рiвнобiчна");}
        }
        public double  Perimetr()
        {
           return AB + BC + CD + AD;

        }

        public double   Area()
        {
           
            //double s =0;
           return ((AC*BD)*Math.Sin(AC/BD))/2;
            //Console.WriteLine("Площа S = " + s);
         }

        public override  void ToString()
        {
            base.ToString();
            Console.WriteLine("Сторони : \nAB -" + Math.Round(AB,3) + "\nBC - " + Math.Round(BC,3)+ "\nCD - "+ Math.Round(CD,3) + "\nAD - "+Math.Round(AD,3) + "\nДiагоналi :" + "\nAC - "+Math.Round(AC,3) + "\nBD - " + Math.Round(BD,3));
        }

    }
}
