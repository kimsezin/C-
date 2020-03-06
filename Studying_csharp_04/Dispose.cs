using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_csharp_04
{
    class DisposeClass : IDisposable
    {
        //...
        public void Dispose()
        {
            Console.WriteLine("In the Dispose...");
            GC.SuppressFinalize(this);
        }
    }
    class Dispose
    {
        public static void Main()
        {
            Console.WriteLine("start of main");
            using (DisposeClass obj = new DisposeClass())
            {
                //...
            }
            Console.WriteLine("End of Main");
        }
    }
}
