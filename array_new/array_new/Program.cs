using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_new
{
    class Program
    {
       public static void Main()
        {
            int n;
            Console.WriteLine("Enter the limit:");
            n = Convert.ToInt32(Console.ReadLine());
            int[] ar = new int[n];
            Console.WriteLine("Enter the array elments:");
            for(int i=0;i<n;i++)//index
            {
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Array elements are:");
            for(int i=0;i<n;i++)
            {
                Console.WriteLine(ar[i]);
            }
            Console.ReadKey();

        }
    }
}
