﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_combination
{
    class Program
    {
        public static void Main()
        {
            int n;
            Console.WriteLine("Enter the limit:");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i =1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*" + " ");
                    
                }
                Console.WriteLine();
            }
            for(int i=n-1;i>=1;i--)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}