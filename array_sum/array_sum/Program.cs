using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_sum
{
    class Program
    {
        public static void Main()
        {
            int n,s=0;
            Console.WriteLine("Enter the limit:");
            n = Convert.ToInt32(Console.ReadLine());
            int[] ar = new int[n];
            Console.WriteLine("Enter the elements:");
            for(int i=0;i<n;i++)
            {
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            for(int i=0;i<n;i++)
            {
                s = s + ar[i];
                
            }
            Console.WriteLine("Sum of elements in the array is:{0}", s);
            Console.ReadKey();
        }
    }
}
