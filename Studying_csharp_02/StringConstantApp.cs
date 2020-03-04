using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_csharp_02
{
    class StringConstantApp
    {
        public static void Main()
        {
            char c = 'A';
            int i;
            i = c + 1;
            Console.WriteLine("c =" + c +"\nnext c ="+(char)i);
            Console.WriteLine("\"I am a string\"");
            Console.WriteLine(@"""I am a string.""");
        }
    }
}
