using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo
{
    class ThreadPoolDemo1
    {
        public static void Main()
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(Counter1));
            ThreadPool.QueueUserWorkItem(new WaitCallback(Counter2));

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("main: {0}", i);
                Thread.Sleep(1000);
            }
            Console.ReadKey();
        }

        static void Counter1(object state)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("  thread1: {0}", i);
                Thread.Sleep(2000);
            }
        }

        static void Counter2(object state)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("    thread2: {0}", i);
                Thread.Sleep(3000);
            }
        }
    }
}
