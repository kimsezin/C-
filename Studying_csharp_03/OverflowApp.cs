using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_csharp_03
{
    class OverflowApp
    {
        public static void Main()
        {
            int i, max = int.MaxValue;
            try
            {
                Console.WriteLine("Start of try statement");
                i = max + 1;
                Console.WriteLine("After default overflow");
                unchecked
                {
                    i = max + 1;
                }
                Console.WriteLine("After unchecked statement");
                checked
                {
                    i = max + 1;
                }
                Console.WriteLine("After checked statement");
            }
            catch
            {
                Console.WriteLine("caught an OverflowException");
            }
        }
    }
}
