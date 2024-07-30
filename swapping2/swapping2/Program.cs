using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapping2
{
    class Program
    {
        public static void Main()
        {
            int a, b;
            Console.WriteLine("Enter a number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before Swapping a={0} and b={1}", a, b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("After Swapping a={0} and b={1}", a, b);
            Console.ReadKey();
        }
    }
}
