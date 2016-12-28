using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Polimor3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введiть кiлькiсть веkторiв : \n");
            int size = int.Parse(Console.ReadLine());
            Vector[] mas = new Vector[size];

            Random r = new Random();
            for (int i = 0; i < size; i++)
            {
                mas[i] = new Vector(r.Next(10), r.Next(10));
                mas[i].Print();
                Console.WriteLine("Довжина вектора = " + mas[i].LenghtVector());

                

            }
            for (int i = 0; i < size; i++)
            {
                if (mas[i].LenghtVector() > 5) { Console.WriteLine("Довжина бiльша 5 =  " + mas[i].LenghtVector()); }
            }
           
            Console.ReadKey();

        }
    }
}
