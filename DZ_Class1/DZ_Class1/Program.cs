using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Class1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student();
            Random r = new Random();
            Student s = new Student("Коляда Василь Ігорович", 7 , "Djrpfkmyf 37" , new int[2]);
            s.Print();
             Console.WriteLine(s.Marks);
            s.CalcAvg();
            Console.ReadKey();
        
        }
    }
}
