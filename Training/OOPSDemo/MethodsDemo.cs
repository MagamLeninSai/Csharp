using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    class MethodsDemo
    {
            public static void Multiplication(int x)
            {
                x *= x;
                Console.WriteLine("Variable value inside method {0}", x);
            }

        public static void Multiplication1(ref int x)
        {
            x *= x;
            Console.WriteLine("Variable value inside method {0}", x);
        }

        public static void Multiplication2(out int x)
        {
            x = 10; // out type  should be intialize in method
            x *= x;
            Console.WriteLine("Variable value inside method {0}", x);
        }
        static void Main()
            {
                int a = 10;
                
            Console.WriteLine("=========Pass By value=============");
            Console.WriteLine("The value of A before method call {0}", a);
                Multiplication(a); // Passing parameters by value
                Console.WriteLine("VAlue of A after method call {0}", a);

            /* In c#, passing a value type parameter to a method by reference means passing a
             * reference of the variable to the method.
             * So the changes made to the parameter inside of the called method will have an
             * effect on the original data stored in the argument variable. */

                Console.WriteLine("=========Pass By Reference=============");
                Console.WriteLine("The value of A before method call {0}", a);
                Multiplication1(ref a); // Passing parameters by value
                Console.WriteLine("VAlue of A after method call {0}", a);

            /* In c#, out keyword is used to pass arguments to the method as a reference type.
             * The out keyword same as the ref keyword but the only difference is out doesn’t
             * require a variable to be initialized before we pass it as an argument to the
             * method but the variable must be initialized in called method before it returns a
             * value to the calling method. */

            Console.WriteLine("=========Pass By out=============");
            Multiplication2(out int c); 
            Console.WriteLine("VAlue of b after method call {0}", c);
            Console.ReadKey();
            }
        }
}
