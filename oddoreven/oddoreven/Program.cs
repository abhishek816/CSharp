using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddoreven
{
    class Program
    {
        public static void Main()
        {
            int a;
            Console.WriteLine("Enter the number:");
            a = Convert.ToInt32(Console.ReadLine());
            if (a%2==0)
            {
                Console.WriteLine("{0} is even", a);

            }
            else
            {
                Console.WriteLine("{0} is odd", a);
            }
            Console.ReadKey();
        }
    }
}
