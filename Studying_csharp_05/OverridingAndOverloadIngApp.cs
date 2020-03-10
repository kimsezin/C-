using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_csharp_05
{
    class BaseClass
    {

        public void MethodA()
        {
            Console.WriteLine("In the Baseclass...");
        }
    }
    class DerivedClass : BaseClass
    {
        new public void MethodA()
        {
            Console.WriteLine("In DerivedClass ... Overriding !!!");
        }
        public void MethodA(int i)
        {
            Console.WriteLine("In DerivedClass ... Overloading !!!");
        }
    }
    class OverridingAndOverloadIngApp
    {
        public static void Main()
        {
            BaseClass obj1 = new BaseClass();
            DerivedClass obj2 = new DerivedClass();
            obj1.MethodA();
            obj2.MethodA();
            obj2.MethodA(1);
        }

    }
}
