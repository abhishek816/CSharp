using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    class A
    {
        public A()//default constructor
        {
            Console.WriteLine("Default constructor");
        }
        public A(int a,int b)//parameterized constructor
        {
            Console.WriteLine("Sum is:{0}", a + b);
        }
        static A()//static constructor
        {
            Console.WriteLine("Static constructor");
        }
        public static void Main()
        {
            A obj = new A();
            A obj1 = new A(2,3);
            Console.ReadKey();
        }
    }
}
