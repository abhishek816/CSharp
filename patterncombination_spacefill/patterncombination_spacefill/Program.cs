using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterncombination_spacefill
{
    class Program
    {
       public static void Main()
        {
            int n;
            Console.WriteLine("Enter the limit:");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                for(int s=1;s<=n-i;s++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
