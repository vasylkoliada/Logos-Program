using System;


namespace DZ3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------Програма для матриць----------------");
            Console.WriteLine("Введiть розмiр матрицi");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            
            int  [ , ] matrix =new int[x , y];
            int hostsum = 0;
            int downsum = 0;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Random r = new Random();
                    matrix[i, j] = r.GetHashCode()%10;
                    Console.Write(matrix[i,j] + "  ");
                    if (i == j)
                    {
                        hostsum += matrix[i,j];
                    }
                   
                }
               Console.WriteLine();
            }
            for (int i = 0, j = y-1; i < x && j>=0; i++, j--)
            {
                    downsum += matrix[i,j];
                   
            }

            Console.WriteLine("Сума по головнi дiагоналi = "+ hostsum);
            Console.WriteLine("Сума по бiчнi дiагоналi = " + downsum);


            Console.WriteLine("\n");

            Words.Leters();
            Console.WriteLine("\n");
            IsPersent.Persent();

            Console.ReadKey();

        }
    }
}
