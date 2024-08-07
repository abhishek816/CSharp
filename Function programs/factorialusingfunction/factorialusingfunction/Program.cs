using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorialusingfunction
{
    class A
    {
        public int fact(int n)
        {
            int p=1;
            for(int i=1;i<=n;i++)
            {
                p = p * i;
                
            }
            return p;

        }
        public static void Main()
        
        {
            int n,f;
            Console.WriteLine("Enter the limit:");
            n = Convert.ToInt32(Console.ReadLine());
            A obj = new A();
            f=obj.fact(n);
            Console.WriteLine("Factorial is:{0}", f);
            Console.ReadKey();

        }
    }
}
