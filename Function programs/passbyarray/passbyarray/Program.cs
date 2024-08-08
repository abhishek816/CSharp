using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passbyarray
{
    class A
    {
        public void display(params int []ar)
        {
            Console.WriteLine("Using for loop=>Array elements are:");
            for(int i=0;i<ar.Length;i++)
            {
                Console.WriteLine(ar[i]);
            }
            Console.WriteLine("Using foreach loop=>Array elemnts are");
            foreach(int j in ar)
            {
                Console.WriteLine(j);
            }
        }
        public static void Main()
        {
            A obj = new A();
            int n;
            Console.WriteLine("Enter the limit");
            n = Convert.ToInt32(Console.ReadLine());
            int[] ar = new int[n];
            Console.WriteLine("Enter the elements:"); ;
            for(int i=0;i<n;i++)
            {
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            obj.display(ar);
            Console.ReadKey();
        }
    }
}
