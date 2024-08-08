using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_statement
{
    class Program
    {
        public static void Main()
        {
            int a = 0;
            Console.WriteLine("Enter the option:");
            a = Convert.ToInt32(Console.ReadLine());
            switch(a)
            {
                case 1:Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    goto case 1;
                default:Console.WriteLine("Invalid");
                    break;
            }
            Console.ReadKey();
        }
    }
}
