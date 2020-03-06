using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_csharp_04
{
    class PropertyWithoutFieldApp
    {
        public string Message
        {
            get { return Console.ReadLine(); }
            set { Console.WriteLine(value); }
        }
        public static void Main()
        {
            PropertyWithoutFieldApp obj = new PropertyWithoutFieldApp();
            obj.Message = obj.Message;
        }
    }
}
