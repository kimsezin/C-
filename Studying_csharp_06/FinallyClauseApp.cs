using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_csharp_06
{
    
    class FinallyClauseApp
    {
        static int count = 0;
        public static void Main()
        {
            while (true)
            {
                try
                {
                    if (++count == 1) throw new Exception();
                    if (count == 3) break;
                    Console.WriteLine(count + ") No exception");
                }
                catch (Exception)
                {
                    Console.WriteLine(count + ") Exception Thrown");
                }
                finally
                {
                    Console.WriteLine(count + ") in finally clause");
                }
            }
            Console.WriteLine("Main program ends");
        }
    }
}
