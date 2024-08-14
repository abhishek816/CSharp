using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    public class gen<X, Y>
    {
        public X a;
        public Y b;
        public gen(X i,Y j)
        {
            a = i;
            b = j;
        }
    }
    class A
    {
        public static void Main()
        {
            int m, n;
            Console.WriteLine("Enter two numbers:");
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            gen<int,int> obj= new gen<int, int>(n,m);
            Console.WriteLine("Sum is:{0}", obj.a + obj.b);
            gen<string, string> obj1 = new gen<string, string>("Hai ", "Welcome");
            Console.WriteLine("String is :{0}", obj1.a + obj1.b);
            Console.ReadKey();

        }
    }
}
