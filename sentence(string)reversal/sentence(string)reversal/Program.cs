using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sentence_string_reversal
{
    class Program
    {
        public static void Main()
        {
            string s, re = " ";
            Console.WriteLine("Enter a string:");
            s = Console.ReadLine();
            string[] ar = s.Split();
            for (int i=ar.Length-1;i>=0;i--)
            {
                re = re + ar[i] + " ";
            }
            Console.WriteLine("Reversed string:{0}", re);
            Console.ReadKey();
        }
    }
}
