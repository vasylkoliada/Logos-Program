using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Metods3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Програма ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int[,] mas;

          MasCount(out mas, a, b); 
          

            Console.ReadKey();

        }
       static void MasCount( out int[,] mas, int a, int b)
        {
            mas = new int[a, b];
            for (int i = 0; i < a; i++)
           {
               for (int j = 0; j < b; j++)
               {
                   mas[i, j]  = (i*b)+j+1;  
                    Console.Write(mas[i,j] + " ");     
               }
               Console.WriteLine();
          }
           
        }
    }
}
