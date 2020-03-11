using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace Studying_csharp_06
{
    class SchedulerApp
    {
        static int interval;
        static void ThreadBody()
        {
            Thread myself = Thread.CurrentThread;
            Console.WriteLine("Starting Thread :" + myself.Name);
            for (int i=1;i<=3*interval;i++)
            {
                if (i % interval ==0)
                {
                    Console.WriteLine(myself.Name + " : " + i);
                }
            }
            Console.WriteLine("Ending Thread : " + myself.Name);
        }
        public static void Main()
        {
            Console.Write("Interval value :");
            interval = int.Parse(Console.ReadLine());
            Thread.CurrentThread.Name = "Main Thread";
            Thread.CurrentThread.Priority = ThreadPriority.Highest;
            Thread worker = new Thread(new ThreadStart(ThreadBody));
            worker.Name = "Worker Thread";
            worker.Start();
            ThreadBody();
        }
    }
}
