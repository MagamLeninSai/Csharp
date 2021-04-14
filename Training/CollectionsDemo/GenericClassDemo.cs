using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class DataStore<T>
    {
        public T Data { get; set; }  // Generic Property

        public DataStore(T val)  // Generic Constructor
        {
            Console.WriteLine(val);
        }
    }
    class GenericClassDemo
    {
        static void Main() {
            DataStore<String> store = new DataStore<string>("Hii");
            store.Data = "HelloWorld";

            DataStore<int> store1 = new DataStore<int>(10);
            store1.Data = 100;
            Console.WriteLine(store.Data +" "+store1.Data);
            Console.ReadKey();
        }
    }
}
