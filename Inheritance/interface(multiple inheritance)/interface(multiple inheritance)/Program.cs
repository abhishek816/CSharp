using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_multiple_inheritance_
{
    interface A
    {
        void sum();
    }
    interface B
    {
        int product(int x, int y);

    }
    class C:A,B
    {
        public void sum()
        {
            int a, b, s;
            Console.WriteLine("Enter two numbers:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            s = a + b;
            Console.WriteLine("The sum is {0}:", s);
        }
        public int product(int x,int y)
        {
            int p;
            p = x * y;
            return p;


        }
        public static void Main()
        {
            int x, y, p;
            C obj = new C();
            Console.WriteLine("Enter two numbers:");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            p = obj.product(x, y);
            obj.sum();
            Console.WriteLine("The product is: {0}", p);
            Console.ReadKey();
        }
    }
}

