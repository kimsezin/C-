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
    public partial class PaintEventApp : Form
    {
        public PaintEventApp()
        {
            InitializeComponent();
        }
        private void butten1_Click(object Sender, EventArgs e)
        {
            panel1.Invalidate();
        }
        private void panel1_Paint(object Sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Random r = new Random();
            Color c = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            g.FillRectangle(new SolidBrush(c), e.ClipRectangle);
        }
    }
}
