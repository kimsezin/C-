using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_csharp_04
{
    class ParameterArrayApp
    {
        static void ParameterArray(params object[] obj)
        {
            for (int i=0;i<obj.Length;i++)
            {
                Console.WriteLine(obj[i]);
            }
        }
        public static void Main()
        {
            ParameterArray(123, "Hello", true, 'A');
        }
    }
}
