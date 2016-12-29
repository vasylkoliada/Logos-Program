using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Collection3
{
    class Program
    {
        static void Main(string[] args)
        {

            var St = new Stack<int>();

            do
            {
                St.Push(int.Parse(Console.ReadLine()));
            } while (St.Peek() != 0);
            St.Pop();
            int q = 0;
            while (St.Count!=0)
            {
                 q = int.Parse(Console.ReadLine());
                if (St.Pop() == q) {Console.WriteLine("значення симетричне");}
                else
                {
                    Console.WriteLine("не симетричний рядок"); 
                }
               
            }



          
            foreach (int s in St)
                Console.Write(s);
            Console.WriteLine("\n");



            Console.ReadKey();
        }
    }
}
