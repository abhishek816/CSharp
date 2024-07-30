using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace largestamongtwo
{
    class Program
    {
        public static void Main()
        {
            int a, b;
            Console.WriteLine("Enter first number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            b = Convert.ToInt32(Console.ReadLine());
            if(a>b)
            {
                Console.WriteLine("Number {0} is largest", a);

            }
            else
            {
                Console.WriteLine("Number {0} is largest", b);
            }
            Console.ReadKey();
        }
    }
}
