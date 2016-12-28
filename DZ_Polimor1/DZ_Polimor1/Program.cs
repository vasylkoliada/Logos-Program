using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Polimor1
{
    class Program
    {
        static void Main(string[] args)
        {
             Fractions me = new Fractions();
            me.Numerator = 1;
            me.Denominator = 3;
            me.print();
            Console.ReadKey();

        }
    }
}
