using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multilevel_inheritance
{
    class A
    {
        public int a, b;
        public void read()
        {
            Console.WriteLine("Enter two numbers:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
        }
    }
    class B : A
    {
        public int s;
        public void sum()
        {
            s = a + b;
            Console.WriteLine("sum is:{0}", s);
        }
    }
    class C : B
    {
        
        public void avg()
        {
            
            Console.WriteLine("Average is:{0}", s/2);

        }
        public static void Main()
        {
            C obj = new C();
            obj.read();
            obj.sum();
            obj.avg();
            Console.ReadKey();
        }
    }

}
