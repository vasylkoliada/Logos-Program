using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logos2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введiть перше число:\t ");
            //int n1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введiть перше число :\t ");
            //int n2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введiть змiнну: \t");
            //int zminna = int.Parse(Console.ReadLine());
            //switch (zminna)
            //{
            //    case 1: Console.WriteLine("1 +: \t"+(n1+n2));
            //        break;
            //    case 2:
            //        Console.WriteLine("2 -:\t" + (n1 - n2));
            //        break;
            //    case 3:
            //        Console.WriteLine("3 *:\t" + (n1 * n2));
            //        break;
            //    case 4:
            //        Console.WriteLine("4 /:\t" + (n1 / n2));
            //        break;
            //    default: Console.WriteLine("Брєд");
            //        break;
            //}
            //Console.ReadKey();

            //Console.WriteLine("Введiть рiк:\t ");
            //int n1 = int.Parse(Console.ReadLine());

            //if (n1%4 == 0 && n1%400!=0)
            //{
            //    Console.WriteLine("Високосний ");
            //}
            //else
            //{
            //    Console.WriteLine("Не високосний");
            //}
            //Console.ReadKey();
            //int n1 = int.Parse(Console.ReadLine());
            //int n2 = int.Parse(Console.ReadLine());
            //int n3 = int.Parse(Console.ReadLine());

            //if ((n1 + n2) > n3 && (n3 + n2) > n1 && (n1 + n3) > n2)
            //{
            //    Console.WriteLine("Present");
            //}
            //else
            //{
            //    Console.WriteLine("Error");
            //}
            //Console.ReadKey();
            //int sum = 0;
            //int k = 0;
            //int i;
            //int n1 ;
            //for (i = 0; i < 5; i++)
            //{
            //    n1=int.Parse(Console.ReadLine());
            //    sum += n1;
            //}
            //Console.WriteLine("Середнє значення " + sum/i);
            //Console.ReadKey();

            //int sum = 0;
            //int n1 =1;
            //int k = 0;
            //while (n1 != 0) { 
            //    n1 = int.Parse(Console.ReadLine());
            //    sum += n1;
            //    k++;
            //} 
            //    Console.WriteLine("Середнє значення " + k);
            //Console.ReadKey();

            int n = int.Parse(Console.ReadLine());
            string a ="";
            string b = "                                          ";
            for (int i = 0; i < n; i++)
            {
                for (int j = n/3-1; j >0; j--)
                {
                    b = b.Substring(j);
                 }

                Console.WriteLine((b+(a += "^^")));

            }
            Console.ReadKey();
        }
    }
}
