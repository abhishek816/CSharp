using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eception_handling
{
    class Program
    {
        public static void Main()
        {
            try
            {
                //int a, b;
                //Console.WriteLine("Enter two numbers:");
                //a = Convert.ToInt32(Console.ReadLine());
                //b= Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("Quotient is:{0}", a / b);
                check(-12);
            }
            catch (Exception ex)

            {
                Console.WriteLine(ex.Message);
            }
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (OverflowException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            finally
            {
                Console.WriteLine("finally block");
            }
            Console.ReadKey();
        }
        public static void check(int ag)
            {
                if (ag <= 0)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be negative");
                }
            
        }
        
          

        
    }
}
