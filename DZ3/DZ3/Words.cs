using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ3
{
    class Words
    {
        public static void Leters()
        {
            bool polyndrom = false;
            Console.WriteLine("----------------------------Програма зчитування слiв----------------------");
            Console.WriteLine("Введiть слово: ");
            string word = Console.ReadLine();
            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine(word[i] + " ");
            }
           
            Console.WriteLine();
           
            for (int j = word.Length-1 , i = 0; j >= 0 && i<word.Length; --j, ++i)
                {
                    if (word[i] == word[j])
                    {
                        polyndrom = true;
                        Console.WriteLine(word[j] + " = " + word[i]);
                    }
                    else
                    {
                        Console.WriteLine("Не палiндром!"); break;
                    }
                }
            if (polyndrom) {Console.WriteLine("Слово є палiндромом!");  }
        }
    }
}
