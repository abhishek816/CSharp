using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nnaturalnousingfor
{
    class Program
    {
        public static void Main()
        {
            int n;
            Console.WriteLine("Enter the limit");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Natural Numbers are:");
            for (int i=1; i<=n;i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
