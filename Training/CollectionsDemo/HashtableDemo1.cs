using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class HashtableDemo1
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();
            ht.Add(100,"John");
            ht.Add(200,"Ravi");
            ht.Add(300,"Mike");
            
            // use DictionaryEntry to display ht contents
            foreach (DictionaryEntry de in ht)
            {
                Console.WriteLine(de.Key +" - "+de.Value );
            }
            Console.WriteLine("-----------");
            ICollection key = ht.Keys;
            foreach (var k in key) {
                Console.WriteLine(k+" - "+ht[k]);
            }
            Console.ReadKey();
        }
    }
}
