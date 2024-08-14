using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automatic_property_sum
{
    class A
    {
        public int a
        {
            get;
            set;
        }
        public int b
        {
            get;
            set;
        }
        public static void Main()
        {
            A obj = new A();
            Console.WriteLine("Enter two numbers:");
            obj.a = Convert.ToInt32(Console.ReadLine());
            obj.b = Convert.ToInt32(Console.ReadLine());
            int s = obj.a + obj.b;
            Console.WriteLine("Sum is :{0}", s);
            Console.ReadKey();
        }
    }
    
}
