using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_csharp_03
{
    class CompoundApp
    {
        public static void Main()
        {
            int n;
            Console.WriteLine("Enter one digit = ");
            n = Console.Read()-'0';
            if(n<0)
            {
                Console.WriteLine("Negative Number !");
            }
            else
            {
                Console.WriteLine(n + " squared is " + (n * n));
                Console.WriteLine(n + " cubed is " + (n * n * n));
            }
        }

    }
}
