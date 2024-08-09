using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_sum
{
    class A
    {
        public int a, b;
        public void read()
        {
            
            Console.WriteLine("Enter 2 numbers:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

        }
        
    }
    class B : A
    {
        public void sum()
        {
            Console.WriteLine("Sum:{0}", a+b);
            
        }
        public static void Main()
        {
            B obj = new B();
            obj.read();
            obj.sum();
            Console.ReadKey();
        }
    }

}
