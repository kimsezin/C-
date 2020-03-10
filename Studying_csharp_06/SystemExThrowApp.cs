using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_csharp_06
{

    class SystemExThrowApp
    {
        public static void Exp(int ptr)
        {
            if (ptr ==0)
            {
                throw new NullReferenceException();
            }
        }
        public static void Main()
        {
            int i = 0;
            SystemExThrowApp.Exp(i);
        }
    }
}
