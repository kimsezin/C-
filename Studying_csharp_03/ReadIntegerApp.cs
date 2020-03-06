using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_csharp_03
{
    class ReadIntegerApp
    {
        static int ReadInt()
        {
            char ch;
            int n = 0;
            while (!char.IsDigit(ch = (char)Console.Read())) ;
            do
            {
                n = n * 10 + (ch - '0');
                ch = (char)Console.Read();
            }
            while (char.IsDigit(ch));
            return n;
        }
        public static void Main()
        {
            Console.Write("***Input data : ");
            Console.Write("***read data : " + ReadInt() + " " + ReadInt());
        }
    }
}
