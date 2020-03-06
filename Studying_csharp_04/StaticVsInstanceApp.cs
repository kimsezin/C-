using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_csharp_04
{
    public class StaticVsInstanceApp
    {
        int instanceVariable;
        static int staticVariable;
        public static void Main()
        {
            StaticVsInstanceApp obj = new StaticVsInstanceApp();
            obj.instanceVariable = 10;
            //StaticVsInstanceApp.instanceVariable=10; error
            StaticVsInstanceApp.staticVariable = 20;
            //obj.staticvairable=20;
            Console.WriteLine("instance variable = {0}, static variable={1}", obj.instanceVariable, StaticVsInstanceApp.staticVariable);
        }
    }
}
