using System;

namespace Studying_csharp_06
{
    class SimpleGeneric<T>
    {
        private T[] values;
        private int index;
        public SimpleGeneric(int len)
        {
            values = new T[len];
            index = 0;
        }
        public void Add(params T[] args)
        {
            foreach (T e in args)
            {
                values[index++] = e;
            }
        }
        public void Print()
        {
            foreach (T e in values)
            {
                Console.Write(e + " ");
            }
            Console.WriteLine();
        }
    }
    
    class GenericClassApp
    {
        public static void Main()
        {
            
        }
    }
}
