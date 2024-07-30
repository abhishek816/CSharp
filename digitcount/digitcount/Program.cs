using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitcount
{
    class Program
    {
        public static void Main()
        {
            int a;
            Console.WriteLine("Enter a number:");
            a = Convert.ToInt32(Console.ReadLine());
            if (a < 10)
            {
                Console.WriteLine("{0} is single digit", a);
            }
            else if(a>=10 && a<100)
            {
                Console.WriteLine("{0} is double digit", a);
            }
            else if(a>=100 && a<=999)
            {
                Console.WriteLine("{0} is triple digit", a);
            }
            else
            {
                Console.WriteLine("{0} is invalid", a);
            }
            Console.ReadKey();
        }
    }
}
