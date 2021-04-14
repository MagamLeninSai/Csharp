using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    class ActionDelegateDemo1
    {
            static void Main(string[] args)
            {
                Action printText = new Action(MethodCollections.PrintText);
                Action<string> print = new Action<string>(MethodCollections.Print);
                Action<int, int> printNumber = new Action<int, int>(MethodCollections.PrintNumbers);

                Console.WriteLine("\n***************** Action<> Delegate Methods ***************\n");
                printText();    //Parameter: 0 , Returns: nothing  
                print("Lenin");  //Parameter: 1 , Returns: nothing  
                printNumber(5, 20); //Parameter: 2 , Returns: nothing  
                Console.WriteLine();

                Console.ReadLine();
            }
    }
}
