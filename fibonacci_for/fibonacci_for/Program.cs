using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci_for
{
    class Program
    {
       public static void Main()
        {
            int n, a = 0, b = 1, c;
            Console.WriteLine("Enter the limit");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a);
            Console.WriteLine(b);
            for(int i=3;i<=n;i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
            Console.ReadKey();
        }
    }
}
