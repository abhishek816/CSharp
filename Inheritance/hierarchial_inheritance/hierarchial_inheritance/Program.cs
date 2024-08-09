using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hierarchial_inheritance
{
    class A
    {
        public int a, b;
        public void read()
        {
            Console.WriteLine("Enter two numbers:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

        }
    }
    class B : A
    {
        public int s;
        public void sum()
        {
            s = a + b;
            Console.WriteLine("Sum is:{0}", s);
        }
    }
    class C:A
    {
        public void avg()
        {
            Console.WriteLine("Average is:{0}", (a+b) / 2);
        }
        public static void Main()
        {
            B obj1 = new B();
            obj1.read();
            obj1.sum();
            C obj2 = new C();
            obj2.read();
            obj2.avg();
            D obj3 = new D();
            obj3.read();
            obj3.product();
            Console.ReadKey();

        }
    }
    class D : A
    {
        
        public void product()
        {
            Console.WriteLine("Product is:{0}", a * b);
        }
    }
}
