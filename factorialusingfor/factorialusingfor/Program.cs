using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorialusingfor
{
    class Program
    {
        public static void Main()
        {
            int n,i,p=1;
            Console.WriteLine("Enter the number:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Factorial of {0} are:",n);
            for(i=1;i<=n;i++)
            {
                p = p * i;
            }
            Console.WriteLine(p);
            Console.ReadKey();
        }
    }
}
