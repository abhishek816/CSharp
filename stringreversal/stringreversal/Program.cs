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
            int count = 1;
            Console.WriteLine("Enter the string");
            s = Console.ReadLine();
            for (int i=s.Length-1;i>=0;i--)
            {
                r = r + s[i];
                if (s[i]==' ')
                {
                    count = count + 1;
                }
            }
            Console.WriteLine("Reverse is {0}", r);
            Console.WriteLine("Number of words{0}", count);
            Console.ReadKey();
        }
    }
}
