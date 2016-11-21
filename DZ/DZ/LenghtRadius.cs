using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ
{
    class Lenght
    {

       public  static  void LenghtRadius()
       {
            Console.WriteLine("            Знайти довжину кола       ");
            Console.WriteLine("Введiть радiус");
            float Radius = float.Parse(Console.ReadLine());
            double Pi = 3.14159;
          
            Console.WriteLine("Довжина кола = "+ 2*Pi*Radius);


       }
    }
}
