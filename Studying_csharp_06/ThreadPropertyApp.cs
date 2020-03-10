﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace Studying_csharp_06
{
    class ThreadProperty
    {
        public void ThreadBody()
        {
            Thread myself = Thread.CurrentThread;
            for(int i=1;i<4;i++)
            {
                Console.WriteLine("{0} is activated => {1}", myself.Name, i);
            }
            Thread.Sleep(1000);
        }
    }
    class ThreadPropertyApp
    {
        public static void Main()
        {
            ThreadProperty obj = new ThreadProperty();
            ThreadStart ts = new ThreadStart(obj.ThreadBody);
            Thread t1 = new Thread(ts);
            Thread t2 = new Thread(ts);
            t1.Name = "Apple"; t2.Name = "Orange";
            t1.Start(); t2.Start();
        }
    }
}
