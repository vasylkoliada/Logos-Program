using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ3
{
    internal class IsPersent
    {
        public static void Persent()
        {
            Console.WriteLine("----------Схожiсть матриць--------------");
            Console.WriteLine("Введiть розмiрнiсть мaтриць : ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int[,] start_matrix = new int[x, y];
            int[,] end_matrix = new int[x, y];
            double one_element = 100.0/(x*y);
            double persent = 0;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Random r = new Random();
                    start_matrix[i, j] = r.GetHashCode()%5;
                    Console.Write(start_matrix[i,j] + "  ");
                }
                Console.WriteLine();
            }

           Console.WriteLine("\n");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Random r = new Random();
                    end_matrix[i, j] = r.GetHashCode() % 5;
                    Console.Write(end_matrix[i,j]+ "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                   if( start_matrix[i, j] == end_matrix[i, j])
                    {
                        persent+= one_element;
                    }
                }
            }
            Console.WriteLine("Схожiсть матриць на : " + persent + "%");
        }
    }
}
