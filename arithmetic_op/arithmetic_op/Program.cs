using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arithmetic_op
{
    class Program
    {
        public static void Main()
        {
            int a, b;
            Console.WriteLine("Enter a number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum of the numbers :{0}", a + b);
            Console.WriteLine("Difference of the numbers  :{0}", a - b);
            Console.WriteLine("Product of the numbers :{0}", a * b);
            Console.WriteLine("Division of the numbers :{0}", a / b);
            Console.ReadKey();


        }
    }
}
