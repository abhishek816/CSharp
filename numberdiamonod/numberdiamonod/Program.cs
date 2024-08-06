using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberdiamonod
{
    class Program
    {
        public static void Main()
        {
            int n;
            Console.WriteLine("Enter the limit:");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=n;i++)//to print upper half
            {
                for(int j=1;j<=n-i;j++)
                {
                    Console.Write(" ");
                }
                for(int k=1;k<=i;k++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            for (int i=n-1;i>=1;i--)//to print lower half
            {
                for(int j=1;j<=n-i;j++)
                {
                    Console.Write(" ");
                }
                for(int k=1;k<=i;k++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
