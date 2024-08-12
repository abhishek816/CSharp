using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction_1
{
    abstract class A
    {
        public void display()
        {
            Console.WriteLine("Non abstract method");
        }
        public abstract void absmethod();

    }
    class B : A
    {
        public override void absmethod()
        {
            Console.WriteLine("Abstract method");
        }
        public static void Main()
        {
            B obj = new B();
            obj.display();
            obj.absmethod();
            Console.ReadKey();
        }
    }
}
