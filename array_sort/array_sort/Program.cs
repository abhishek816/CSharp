using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_sort
{
    class Program
    {
       public static void Main()
        {
            int n,t;
            Console.WriteLine("Enter the Limit:");
            n = Convert.ToInt32(Console.ReadLine());
            int[] ar = new int[n];
            Console.WriteLine("Eenter the array elements:");
            for (int i=0;i<n;i++)
            {
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i=0;i<n;i++)//array edkkan
            {
                for(int j=i+1;j<n;j++)//to check between numbers
                {
                    if(ar[i]>ar[j])
                    {
                        t = ar[i];
                        ar[i] = ar[j];
                        ar[j] = t;
                    }
                }
            }
            Console.WriteLine("Sorted Array:");
            for(int i=0;i<n;i++)
            {
                Console.WriteLine(ar[i]);
            }
            Console.ReadKey();
        }
    }
}
