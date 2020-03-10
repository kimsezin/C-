using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_csharp_05
{
    abstract class AbstractClass
    {
        public abstract void MethodA();
        public void MethodB()
        {
            Console.WriteLine("Implementation of MethodB()");
        }
    }
    class ImpClass : AbstractClass
    {
        override public void MethodA()
        {
            Console.WriteLine("Implementation of MethodA()");
        }
    }
    class AbstractClassApp
    {
        public static void Main()
        {
            ImpClass obj = new ImpClass();
            obj.MethodA();
            obj.MethodB();
        }
    }   
}
