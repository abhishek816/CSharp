using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace collection_class
{
    class Program
    {
        public static void Main() {
            ArrayList al = new ArrayList();
            al.Add(1002);
            al.Add(200);
            al.Add(300);
            al.Add(400);
           // al.Add("hi");
            Console.WriteLine("Added items:");
            //for(int i = 0; i < al.Count; i++)
            //{
            //    Console.WriteLine(al[i]);
            //}
            foreach(var i in al)
            {
                Console.WriteLine(i);
            }
            al.Insert(1, 1500);
            Console.WriteLine("Inserted items:");
            for(int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }
            al.Sort();
            Console.WriteLine("Sorted items:");
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }
            al.Remove(200);
            Console.WriteLine("Items after remove:");
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }
            al.RemoveAt(2);
            Console.WriteLine("Items after remove:");
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }

            Console.ReadKey();
            
        }


    }
}
