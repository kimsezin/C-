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
    public partial class MessageBoxApp : Form
    {
        public MessageBoxApp()
        {
            InitializeComponent();
        }

        private void MessageBoxApp_Load(object sender, EventArgs e)
        {
            MessageBox.Show("MessageBox", "Title Bar");
        }
    }
}
