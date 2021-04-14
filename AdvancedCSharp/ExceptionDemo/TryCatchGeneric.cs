using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    class TryCatchGeneric
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("ENTER ANY TWO NUBERS");
            try
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = a / b;
                Console.WriteLine("C VALUE = " + c);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);  //exception name
                Console.WriteLine(ex.Source);  //file name
                Console.WriteLine(ex.HelpLink);  // help link
                Console.WriteLine(ex.StackTrace); // full destils of exception
            }
            /*catch
            {
                Console.WriteLine("error occured....");
            }*/

            Console.ReadKey();
        }
    }
}
