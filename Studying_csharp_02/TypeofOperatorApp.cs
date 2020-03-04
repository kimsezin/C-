using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace Studying_csharp_02
{
    class Apple
    {
        public int nSeeds = 0;
        public void Ripen() { /*...*/}
    }
    class TypeofOperatorApp
    {  
        public static void Main()
        {
            Type t = typeof(Apple);
            string className = t.ToString();
            MemberInfo[] allMembers = t.GetMembers();
            Console.WriteLine("All " + className + "Members");
            foreach(MemberInfo member in allMembers )
            {
                Console.WriteLine(member.ToString());
            }
        }
    }
}
