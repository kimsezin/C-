using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_csharp_02
{
    class ArrayTypeApp
    {
        public static void Main()
        {
            int[] ia = new int[3];
            int[] ib = { 1, 2, 3 };
            int i;
            for (i = 0; i < ia.Length; i++)
            {
                ia[i] = ib[i];
            }
            for (i = 0; i < ia.Length; i++)
            {
                Console.WriteLine(ia[i] + " ");
              
            }
            Console.WriteLine();
        }
    }
}
