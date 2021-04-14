using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    public class GenericClass<T>
    {
        public T msg;
        public void genericMethod(T name,T location)
        {
            Console.WriteLine("{0}",msg);
            Console.WriteLine("Name :{0}",name);
            Console.WriteLine("Location :{0}",location);
        }
    }
    class GenericMethodDemo
    {
        static void Main()
        {
            Console.WriteLine("****Generics Example****");
            GenericClass<String> gclass = new GenericClass<string>();
            gclass.msg = "Welcome to C#";
            gclass.genericMethod("Lenin","Hyd");
            Console.ReadKey();
        }
    }
}
