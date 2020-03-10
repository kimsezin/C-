using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_csharp_05
{
    interface IRectangle
    {
        void Area(int width, int height);
    }
    interface ITriangle
    {
        void Area(int width, int height);
    }
    class Shape : IRectangle, ITriangle
    {
        void IRectangle.Area(int width, int height)
        {
            Console.WriteLine("Rectangle Area : " + width * height);
        }
        void ITriangle.Area(int width, int height)
        {
            Console.WriteLine("Rectangle Area : " + width * height/2);
        }
    }
    class ImplementingInterfaceApp
    {
        public static void Main()
        {
            Shape s = new Shape();
            ((IRectangle)s).Area(10, 10);
            ((ITriangle)s).Area(20, 20);
            IRectangle r = s;
            ITriangle t = s;
            r.Area(30, 30);
            t.Area(30, 30);
        }
    }
}
