using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_csharp_06
{
    class UserExceptionOne : ApplicationException { }
    class UserExceptionTwo : ApplicationException { }

    class UserHandlerApp
    {
        static void Method(int i)
        {
            if (i == 1)
            {
                throw new UserExceptionOne();
            }
            else
            {
                throw new UserExceptionTwo();
            }
        }
        public static void Main()
        {
            try
            {
                Console.WriteLine("Here: 1");
                Method(2);
                Console.WriteLine("Here: 2");
            }
            catch (UserExceptionOne)
            {
                Console.WriteLine("UserExceptionOne is called.");
            }
            catch (UserExceptionTwo)
            {
                Console.WriteLine("UserExceptionOne is called.");
            }
            Console.WriteLine("Here: 3");
        }
    }
}
