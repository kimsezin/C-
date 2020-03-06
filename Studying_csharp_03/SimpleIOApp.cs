using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_csharp_03
{
    class SimpleIOApp
    {
        public static void Main()
        {
            int i; char c;
            Console.Write("Enter a digit and a character = ");
            i = Console.Read() - '0';
            c = (char)Console.Read();
            Console.Write("i = " + i);
            Console.WriteLine(", c = " + c);
        }
    }
}
