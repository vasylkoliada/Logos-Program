using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logos1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hi");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
             
            //Console.WriteLine("Sum of {0} and  {1} = {2}", a , b , a+b);
            //Console.WriteLine("Multiplay of {0} and  {1} = {2}", a, b, a * b);
            //Console.WriteLine("IS_dev of {0} and  {1} = {2}", a, b, (float)a / b);
            //Console.WriteLine("Rizn of {0} and  {1} = {2}", a, b, a - b);
            //Console.WriteLine("Ostacha of {0} and  {1} = {2}", a, b, (float)a%b);
              Console.WriteLine("Enter numb");
            int a = int.Parse(Console.ReadLine());
            int temp = a;
            int b3 = temp%2;
            temp = temp/2;
            int b2 = temp%2;
            temp/=2;
            int b1 = temp%2;
            Console.WriteLine("{0} = {1}  {2}  {3}",a,b1,b2,b3);





            Console.ReadKey();
        }
    }
}
