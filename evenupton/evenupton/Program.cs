using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenupton
{
    class Program
    {
       public static void Main()
        {
            int a, n = 2;
            Console.WriteLine("Enter a limit:");
            a = Convert.ToInt32(Console.ReadLine());
            while(n<=a)
            {
                Console.WriteLine(n );
                n= n + 2;
            }
            Console.ReadKey();
        }

    }
}
