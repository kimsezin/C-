using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_csharp_06
{
    class PropagateApp
    {
        void Orange()
        {
            int i = 25, j = 0;
            i = i / j;
            Console.WriteLine("End of Orange method");
        }
        void Apple()
        {
            Orange();
            Console.WriteLine("End of Apple Method");
        }
        public static void Main()
        {
            PropagateApp p = new PropagateApp();
            try
            {
                p.Apple();

            }
            catch (ArithmeticException)
            {
                Console.WriteLine("ArtihmeticException is processed");
            }
            Console.WriteLine("End of Main");
        }
        
    }
}
