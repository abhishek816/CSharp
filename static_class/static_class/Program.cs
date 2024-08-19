using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_class
{
    
        public static class calculator
        {
            public static int max(int[] arrnum)
            {
                int max = 0;
                for (int i = 0; i < arrnum.Length; i++)
                {
                    if (arrnum[i] > max)
                        max = arrnum[i];
                }
                return max;
            }
            public static int min(int[] arrnum)
            {
                int min = arrnum[0];
                for (int i = 0; i < arrnum.Length; i++)
                {
                    if (arrnum[i] < min)
                        min = arrnum[i];
                }
                return min;
            }
        }
        class Program
        { 
            public static void Main()
            {
                int[] num = { 12, 65, 20, 74, 34, 10, 25 };
                int Max = calculator.max(num);
                int Min = calculator.min(num);
                Console.WriteLine("Maximum number is :{0}", Max);
                Console.WriteLine("Minimum number is :{0}", Min);
                Console.ReadLine();

            }
        }
    }

