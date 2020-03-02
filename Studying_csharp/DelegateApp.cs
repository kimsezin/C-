using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_csharp
{
    delegate void SampleDelegate(); //델리게이트 정의
    class DelegateClass
    {
        public void DelegateMethod() //델리게이트할 메소드
        {
            Console.WriteLine("In the DelegateClass.DelegateMethod ...");
        }
    }
    class DelegateApp
    {
        public static void Main()
        {
            DelegateClass obj = new DelegateClass();
            SampleDelegate sd = new SampleDelegate(obj.DelegateMethod);
            sd();
        }
    }
}
