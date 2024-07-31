using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeusingfor
{
    class Program
    {
        public static void Main()
        {
            int i,n,f=0;
            Console.WriteLine("Enter a number:");
            n = Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=n; i++)
            {
                if (n % i == 0)
                {
                    f = f + 1;
                }
            }
            if(f==2)
            {
                Console.WriteLine("Number is Prime");
            }
            else
            {
                Console.WriteLine("Number is not prime");
            }
            Console.ReadKey();
        }
    }
}
