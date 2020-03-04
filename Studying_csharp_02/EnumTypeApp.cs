using System;
using System.Collections.Generic;
using System.Text;
enum Color { Red,Green,Blue};
namespace Studying_csharp_02
{
    class EnumTypeApp
    {
        public static void Main()
        {
            Color c = Color.Red;
            c++;
            int i = (int)c;
            Console.WriteLine("Cardinality of " + c + "=" + i);
        }
    }
}
