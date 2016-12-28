using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Logos10
{


    class SpaceNotFound : ApplicationException
    {
        public SpaceNotFound():base(" SpaceNotFound")
        {
            
        }
   }
   class Program
    {
       static void Main(string[] args)
        {

            //File.Create("E:\\r.txt");

            //File.WriteAllText("E:\\er.txt", "pppp");

            // w.WriteLine("Hello2");
            // w.Close();

            // StreamReader r = new StreamReader(new FileStream("E:\\new_file.txt", FileMode.Open, FileAccess.Read));

            //Console.WriteLine(r.ReadToEnd());
            // r.Close();


            //int num = 1;
            //int resault = 0;
            //try
            //{
            //    Console.WriteLine("print");
            //    num = int.Parse(Console.ReadLine());
            //    if (num > 1999)
            //    {
            //        throw new VeryBadFatalExeptionError();
            //    }
            //    resault = 5/num;
            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine("Error Divide: {0}\nInfo:{1}", "DivideByZeroExeption", e.Message);
            //}
            //catch (Exception e)
            //{
            //    if (e is DivideByZeroException)
            //    {
            //        Console.WriteLine(e.Message);
            //    }
            //    else if (e is VeryBadFatalExeptionError)
            //    {
            //        Console.WriteLine(e.Data["Message"] + "\nStackOverFlow");
            //    }=
            //        Console.WriteLine("Error!");
            //}

            string a = Console.ReadLine();

            FileStream file = new FileStream("E:\\newnew.txt", FileMode.Open, FileAccess.Write);
            StreamWriter w = new StreamWriter(file);
            w.WriteLine(a);
            w.Close();

           StreamReader r = new StreamReader(new FileStream("E:\\newnew.txt", FileMode.Open, FileAccess.Read));


           string[] mas = new string[200];
          
           while (!r.EndOfStream)
           {
               a = r.ReadLine();
               Console.WriteLine(a);
           }

           r.Close();

          
           
            Console.WriteLine("\n"+a);
            int one =0 ;
            int two = 0;
            char t =(char)0;
            bool isfirst = true;
            double rasault = 0;
            for (int i = 0; i < a.Length; i++)
            {
                try
                {

                    if (a[i] == ' ')
                    {

                        if (isfirst)
                        {
                            one = int.Parse(a.Substring(0, i));
                            isfirst = false;
                        }
                        else
                        {
                            t = a[i - 1];
                            two = int.Parse(a.Substring(i + 1, a.Length - i - 1));
                        }
                    }

                }
                catch
                {
                    Console.WriteLine("BomBom4");
                } }
            try
            {


                switch (t)
                {
                    case '+':
                        rasault = one + two;
                        break;
                    case '-':
                        rasault = one - two;
                        break;
                    case '*':
                        rasault = one*two;
                        break;
                    case '/':
                        rasault = one/two;
                        break;

                }
            }
            catch
            {
                Console.WriteLine(" Fatal Error");
               
                return;
            }

            Console.WriteLine("one = " + one + "\naction = " + t + "\ntwo = " + two);
            Console.WriteLine(rasault);


         


   

















            Console.ReadKey();



        }
    }
}
