using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace Studying_csharp_06
{
    class ThreadPriorityApp
    {
        static void ThreadBody()
        {
            Thread.Sleep(1000);
        }
        public static void Main()
        {
            Thread t = new Thread(new ThreadStart(ThreadBody));
            t.Start();
            Console.WriteLine("Current Priority :" + t.Priority);
            ++t.Priority;
            Console.WriteLine("Higher Priority :" + t.Priority);
        }
    }
}
