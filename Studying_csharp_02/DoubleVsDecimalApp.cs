using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_csharp_02
{
    class DoubleVsDecimalApp
    {
        public static void Main()
        {
            double d = 0d;
            decimal m = 0m;
            for (int i=0;i<1000;i++)
            {
                d += 0.10d;
                m += 0.10m;
            }
            Console.WriteLine("0.1d*1000 = " + d);
            Console.WriteLine("0.1m*1000 = " + m);
        }
    }
}
