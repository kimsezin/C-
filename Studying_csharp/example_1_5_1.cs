using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_csharp
{
    delegate void Delegate();
    class example
    {
        public static void Method1()
        {
            Console.WriteLine("In the Method 1...");
        }
        public static void Method2()
        {
            Console.WriteLine("In the Method 2...");
        }
        public static void Main()
        {
            Delegate d = new Delegate(Method1);
            d += new Delegate(Method2);
            d();
        }
    }
}
