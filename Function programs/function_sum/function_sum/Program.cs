using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_sum
{
    class A
    {
        public int sum()
        {
            int a, b, s;
            Console.WriteLine("enter two numbers:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            s = a + b;
            return s;
        }
        public static void Main()
        {
            A obj = new A();
            int s1 = obj.sum();
            Console.WriteLine("Sum is :{0}",s1);
            Console.ReadKey();
        }
    }
}
