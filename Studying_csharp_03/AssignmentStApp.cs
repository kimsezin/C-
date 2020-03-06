using System;

namespace Studying_csharp_03
{
    class AssignmentStApp
    {
        static void Main()
        {
            short s;
            int i;
            float f;
            double d;
            s = 526;
            d = f = i = s;
            
            Console.WriteLine("s =" + s + " i =" + i);
            Console.WriteLine("f =" + f + " d =" + d);
        }
    }
}
