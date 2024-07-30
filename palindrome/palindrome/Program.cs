using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    class Program
    {
        public static void Main()
        {
            int n, rem, rev = 0,temp;
            Console.WriteLine("Enter a number:");
            n = Convert.ToInt32(Console.ReadLine());
            temp = n;
            while(n>0)
            {
                rem = n % 10;
                rev = rev * 10 + rem;
                n = n / 10;
            }
            if(temp==rev)
            {
                Console.WriteLine("{0} is palindrome", temp);
            }
            else
            {
                Console.WriteLine("{0} is not palindrome", temp);
            }
            Console.ReadKey();
        }
    }
}
