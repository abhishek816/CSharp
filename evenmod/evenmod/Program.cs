using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenmod
{
    class Program
    {
        public static void Main()
        {
            int n, a = 1;
            Console.WriteLine("Enter a limit:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Even numbers are:");
            while(a<=n)
            {
                if(a%2==0)
                {
                    Console.WriteLine(a);
                }
                a = a + 1;
            }
            

            Console.ReadKey();
        }
    }
}
