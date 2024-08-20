using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringandstringbuilder
{
    class Program
    {
        public static void Main()
        {
            String a = "Good morning";
            String b = "Hello Friend";
            String c = a.Clone().ToString();
            Console.WriteLine(c);
            //compareTo
            Console.WriteLine(a.CompareTo(b));
            Console.WriteLine(a.CompareTo(a));
            //equals
            Console.WriteLine(a.Equals(a));
            Console.WriteLine(a.Equals(b));
            //startswith and endswith
            Console.WriteLine(a.StartsWith("g"));
            Console.WriteLine(b.EndsWith("d"));
            //Contains
            Console.WriteLine(a.Contains("Good"));
            //get type
            Console.WriteLine(b.GetType());
            //index finder
            Console.WriteLine(a.IndexOf("o"));
            Console.WriteLine(a.LastIndexOf("o"));
            //upper and lower case
            Console.WriteLine(b.ToUpper());
            Console.WriteLine(b.ToLower());
            //length of string
            int l = b.Length;
            Console.WriteLine("Length is {0}", l);
            //trim method
            String s = " Haii hello ";
            Console.WriteLine(s.Trim());
            //string insert
            String al = "Good Morning";
            string x = al.Insert(0, "Hai...");
            Console.WriteLine(x);
            //string removal
            String bl = "Hello Friend";
            Console.WriteLine(bl.Remove(7));
            //substring
            Console.WriteLine(al.Substring(2, 5));
            //copy to
            string d = "Hai how are you?";
            char[] ar = new char[15];
            d.CopyTo(0, ar, 0, 6);
            for(int i = 0; i < ar.Length; i++)
            {
                Console.Write(ar[i]);
            }
            //string builder
            StringBuilder sb = new StringBuilder("");
            sb.Append("hello");
            sb.AppendLine();
            sb.Append("Welcome to our program");
            Console.WriteLine(sb);
            //replace
            sb.Replace("o", "O");
            Console.WriteLine(sb);
            //remove
            sb.Remove(1, 13);
            Console.WriteLine(sb);
            Console.ReadKey();
        }
    }
}
