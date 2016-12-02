using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Metods2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("ПРогрмама з змiнним числом пареметрiв функцiї");
            string text = "Oy yes..........Sum>20";
            strParam(text,8,6,5,3,8);
            Console.ReadKey();
        }


        static int strParam(string text,  params int[] mas)
        {
            int sum = 0;
            foreach (var i in mas)
            {
                sum += i;
            }
            if (sum>20)
            Console.WriteLine(text);
            else Console.WriteLine(":( Вибачте але сума переданих параметрiв  =" + sum);
            return 0;
        }
    }
}
