using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studying_csharp_09
{
    public partial class ModelessApp : Form
    {
        public ModelessApp()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ModelessDialogBox form1 = new ModelessDialogBox();
            form1.Show();
        }
    }
}
