using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_csharp_02
{
    class PrintTenltemApp
    {
        public static void Main()
        {
            int i, n = 25;
            for (i=1;i<=n;++i)
            {
                Console.WriteLine(i + ((i % 10 == 0 || i == n) ? "\n" : " "));
            }
        }
    }
}
