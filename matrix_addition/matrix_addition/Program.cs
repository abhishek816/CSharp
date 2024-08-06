﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix_addition
{
    class Program
    {
        public static void Main()
        {
            int r1, c1, r2, c2;
            Console.WriteLine("Enter the row limit for first matrix:");
            r1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the column limit for second matrix:");
            c1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the row limit for first matrix:");
            r2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the column limit for second matrix:");
            c2 = Convert.ToInt32(Console.ReadLine());
            int[,] A = new int[r1, c1];
            int[,] B = new int[r2, c2];
            int[,] C = new int[r1, c1];
            if(r1==r2)
            {
                Console.WriteLine("Enter the first array elements:");
                for(int i=0;i<r1;i++)
                {
                    for(int j=0;j<c1;j++)
                    {
                        A[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.WriteLine("Enter the second array elements:");
                for (int i = 0; i < r2; i++)
                {
                    for (int j = 0; j < c2; j++)
                    {
                        B[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
            else
            {
                Console.WriteLine("Matrix is invalid!!");
            }
            Console.ReadKey();
            Console.WriteLine("Sum of matrix is:");
            for (int i=0;i<r1;i++)
            {
                for(int j=0;j<r2;j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                    Console.Write(C[i, j]+" ");
                }
                
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
