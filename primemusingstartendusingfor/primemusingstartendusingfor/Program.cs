using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primemusingstartendusingfor
{
    class Program
    {
        public static void Main()
        {
            int start, end;
            Console.WriteLine("Enter starting number:");
            start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter ending number:");
            end = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prime Number from {0} to {1} are:", start, end);
            for(int j=start;j<=end;j++)
            {
                int f = 0;
                for(int i=1;i<=j;i++)
                {
                    if (j % i == 0) 
                    {
                        f = f + 1;
                    }
                }
                if(f==2)
                {
                    Console.WriteLine(j);
                }
            }
            Console.ReadKey();
        }
    }
}
