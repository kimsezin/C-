﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_csharp_04
{
    class Integer
    {
        public int i;
        public Integer(int i)
        {
            this.i = i;
        }
    }
    class CallByObjectReferenceApp
    {
        static void Swap(Integer x, Integer y)
        {
            int temp = x.i; x.i = y.i; y.i = temp;
            Console.WriteLine(" Swap : x = {0}, y = {1}", x.i, y.i);
        }
        public static void Main()
        {
            Integer x = new Integer(1);
            Integer y = new Integer(2);
            Console.WriteLine("Before : x = {0}, y = {1}", x.i, y.i);
            Swap(x, y);
            Console.WriteLine("After: x = {0}, y = {1}", x.i, y.i);
        }
    }
}
