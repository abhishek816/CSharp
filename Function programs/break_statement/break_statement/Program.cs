using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace break_statement
{
    class Program
    {
        public static void Main()
        {
            int a = 1;
            while(a<=5)
            {
                if(a==3)
                {
                    break;
                }
                Console.WriteLine(a);
                a = a + 1;
            }
            Console.ReadKey();
        }
    }
}
