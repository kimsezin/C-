using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_csharp_04
{
    class StringIndexer
    {
        public char this[string str, int index]
        {
            get { return str[index]; }
        }
        public string this[string str, int index, int len]
        {
            get { return str.Substring(index, len); }
        }
    }
    class StringIndexerApp
    {
        public static void Main()
        {
            string str = "Hello";
            StringIndexer s = new StringIndexer();
            for(int i=0;i<str.Length;i++)
            {
                Console.WriteLine("{0}[{1}] = {2} ", str, i, s[str, i]);
                Console.WriteLine("substring of {0} is {1}", str, s[str, 2, 3]);
            }
        }
    }
}
