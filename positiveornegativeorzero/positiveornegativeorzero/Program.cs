using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace positiveornegativeorzero
{
    class Program
    {
        public static void Main()
        {
            int n;
            Console.WriteLine("Enter a number:");
            n = Convert.ToInt32(Console.ReadLine());
            if(n>0)
            {
                Console.WriteLine("{0} is positive", n);
            }
            else if(n<0)
            {
                Console.WriteLine("{0} is negative", n);
            }
            else
            {
                Console.WriteLine("{0} is zero", n);
            }
            Console.ReadKey();

        }
    }
}
