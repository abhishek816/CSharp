using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringreversal
{
    class Program
    {
        public static void Main()
        {
            string s,r="";
            Console.WriteLine("Enter the string");
            s = Console.ReadLine();
            for (int i=s.Length-1;i>=0;i--)
            {
                r = r + s[i];
            }
            Console.WriteLine("Reverse is {0}", r);
            Console.ReadKey();
        }
    }
}
