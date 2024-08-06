using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twodimensionalarray
{
    class Program
    {
        public static void Main()
        {
            int r,c;
            Console.WriteLine("Enter the row elements");
            r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the column elements");
            c = Convert.ToInt32(Console.ReadLine());
            int[,] ar = new int[r, c];
            Console.WriteLine("Enter the array elements:");
            for(int i=0;i<r;i++)//row index
            {
                for(int j=0;j<c;j++)
                {
                    ar[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Array Elements are:");
            for(int i=0;i<r;i++)
            {
                for(int j=0;j<c;j++)
                {
                    Console.Write(ar[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
