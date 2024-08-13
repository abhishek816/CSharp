using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace property_automatic
{
    class A
    {
        private int x;
        public int p1
        {
            set;get;
        }
    }
    class B
    {
        public static void Main()
        {
            A obj = new A();
            obj.p1 = 100;//set
            Console.WriteLine("x={0}", obj.p1);//get
            Console.ReadKey();
        }
    }
}
