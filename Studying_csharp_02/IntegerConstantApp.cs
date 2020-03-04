using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_csharp_02
{
    class IntegerConstantApp
    {
        public static void Main()
        {
            int i = 255, h = 0xff;
            long l = 0xffL;
            Console.WriteLine("i={0}, h={1}", i, h);
            if (h == l)
                Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}
