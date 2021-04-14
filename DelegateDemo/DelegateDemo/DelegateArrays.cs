using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    public class Operation
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine("Addition={0}", a + b);
        }

        public static void Multiple(int a, int b)
        {
            Console.WriteLine("Multiply={0}", a * b);
        }
    }

    class DelegateArrays
    {
        delegate void Delop(int x, int y);

        static void Main(string[] args)
        {
            // Delegate instantiation  
            Delop[] obj =
           {
               new Delop(Operation.Add),
               new Delop(Operation.Multiple)
           };

            for (int i = 0; i < obj.Length; i++)
            {
                obj[i](2, 5);
                obj[i](8, 5);
                obj[i](4, 6);
            }
            Console.ReadLine();
        }
    }
}
