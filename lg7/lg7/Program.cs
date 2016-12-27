using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lg7
{
    class Program
    {
        static void Main(string[] args)
        {
            LivingPlace l1 = new LivingPlace(43, 2, "erger", 7632);
            l1.Print();
            Villa v1 =new Villa(63,true);
            v1.Print();
            

            HotelRoom h1 = new HotelRoom(10,5,10);
            h1.Print();


            Console.ReadKey();

        }
    }
}
