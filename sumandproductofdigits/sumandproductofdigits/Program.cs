using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumandproductofdigits
{
    class Program
    {
        public static void Main()
        {
            int n, s = 0,rem,p=1;
            Console.WriteLine("Enter the number:");
            n = Convert.ToInt32(Console.ReadLine());
            while(n>0)
            {
                rem = n % 10;
                s = s + rem;
                p = p * rem;
                n = n / 10;
            }
            Console.WriteLine("Sum of digits:{0}", s);
            Console.WriteLine("Product of digits:{0}", p);
            Console.ReadKey();
        }
    }
}
