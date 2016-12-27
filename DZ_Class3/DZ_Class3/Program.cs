using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Class3
{
    class Program
    {
        static void Main(string[] args)
        {
            Prism p = new Prism(34.2, 12, 34, 13.5, 20.4);
            //p.SetSize(567);
            //Console.WriteLine(p.GetSize());
            bool a = false;
            while (!a)
            {
                Console.WriteLine(
                    "Зробiть вибiр:\n 0 - вихiд; 1 - показати висоту призми;\n2 -  показати кiлькiсть бокових граней; 3- показати площу основи;\n4 - показати довжину сторони призми; 5 - показати об'єм призми;\n6 - встановити висоту призми; 7 - встановити довжину сторони призми;\n8 - встановити кiлькiсть граней; 9 - задати площу основи\n >> ");
                int k = int.Parse(Console.ReadLine());
                switch (k)
                {
                    case 0:
                        a = true;  return;
                    case 1:
                        Console.WriteLine(p.GetHeight());
                        break;
                    case 2:
                        Console.WriteLine(p.GetMargin());
                        break;
                    case 3:
                        Console.WriteLine(p.GetArea());
                        break;
                    case 4:
                        Console.WriteLine(p.GetLenght());
                        break;
                    case 5:
                        Console.WriteLine(p.GetSize());
                        break;
                    case 6:
                        p.SetHeight(double.Parse(Console.ReadLine()));
                        Console.WriteLine(p.GetHeight());
                        break;
                    case 7:
                        p.SetLenght(double.Parse(Console.ReadLine()));
                        Console.WriteLine(p.GetLenght());
                        break;
                    case 8:
                        p.SetMargin(int.Parse(Console.ReadLine()));
                        Console.WriteLine(p.GetMargin());
                        break;
                    case 9:
                        p.SetArea(double.Parse(Console.ReadLine()));
                        Console.WriteLine(p.GetArea());
                        break;
                    default:
                        Console.WriteLine("Не правильне число");
                        a = true; return;
                }
            }


            Console.ReadKey();



        }
    }
}
