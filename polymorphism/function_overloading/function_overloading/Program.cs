using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_overloading
{
    class A
    {
        public void sum()
        {
            int a, b, s;
            Console.WriteLine("Enter two numbers:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            s = a + b;
            Console.WriteLine("Sum is :{0}", s);
        }
        public int sum(int x,int y)
        {
            return (x + y);
        }
        public double sum(double a,double b)
        {
            return (a + b);
        }
        public static void Main()
        {
            A obj = new A();
            int x, y;
            
            obj.sum();
            Console.WriteLine("Enter two numbers:");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            int s=obj.sum(x, y);
            Console.WriteLine("Sum is :{0}", s);
            double a, b;
            Console.WriteLine("Enter two numbers:");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            double s1=obj.sum(a, b);
            Console.WriteLine("Sum is :{0}", s1);
            Console.ReadKey();
        }
    }
}
