using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Polimor2
{
    class Program
    {
        static void Main(string[] args)
        {



            Trapeze t = new Trapeze(23,4,3,57,7,23,2,14);
            t.ToString();
            Console.WriteLine("Периметр трапецiї =" + t.Perimetr());
            t.isTrapez();
           Console.WriteLine(t.Area());
            
            
            Console.WriteLine("\nВведiть кiлькiсть трапецiй");
            int size = int.Parse(Console.ReadLine());
            double sum = 0;
            double middle = 0;
            Trapeze[] mas = new Trapeze[size];
            Random r = new Random();
            for (int i = 0; i < size; i++)
            {
                mas[i] = new Trapeze(r.Next(20), r.Next(20), r.Next(20), r.Next(20), r.Next(20), r.Next(20), r.Next(20), r.Next(20));
                sum += mas[i].Area();
              }

            middle = sum / size;
            Console.WriteLine("Середня площа : "+Math.Round(middle,3) );
            for (int i = 0; i < size; i++)
            {
                if (mas[i].Area() > middle)
                {
                    Console.WriteLine(mas[i].Area());
                }
            }
            Console.ReadKey();




        }
    }
}
