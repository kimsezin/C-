using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_csharp_05
{
    class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("BaseClass Constructor ...");
        }
    }
    class DerivedClass : BaseClass
    {
        public DerivedClass()
        {
            Console.WriteLine("DerivedClass Constructor ...");
        }
    }
    class DerivedConstructorApp
    {
        public static void Main()
        {
            DerivedClass obj = new DerivedClass();
            Console.WriteLine("In the Main...");
        }

    }
}
