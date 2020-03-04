using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_csharp_02
{
    class ConditinalOperatorApp
    {
        public static void Main()
        {
            int a, b, c;
            int m;
            Console.WriteLine("Enter three numbers :");
            a = Console.Read() - '0';
            b = Console.Read() - '0';
            c = Console.Read() - '0';
            m = (a > b) ? a : b;
            m = (m > c) ? m : c;
            Console.WriteLine("The largest number = " + m);
        }
    }
}
