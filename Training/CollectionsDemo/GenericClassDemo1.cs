using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class Student<TKey,TValue>
    {
        public TKey Key { get; set;}
        public TValue Value { get; set; }
    }
    class GenericClassDemo1
    {
        static void Main()
        {
            Student<int, string> s1 = new Student<int, string>();
            s1.Key = 101;
            s1.Value = "Lenin";

            Student<string, string> s2 = new Student<string, string>();
            s2.Key = "IT";
            s2.Value = "Information Technology";

            Console.WriteLine(s1.Key +" -> "+s1.Value );
            Console.WriteLine(s2.Key +" -> "+s2.Value );
            Console.ReadKey();
        }
    }
}
