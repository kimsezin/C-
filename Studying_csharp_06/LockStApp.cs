using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace Studying_csharp_06
{
    
    class LockStApp
    {

        public void ThreadBody()
        {
            Thread myself = Thread.CurrentThread;
            lock (this)
            {
                for (int i = 1; i < 4; i++)
                {
                    Console.WriteLine("{0} is activated => {1}", myself.Name, i);
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
