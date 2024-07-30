using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greater3
{
    class Program
    {
       
        public static void Main()
        {
            int a, b, c;
            Console.WriteLine("Enter first number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            b= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number:");
            c= Convert.ToInt32(Console.ReadLine());
            if (a>b)
            {
                if(a>c)
                {
                    Console.WriteLine("{0} is greater", a);
                }
                else
                {
                    Console.WriteLine("{0} is greater", c);
                }
            }
            else if(b>c)
            {
                Console.WriteLine("{0} is greater", b);
            }
            else
            {
                Console.WriteLine("{0} is greater", c);
            }
            Console.ReadKey();
        }
    }
}
