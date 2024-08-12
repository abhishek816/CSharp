using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction_reverse
{
   abstract class A
    {

        public abstract void reverse();
    }
    class B : A
    {
        public override void reverse()
        {
            int n,rem,rev=0;
            Console.WriteLine("Enter the limit:");
            n = Convert.ToInt32(Console.ReadLine());
            while(n>0)
            {
                rem = n % 10;
                rev = rev * 10 + rem;
                n = n / 10;
            }
            Console.WriteLine("Reversed number is:{0}", rev);

            
        }
        public static void Main()
        {
            B obj = new B();
            obj.reverse();
            Console.ReadKey();
        }
    }
}
