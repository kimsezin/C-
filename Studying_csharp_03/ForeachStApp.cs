using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_csharp_03
{
    class ForeachStApp
    {
        public static void Main()
        {
            string[] color = { "red", "green", "blue" };
            foreach (string s in color)
                Console.WriteLine(s);
        }
    }
}
