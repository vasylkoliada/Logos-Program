using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Metods
{
   internal   class Program
    {
        public  static  void Main()
        {

            Console.WriteLine("Перший метод");
            int size = int.Parse(Console.ReadLine());
            int value = int.Parse(Console.ReadLine());
            int[] mas = new int[size];
            for (int i = 0; i < size; i++)
            {
                Random a = new Random();
                mas[i] = a.GetHashCode()%5;
                Console.WriteLine(" "+ mas[i]);
            }
           
            Console.WriteLine("Iндекс: "+ Mas(mas, value)); 
            Console.ReadKey();

        }

        public  static  int Mas(int[] r, int q)
        {
            for (int i = 0; i < r.Length; i++)
            {
                if (r[i] == q) return i;
            }
            return -1;
        }
}
}
