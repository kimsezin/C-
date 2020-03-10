using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_csharp_06
{
    class IndexOutOfRangeApp
    {
        public static void Main()
        {
            int[] vector = { 1, 2, 3 };
            vector[3] = 4;
        }
    }
}
