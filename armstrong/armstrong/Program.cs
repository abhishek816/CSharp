using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace armstrong
{
    class Program
    {
        public static void Main()
        {
            int n, rem, s = 0, temp;
            Console.WriteLine("Enter the number:");
            n = Convert.ToInt32(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                rem = n % 10;
                s = s + rem * rem * rem;
                n = n / 10;

            }
            if (temp == s)

            {
                Console.WriteLine("The number is armstrong:{0}", s);
            }
            else
            {
                Console.WriteLine("The number is not armstrong:{0}", s);
            }
            Console.ReadKey();
        }
    }
}
