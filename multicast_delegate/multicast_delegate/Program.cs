using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multicast_delegate
{
    public delegate void del(int a, int b);
    class A
    {
        public void sum(int x,int y)
        {
            Console.WriteLine("Sum is:{0}", x + y);
        }
        public void product(int x,int y)
        {
            Console.WriteLine("Product is:{0}", x * y);
        }
        public static void Main()
        {
            A obj = new A();
            del d = new del(obj.sum);
            d += new del(obj.product);
            d(200, 10);
            Console.ReadKey();
        }
    }
}
