using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studying_csharp_10
{
    public partial class MousePositionApp : Form
    {
        public MousePositionApp()
        {
            InitializeComponent();
        }
        private void MousePositionApp_MouseEnter(object sender, EventArgs e)
        {
            Point mousePoint = PointToClient(MousePosition);
            string msg = "Mouse Position : " + mousePoint.X + "," + mousePoint.Y;
            MessageBox.Show(msg);
        }
    }
}
