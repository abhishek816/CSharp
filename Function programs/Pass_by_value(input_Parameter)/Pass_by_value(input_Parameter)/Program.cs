using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pass_by_value_input_Parameter_
{
    class A
    {
        public void display(int x)
        {
            x = x + 10;
            Console.WriteLine("Value inside functiion is{0}", x);
        }

        public static void Main()
        {
            int x = 10;
            A obj = new A();
            obj.display(x);
            Console.WriteLine("Value inside main function is{0}", x);
            Console.ReadKey();
        }
    }
}
