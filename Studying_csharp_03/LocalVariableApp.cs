using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_csharp_03
{
    class LocalVariableApp
    {
        static int x;
        public static void Main()
        {
            int x = (LocalVariableApp.x = 2) * 2;
            Console.WriteLine("static x = " +LocalVariableApp.x);
            Console.WriteLine("local x = " + x);
        }
    }
}
