using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Polimor1
{
    class Fractions: Integer
    {
        private int numerator;
        private int denominator;
        
        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }

        public int Denominator
        {
            get { return denominator; }
            set { denominator = value; }
        }

        public void print()
        {
            Console.WriteLine("The value of the fraction is {0}/{1}", numerator, denominator);
        }
    }
}
