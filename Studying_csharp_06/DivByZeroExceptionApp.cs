using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_csharp_06
{
    class DivByZeroExceptionApp
    {
        public static void Main()
        {
            int i = 1, j = 0, k;
            k = i / j;
        }
    }
}
