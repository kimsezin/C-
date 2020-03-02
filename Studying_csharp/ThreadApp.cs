using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Studying_csharp
{
    class ThreadApp
    {
        static void ThreadBody()
        {
            Console.WriteLine("in th thread body ...");
        }
        public static void Main()
        {
            ThreadStart ts = new ThreadStart(ThreadBody);
            Thread t = new Thread(ts);
            Console.WriteLine("*** start of main");
            t.Start();
            Console.WriteLine("*** end of main");
        }
    }
}
