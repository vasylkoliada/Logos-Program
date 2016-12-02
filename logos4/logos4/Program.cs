using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logos4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //int d = 9;
            //Console.WriteLine(ABS(d));
            //Console.WriteLine("Введіть значення : ");
            //int x = int.Parse(Console.ReadLine());с
            //Console.WriteLine(Func(x));

            int[] mas = new int[10];
            Random r = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = r.Next(10);
            }


            Console.WriteLine("Сума чисел");
          //  Console.WriteLine(MAS(8));
            int[]s  = new int[3];

            //Can(1);
            //Can(2,3);
            //Can(1,2,3);
            //Can(1, 2, 3,4);
            int max = 0;
            int min ;


            Func(mas,out min,ref max);

            Console.ReadKey();
        }

        static void Can(int a )
        {
         Console.WriteLine("line1  "+ a);   
        }
        static void Can(int a, int b)
        {
            Console.WriteLine("line1 " + a + " line2 " +b);
        }
        static void Can(int a, int b , int c)
        {
            Console.WriteLine("line1 " + a + " line2 " + b + " line3 "+ c);
        }
        static void Can(int a, int b, int c, int d)
        {
            Console.WriteLine("line1 " + a + " line2 " + b + " line3 " + c + " line " +d);
        }

        static void Vvv(params int[] s)
        {
            
            if (s.Length==1)
            {
                Console.WriteLine("line1  ");
            }   
            else if (s.Length==2)
            {
                Console.WriteLine("line2 " );
            }
            else if (s.Length==3)
            {
                Console.WriteLine("line3 ");
            }
            else if (s.Length==4)
            {
                Console.WriteLine("line4 " );
            }
            
        }

        static void Func(int[]mas, out int min , ref int max)
        {
            min = 1000;
            for (int i = 0; i < mas.Length; i++)
            {
                //Console.WriteLine(mas[i]);
                //if (max < mas[i])
                //{
                //    max = mas[i];
                   
                //}
               
                //if (min > mas[i])
                //{
                //    min = mas[i];
                   
                //}
                if (mas[i] < mas[i+1])
                {
                    int tmp = mas[i];
                    mas[i] = mas[i + 1];
                    mas[i + 1] = tmp;

                }
            }
            Console.WriteLine("Найбiльше " + mas[0]);
            Console.WriteLine("Найменше " +  );

        }
        //static int  ABS(int a)
        //{
        //    if (a < 0) return a*(-1);
        //    else  return a;
        //}
        //static float Func(float x)
        //{
        //    if (x < 5 && x > -5)
        //    {
        //        return x*x + 29 - x - 16;
        //    }
        //    else
        //    {
        //        return x*x*x*x - 79;
        //    }

        //}

        private static int SUm(int[] b)
        {
            int sum = 0;
            for (int i = 0; i < b.Length; i++)
            {
                sum += b[i];
            }
            return sum;
        }
        //private static int MAS(int a)
        //{
        //    int sum = 0;
        //    int[] mas = new int[a];
        //    for (int i = 0; i < a; i++)
        //    {
        //        mas[i] = i;
        //        sum += mas[i];
        //        Console.WriteLine(mas[i]);
        //    }
        //    return sum;
        //}
       }


}
