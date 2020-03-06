﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_csharp_04
{
    class StaticConstructor
    {
        static int staticWithInitializer = 100;
        static int staticWithNoInitializer;
        StaticConstructor()
        {
            staticWithNoInitializer = staticWithInitializer + 100;
        }
        public static void PrintStaticVariable()
        {
            Console.WriteLine("field 1 = {0} , field 2 = {1}",
                staticWithInitializer, staticWithNoInitializer);
        }
    }
    class StaticConstructorApp
    {
        public static void Main()
        {
            StaticConstructor.PrintStaticVariable();
        }
    }
}
