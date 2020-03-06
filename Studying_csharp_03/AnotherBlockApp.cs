using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_csharp_03
{
    class AnotherBlockApp
    {
        public static void Main()
        {
            int x = 1;
            {
                int y = 2;
                Console.WriteLine("Block 1: x = " + x + ", y = " + y);
            }
            {
                int y = 3;
                Console.WriteLine("Block 2: x = " + x + ", y = " + y);
            }
        }
    }
}
