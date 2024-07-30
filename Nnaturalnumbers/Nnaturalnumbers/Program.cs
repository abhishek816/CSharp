using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nnaturalnumbers
{
    class Program
    {
        public static void Main()
        {
            int a,n=1;
            Console.WriteLine("Enter a limit:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Natural numbers are:");
            while(n<=a)
            {
                Console.WriteLine(n);
                n = n + 1;
            }
            Console.ReadKey();
        }
    }
}
