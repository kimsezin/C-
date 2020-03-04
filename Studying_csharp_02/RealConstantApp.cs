using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_csharp_02
{
    class RealConstantApp
    {
        public static void Main()
        {
            float f1 = 1.414F, f2 = 0.1414e01f;
            double d = 0.1414E1;
            Console.WriteLine("f1 = " + f1 + " f2 = " + f2 + " d = " + d);
            if(f1==f2)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
