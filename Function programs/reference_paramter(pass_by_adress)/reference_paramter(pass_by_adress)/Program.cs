using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reference_paramter_pass_by_adress_
{
    class A
    {
        public void display(ref int x)
        {
            x = x + 10;
            Console.WriteLine("Value inside functiion is{0}", x);
        }

        public static void Main()
        {
            int x = 10;
            A obj = new A();
            obj.display(ref x);
            Console.WriteLine("Value inside main function is{0}", x);
            Console.ReadKey();
        }
    }
}
