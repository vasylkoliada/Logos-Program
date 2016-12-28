using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Polimor3
{
    class Vector
    {
        private int X { get; set; }
        private  int Y { get; set; }


        public Vector(int _X, int _Y)
        {
            X = _X;
            Y = _Y;
        }
        public double  LenghtVector()
        {
            return Math.Round(Math.Sqrt((X*X)+(Y*Y)),3);
        }

        public void Print()
        {
            Console.WriteLine("Вектор : \n" +"X = " +  X +" Y = "+ Y );
        }


    }
}
