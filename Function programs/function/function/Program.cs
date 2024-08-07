using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function
{
    class A
    {
        public void normal()
        {
            Console.WriteLine("Normal function");
        }
        public static void afunc()
        {
            Console.WriteLine("Static function");
        }
        public static void Main()
        {
            A ob = new A();
            ob.normal();
            afunc();
            Console.ReadKey();
        }

    }
}
