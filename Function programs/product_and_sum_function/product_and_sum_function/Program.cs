using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product_and_sum_function
{
    class A
    {
        public int sum(int a,int b)
        {
           
           
            return (a+b);
        }
        public void product(int x,int y)
        {
            Console.WriteLine("Product is:{0}", x * y);
        }
        public static void Main()
        {
            int n,m;
            Console.WriteLine("Enter the numbers:");
            n= Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
            
            A obj = new A();
            int c=obj.sum(n, m);
            
            Console.WriteLine("Sum is:{0}", c);
            obj.product(n, m);
            Console.ReadKey();
        }
    }
}
