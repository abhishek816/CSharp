using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacciseries
{
    class Program
    {
        public static void Main()
        {
            int n, a = 0, b = 1,c;
            Console.WriteLine("Enter the limit:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fibonacci series:");
            Console.WriteLine(a);
            Console.WriteLine(b);
            while(3<=n)
            { 
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
                n = n - 1;


            }
            
            Console.ReadKey();
        }
    }
}
