using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Studying_csharp_12
{
    class RectContainsApp
    {
        public static void Main()
        {
            Rectangle rect = new Rectangle(10, 20, 80, 40);
            Point pt1 = new Point(30, 40);
            Point pt2 = new Point(90, 60);
            Console.WriteLine("포합되는가? ; {0}", rect.Contains(pt1));
            Console.WriteLine("포합되는가? ; {0}", rect.Contains(pt2));
        }
    }
}
