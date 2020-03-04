using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_csharp
{
    class example_1_5_2
    {
        public static void Main()
        {
            int i = 1, j = 1, k;
            try
            {
                Console.WriteLine("Exception checking...");
                k = i / j;
                Console.WriteLine("After Exception happening...");
            } 
            catch (Exception e)
            {
                Console.WriteLine("Caught Exception...");
            }
            finally
            {
                Console.WriteLine("In the finally statement...");
            }
        }
    }
}
