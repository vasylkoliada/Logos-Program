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
            Console.WriteLine("Введiть кiлькiсть параметрiв: ");
            int size = int.Parse(Console.ReadLine());
            int[] Count_params = new int[size];
            Console.WriteLine("Введiть параметри: ");

            for (int i = 0; i < size; i++)
            {
                Count_params[i] = int.Parse(Console.ReadLine());
            }

            strParam(text,Count_params);
            Console.ReadKey();

        }

        static void strParam(string text, int[] mas)
        {
            int sum = 0;
            foreach (var i in mas)
            {
                sum += i;
            }
            if (sum>20)
            Console.WriteLine(text);
            else Console.WriteLine(":( Вибачте але сума переданих параметрiв  =" + sum);
        }
    }
}
