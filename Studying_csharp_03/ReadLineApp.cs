using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_csharp_03
{
    class ReadLineApp
    {
        public static void Main()
        {
            int time, hour, minute, second;
            Console.Write(" *** Enter an integral time :");
            time = int.Parse(Console.ReadLine());
            hour = time / 10000;
            minute = time / 100 % 100;
            second = time % 100;
            Console.WriteLine(hour + ":" + minute + ":" +second);
        }
    }
}
