using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternprinting_even
{
    class Program
    {
        public static void Main()
        {
            int n, k = 2;
            Console.WriteLine("Enter the limit:");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(k + " ");
                    k = k + 2;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
