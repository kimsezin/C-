using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_csharp_05
{
    class BaseClass
    {
        virtual public void MethodA()
        {
            Console.WriteLine("Base Method A");
        }
        virtual public void MethodB()
        {
            Console.WriteLine("Base Method B");
        }
        virtual public void MethodC()
        {
            Console.WriteLine("Base Method C");
        }
    }
    class DerivedClass : BaseClass
    {
        new public void MethodA()
        {
            Console.WriteLine("Derived Method A");
        }
        override public void MethodB()
        {
            Console.WriteLine("Derived Method B");
        }
        public void MethodC()
        {
            Console.WriteLine("Derived Method C");
        }
    }
    class VirtualMethodApp
    {
        public static void Main()
        {
            BaseClass s = new DerivedClass();
            s.MethodA();
            s.MethodB();
            s.MethodC();
        }
    }
}
