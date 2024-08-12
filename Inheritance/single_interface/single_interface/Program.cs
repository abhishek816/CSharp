using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace single_interface
{
    interface A
    {
        void sum();
    }
    class B
    {
        public int product(int x,int y)
        {
            int p;
            p = x * y;
            return p;
        }
    }
    class C : B, A
    {

        public void sum()
        {
            int a, b, s;
            Console.WriteLine("Enter two numbers:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            s = a + b;
            Console.WriteLine("Sum is:{0}", s);

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
            Console.WriteLine("The product is:{0}", p);
            Console.ReadKey();

        }
    }
}
