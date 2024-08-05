using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace searchinarray
{
    class Program
    {
        public static void Main()
        {
            int a, n,c=0,pos=0;
            Console.WriteLine("Enter the limti:");
            n = Convert.ToInt32(Console.ReadLine());
            int[] ar = new int[n];
            Console.WriteLine("Enter the elements:");
            for(int i=0;i<n;i++)
            {
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter the element to find: ");
            a = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<n;i++)
            {
                if(ar[i]==a)
                {
                    c = c + 1;
                    pos = i;
                }
            }
            if(c>=1)
            {
                Console.WriteLine("Number is found {0} times and position is {1}",c,pos);
            }
            else
            {
                Console.WriteLine("Number not found");
            }
            Console.ReadKey();
        }
    }
}
