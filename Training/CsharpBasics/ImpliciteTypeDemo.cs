using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasics
{
    class ImpliciteTypeDemo
    {
        public static void Main() {
            //int b = 100; // Explicity typed variable(can use Every where)
            var a = 100;  // Implicitly typed variable(only in methods)
            var name = "Lenin";
            var arr = new[] { 11, 22, 33 };
            Console.WriteLine(a+" - "+a.GetType());
            Console.WriteLine(name);
            Console.WriteLine(arr);
            Console.ReadKey();
           
            /*
             * error
             a="C#"; // can't change type
             var i; // should be intialise
             var j=10,k=20; // cannot declare single statament
             */
        }
    }
}
