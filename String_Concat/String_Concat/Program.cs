using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Concat
{
    class con
    {
        public static void Main()
        {
            string a,b;
            Console.WriteLine("Enter first name:");
            a = Console.ReadLine();
            Console.WriteLine("Enter second name;");
            b = Console.ReadLine();
            Console.WriteLine("Full name is: {0} {1}",a, b);
            Console.ReadKey();
        }
    }
}
