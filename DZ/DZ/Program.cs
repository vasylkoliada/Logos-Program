using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ
{
    class Program
    {
        static void Main()
        {
            
            Console.WriteLine("Введiть оцiнки за предмети");
            Console.WriteLine("Математика = ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Англiйська = ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Бiологiя = ");
            int z = int.Parse(Console.ReadLine());
    
            Console.WriteLine("Середнє арифметичне : "+ (float)(x + y + z) / 3);

            Console.WriteLine("\n");
            Lenght.LenghtRadius();
        
            

        }

    }
}
