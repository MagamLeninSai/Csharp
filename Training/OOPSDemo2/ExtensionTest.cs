using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPSDemo2;

namespace OOPSDemo2
{
    class ExtensionTest
    {
        public static void Main()
        {
            int i = 10;
            int j = 20;
            String s = "Lenin sai";
            int c = s.GetWordCount();
            bool res = i.IsGreaterThan(15);
            bool res1 = j.IsGreaterThan(15);
            Console.WriteLine("10 > 15 :" + res + ", 20 > 15 :" + res1+" Word Count :"+c);
            Console.ReadKey();
        }
    }
}
