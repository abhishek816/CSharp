using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeuptonusingfor
{
    class Program
    {
        public static void Main()
        {
            int n;
            Console.WriteLine("Enter a number:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prime numbers upto {0} are:",n);
            for (int j=1;j<=n;j++)
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
                    Console.WriteLine( j);
                }
                
               
            }
            Console.ReadKey();
        }
    }
}
