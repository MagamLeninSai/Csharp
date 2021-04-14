using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    //Deledate declaration
    public delegate int operation(int x,int y);
    class Program
    {
        static int addition(int a,int b)
        {
            return a + b; 
        }
        static void Main(string[] args)
        {
            //Delegate instantiation
            operation obj = new operation(Program.addition);
            Console.WriteLine("Addition is= {0}",obj(10,10));
            //or
            int res = obj.Invoke(10,10);
            Console.WriteLine("Addition is= {0}", res);

            Console.ReadKey();
        }
    }
}
