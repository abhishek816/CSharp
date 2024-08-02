using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alphabetpattern
{
    class Program
    {
        public static void Main()
        {
            int n, k = 65;
            Console.WriteLine("Enter the limit:");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write((char)k + " ");
                    k = k + 1;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            
        }
    }
}
