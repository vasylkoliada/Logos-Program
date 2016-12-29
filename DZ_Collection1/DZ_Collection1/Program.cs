using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Collection1
{
    class Program
    {
        static void Main(string[] args)
        {
            var St = new Stack<int>();
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                St.Push(r.Next(5));
            }
            int countElements = 0;
            foreach (int s in St)
                Console.Write(s);
            Console.WriteLine("\n");

            for (int i = 0; i < 10; i++)
            {
                if (St.Pop() == 1)
                {
                    countElements++;
                }
            }
            Console.WriteLine("Кiлькiсть 1 = "+ countElements);
            if (countElements % 2 == 0 && countElements!=0) Console.WriteLine("Парна кiлькiсть 1");
            else Console.WriteLine("Непарна кiлькiть 1");
           


            Console.ReadKey();

        }
    }
}
