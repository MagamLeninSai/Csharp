using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    // store data in form of generic key,value pairs
    class DictionaryExample
    {
        static void Main()
        {
            Dictionary<int, String> name = new Dictionary<int, String>();
            name.Add(101,"Raj");
            name.Add(102,"Lenin");
            name.Add(103,"Mike");
            name.Add(104,"John");
            name.Add(105,"Ravi");
            foreach (KeyValuePair <int,String > kv in name) {
                Console.WriteLine(kv.Key +" - "+kv.Value);
            }
            Console.WriteLine(name[102]);  //Display based on Key
            name.Remove(104);  // Remove Based on Key
            foreach (int i in name.Keys) {
                Console.WriteLine(i+" - "+name[i]);
            }
            Console.ReadKey();
        }
    }
}
