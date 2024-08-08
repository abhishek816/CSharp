using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace continue_statement
{
    class Program
    {
        public static void Main()
        {
            int a = 0;
            while (a < 5)
            {
                a = a + 1;
                if(a==3)
                {
                    continue;
                }
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
    }
}
