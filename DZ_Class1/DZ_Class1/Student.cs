using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Class1
{
    class Student
    {
        
        public string PIB;
        public int midMark;
        public string adress;
        public int[] Marks { get { return new int[] {5,8,2};}
                               set {}
        }

        public    Student() { }
        public Student(string _PIB, int _midMark, string _adress , int[] _m )
        {
            Marks = _m;
            PIB = _PIB;
            midMark = _midMark;
            adress = _adress;
        }

        
        public void CalcAvg()
        {
            int sum = 0;
            for (int i = 0; i < Marks.Length; i++)
            {
                sum += Marks[i];
            }
            sum /= Marks.Length;
            Console.WriteLine(sum);
        }

        public void Print()
        {
            Console.WriteLine(PIB +" "+ midMark+" " + adress+" ");
        }

    }
}
