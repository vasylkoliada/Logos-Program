using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Class2
{
    class Program
    {
        static void Main(string[] args)
        {
            Runner ww = new Runner();
            Runner[] mas = new Runner[5]
            {
                new Runner() {PIB = "Kolya", Time = 34},
                new Runner() {PIB = "Taras", Time = 54},
                new Runner() {PIB = "Sergey", Time = 65},
                new Runner() {PIB = "Misha", Time = 23},
                new Runner() {PIB = "Igor", Time = 45},
            };

          foreach (Runner a in mas)
            {
                Console.WriteLine(a.PIB + " :  " + a.Time);
            }

            Console.WriteLine("\nSprinter is : ");
            int min = 100;
            foreach (Runner r in mas)
            {
                if (r.Time < min) { min = r.Time;}
            }
            foreach (Runner t in mas)
            {
                if (min == t.Time) { Console.WriteLine("\n"+t.PIB + " " + min); }
            }

            Console.ReadKey();

        }
    }
}
