using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapnumber
{
    class Program
    {
        public static void Main()
        {
            int a, b, t;
            Console.WriteLine("Enter a number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before Swapping a={0} and b={1}", a, b);
            t = a;
            a = b;
            b = t;
            Console.WriteLine("After Swapping a={0} and b={1}", a, b);
            Console.ReadKey();
        }
    }
}
