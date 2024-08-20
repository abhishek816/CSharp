using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace hash_table
{
    class Program
    {
        public static void Main()
        {
            Hashtable ht = new Hashtable();
            ht.Add(4, "red");
            ht.Add(1, "green");
            ht.Add(3, "blue");
            ht.Add(2, 55);
            foreach(DictionaryEntry i in ht)
            {
                Console.WriteLine(i.Key + " " + i.Value);
            }
            Console.WriteLine(ht[4]);
            //sorted list
            Console.WriteLine("Sorted List:");
            SortedList sl = new SortedList();
            sl.Add(1, "red");
            sl.Add(4, "green");
            sl.Add(3, "blue");
            sl.Add(2, "yellow");
            foreach (DictionaryEntry i in sl)
            {
                Console.WriteLine(i.Key + " " + i.Value);
            }
            Console.WriteLine(sl[2]);
            Console.ReadKey();
        }
    }
}
