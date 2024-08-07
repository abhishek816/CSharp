using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_product
{
    class A
    {
        public void product()
        {
            int a, b, p;
            Console.WriteLine("Enter the two numbers:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            p = a * b;
            Console.WriteLine("Product of {0} and {1} is:{2}", a, b,p);
        }
        public static void Main()
        {
            A obj = new A();
            obj.product();
            Console.ReadKey();
        }
    }
}
