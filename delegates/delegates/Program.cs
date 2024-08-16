using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    //public delegate void del(int a, int b);
    public delegate int del(int a, int b);
    class A
    {
        // public void sum(int x,int y)
        public int sum(int x, int y)
        {
            return (x + y);
            //Console.WriteLine("Sum is :{0}", x + y);
        }
        public static void Main()
        {
            A obj = new A();
            del d = new del(obj.sum);
            int h=d(40, 20);
            Console.WriteLine("Sum is:{0}", h);
            Console.ReadKey();
        }
    }
}
