using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studying_csharp_07
{
    public partial class MoveResizeApp : Form
    {
        public MoveResizeApp()
        {
            InitializeComponent();
        }
        private void SetButtonText()
        {
            button1.Text =
                "Location = " + Location + "\n" +
                "Left/Right/Width = " + Left + "," + Right + "," + Width + "\n" +
                "Top/Bottom/Height = " + Top + "," + Bottom + "," + Width;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SetButtonText();
        }
        private void Form1_Move(object sender, EventArgs e)
        {
            SetButtonText();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            SetButtonText();
        }


    }
}
