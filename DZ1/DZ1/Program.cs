using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("--------------------Цiни за таксi---------------------------");
            Console.WriteLine("Введiть вiдстань в км");
            int road =int.Parse(Console.ReadLine());
            int alarm = 30;
            double price;
            Console.WriteLine("Чи поїздка вiдбувається в ночi? (y/n)");
            char a = char.Parse(Console.ReadLine());
            bool night = false;

            switch (a)
            {
                case 'n':
                    if (road < 10 && road > 0)
                    {
                        price = 5*road + alarm;
                        Console.WriteLine(price);
                    }
                    else if (road >= 10)
                    {
                        price = 4*road + alarm;
                        Console.WriteLine(price);
                    }
                    else if (road > 20)
                    {
                        price = 3*road + alarm;
                        Console.WriteLine(price);
                    }
                    break;

                case 'y':
                    if (road < 10 && road > 0)
                    {
                        price = (5*road + alarm)/2;
                        Console.WriteLine(price);
                    }
                    else if (road >= 10)
                    {
                        price = (4*road + alarm)/2;
                        Console.WriteLine(price);
                    }
                    else if (road > 20)
                    {
                        price = (3*road + alarm)/2;
                        Console.WriteLine(price);
                    }
                    break;
               default: Console.WriteLine("Некоректно введенi данi");
                    break;
             }
       
        }
    }
}

