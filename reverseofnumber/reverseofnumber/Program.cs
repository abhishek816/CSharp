using System;

namespace reverseofnumber
{
    class Program
    {
        public static void Main()
        {
            int n, rem, rev = 0;
            Console.WriteLine("Enter a number:");
            n = Convert.ToInt32(Console.ReadLine());
            while(n>0)
            {
                rem = n % 10;
                rev = rev* 10 + rem;
                n = n / 10;
            }
            Console.WriteLine("Reversed number is {0}", rev);
            Console.ReadKey();
        }
    }
}
