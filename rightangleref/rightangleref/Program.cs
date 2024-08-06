using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rightangleref
{
    class Program
    {
       public static void Main()
        {
            int n;
            Console.WriteLine("Enter the limit:");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=n;i++)//row iteration
            {
                for(int j=1;j<=n-i;j++)//space printing
                {
                    Console.Write(" ");
                }
                for(int k=1;k<=i;k++)//* printing
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
