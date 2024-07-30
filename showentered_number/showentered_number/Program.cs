using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace showentered_number
{
    class Program
    {
        public static void Main()
        {
            int n;
            Console.WriteLine("Enter a number:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Integer value is: {0}", n);
            Console.ReadKey();
        }
    }
}
