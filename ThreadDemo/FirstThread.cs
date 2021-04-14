using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo
{
    class FirstThread
    {
        static void Main(string[] args)
        {
            // creating child thread & ThreadStart is event handler it will call PrintInfo method when we give t.start()
            Thread t = new Thread(new ThreadStart(PrintInfo));
            // start newly created thread
            t.Start();
            Console.WriteLine("Main Thread Completed");
            Console.ReadKey();
        }
        static void PrintInfo()
        {
            for (int i=1;i<=4;i++)
            {
                Console.WriteLine("i Value :{0}",i);
            }
            Console.WriteLine("Child Thread Completed");
        }
    }
}
