using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class DictionaryExample1
    {
            static void Main(string[] args)
            {
                /* Student and Roll Number */
                Dictionary<string, int> dictionary =
                   new Dictionary<string, int>();
                dictionary.Add("Raj", 1);
                dictionary.Add("Dipak", 2);
                dictionary.Add("Mike", 3);
                dictionary.Add("Manoj", 4);

                // See whether Dictionary contains this string.
                if (dictionary.ContainsKey("Mike"))
                {
                    int value = dictionary["Mike"];
                    Console.WriteLine(value);
                }

                // See whether it contains this string.
                if (!dictionary.ContainsKey("Mary"))
                {
                    Console.WriteLine(false);
                }
                Console.Read();
            }

    }
}

