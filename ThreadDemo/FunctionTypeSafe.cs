using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo
{

     // make the thread function type-safe in C#

    class FunctionTypeSafe
    {
        static void Main()
        {
            int max = 10;
            NumberHelper nh = new NumberHelper(max);
            Thread t1 = new Thread(new ThreadStart(nh.DisplayNumbers));
            t1.Start();
            Console.ReadKey();
        }
    }
}
