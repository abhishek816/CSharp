using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partial_class
{
    partial class A
    {
        public string name { set; get; }
    }
    partial class A
    {
        public string phone { set; get; }
        public int age { set; get; }
    }
    partial class A
    {
        public string address { set; get; }
    }
    class B
    {
        public static void Main()
        {
            A obj = new A();
            obj.name = "Abhishek B Kumar";
            obj.age = 20;
            obj.address = "kkkk";
            obj.phone = "963583170";
            Console.WriteLine("Name is:{0}", obj.name);
            Console.WriteLine("Age is:{0}", obj.age);
            Console.WriteLine("Address is:{0}", obj.address);
            Console.WriteLine("Phone is:{0}", obj.phone);
            Console.ReadKey();
        }

    }

}
