using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_csharp_02
{
    class StringApp
    {
        public static void Main()
        {
            StringApp obj = new StringApp();
            string str = "Class name is ";
            Console.WriteLine(str + obj.ToString());
            StringBuilder sb = new StringBuilder();
            sb.Append(str);
            sb.Append(obj.ToString());
            Console.WriteLine(sb);
        }
    }
}
