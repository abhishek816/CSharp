using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealed_class
{
    sealed class A
    {
        public void display()
        {
            Console.WriteLine("Sealed class method");
        }
    }
    class B
    {
        public static void Main()
        {
            A obj = new A();
            obj.display();
            Console.ReadKey();
        }
    }
}
