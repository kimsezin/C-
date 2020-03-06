using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_csharp_04
{
    class CallByValueApp
    {
        static void swap(int x, int y)
        {
            int temp;
            temp = x; x = y; y = temp;
            Console.WriteLine(" Swap: x = {0}, y = {1}", x, y);
        }
        public static void Main()
        {
            int x = 1, y = 2;
            Console.WriteLine("Before : x = {0},y = {1}", x, y);
            swap(x, y);
            Console.WriteLine(" After : x = {0}, y = {1}", x, y);
        }
    }
}
