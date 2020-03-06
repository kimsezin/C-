using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_csharp_04
{
    class CommandLineArgsApp
    {
        public static void Main(string[] args)
        {
            for (int i=0;i<args.Length;++i)
            {
                Console.WriteLine("Argument[{0}] = {1}", i, args[i]);
            }
        }
    }
}
