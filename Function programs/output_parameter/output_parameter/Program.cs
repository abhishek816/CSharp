using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace output_parameter
{
    class A
    {
        public int display(int a,out int b)
        {
            a = a + 100;
            b = a + 100;
            return a;
        }
        public static void Main()
        {
            A obj = new A();
            int a = 100, b, c;
            c = obj.display(a, out b);
            Console.WriteLine("a={0} and b={1}", c, b);
            Console.ReadKey();
        }
    }
}
