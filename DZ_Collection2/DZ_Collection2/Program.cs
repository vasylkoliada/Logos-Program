using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Collection2
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue<string> my = new Queue<string>();

            for (int i = 0; i < 5; i++)
            {
                my.Enqueue(Console.ReadLine());
            }
         
            int a = 0;
            foreach (var b in my)
            {
                if (b.Contains("IF"))  a++;
            }
            PrintValues(my);
           
            Console.WriteLine("Cкiльки разiв зустрiчається слово IF = "+a);

        Console.ReadKey();
        }

        public static void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
                Console.Write(" {0}", obj);
            Console.WriteLine();
        }
    }
}
