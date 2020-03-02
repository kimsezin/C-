using System;
using System.Collections.Generic;
using System.Text;

namespace Studying_csharp
{
    class EventApp
    {
        public EventHandler MyEvent;
        void MyEventHandler(object sender, EventArgs e)
        {
            Console.WriteLine("Hello World");
        }
        public EventApp()
        {
            this.MyEvent += new EventHandler(MyEventHandler);
        }
        public void InvokeEvent()
        {
            if (MyEvent != null)
                MyEvent(this, null);
        }
        public static void Main()
        {
            new EventApp().InvokeEvent();
        }
    }
}
