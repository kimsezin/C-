using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_csharp_04
{
    delegate void MultiCastDelegate();
    class schedule
    {
        public void Now()
        {
            Console.WriteLine("Time : " + DateTime.Now.ToString());
        }
        public void Today()
        {
            Console.WriteLine("Date : " + DateTime.Today.ToString());
        }
    }
    class MultiCastApp
    {
       public static void Main()
        {
            schedule obj = new schedule();
            MultiCastDelegate mcd = new MultiCastDelegate(obj.Now);
            mcd += new MultiCastDelegate(obj.Today);
            mcd();
        }
    }
}
