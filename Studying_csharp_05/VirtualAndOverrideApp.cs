using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_csharp_05
{
    class CLanguage
    {
        virtual public void Print()
        {
            Console.WriteLine("In the Clanguage class ...");
        }
    }
    class Java : CLanguage
    {
        public override void Print()
        {
            Console.WriteLine("In the Java class ...");
        }
    }
    class VirtualAndOverrideApp
    {
        public static void Main()
        {
            CLanguage c = new Java();
            c.Print();
        }
    }
}
