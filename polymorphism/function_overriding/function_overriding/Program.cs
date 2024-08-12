using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_overriding
{
    class A
    {
        public virtual void display()
        {
            Console.WriteLine("Base class method");
        }

    }
    class B : A
    {
        public override void display()
        {
            Console.WriteLine("Derive class method");
            //base.display();
        }
        public static void Main()
        {
            B obj = new B();
            obj.display();
            Console.ReadKey();
        }
    }
}
