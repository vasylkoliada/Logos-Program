using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logos7
{
    class Program
    {
        static void Main(string[] args)
        {
            
          //Product p1 = new Product(1245 , 15);
          //  Carrot c1 = new Carrot(13343,12 , 23);
          //  c1.PrintGeneralInfo();
          //  Console.ReadKey();


            Computer c1 = new Computer("Asus", "i7 - 345", true, 34.5f);
           
            Console.WriteLine(c1);
            c1.display.width = 1920;
            c1.display.height = 1080;
            Console.WriteLine(c1.display.Resolution);
            //c1.Price = 15;
            Console.ReadKey();

        }
    }
}
