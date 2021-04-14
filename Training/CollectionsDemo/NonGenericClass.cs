using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class Addition
    {
        public void add<T> (T a,T b){
            dynamic a1 = a;
            dynamic b1 = b;
            Console.WriteLine(a1+b1);
        }
    }
    class NonGenericClass
    {
        dynamic i = 10; // can use in class or methods
        static void Main()
        {
            Addition a = new Addition();
            dynamic n="Lenin";  // Assign datatype at RunTime based on value
            Console.WriteLine(n.GetType() +" "+ new NonGenericClass().i );
            a.add<int>(10,20);
            a.add<float>(10.4f,11.6f);
            a.add<string>("Lenin"," Sai");
            Console.ReadKey();
        }
    }
}
