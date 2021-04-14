using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    class ActionDelegateDemo
    {
        public static void ConsolePrint(int i)
        {
            Console.WriteLine(i);
        }
        static void Main()
        {
            Action<int> a1 = new Action<int>(ConsolePrint);
            Action<int> a = ConsolePrint;
            a1.Invoke(10);
            a.Invoke(20);
            Console.ReadKey();
        }
    }
}
