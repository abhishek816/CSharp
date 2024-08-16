using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda_expression
{
    class Program
    {
        public static void Main()
        {
            List<int> numbers = new List<int>() { 12, 52, 41, 87, 69, 41 };
            Console.WriteLine("The list:");
            foreach (var v in numbers)
            {
                Console.Write("{0} ", v);
            }
            Console.WriteLine();
            var square = numbers.Select(x => x * x);
            Console.Write("Squares: ");
            foreach(var value in square)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
