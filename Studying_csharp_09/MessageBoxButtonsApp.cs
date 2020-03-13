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
    public partial class MessageBoxButtonsApp : Form
    {
        public MessageBoxButtonsApp()
        {
            InitializeComponent();
        }
        private void MessageBoxButtonsApp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MessageBoxButtons", "Title Bar", MessageBoxButtons.AbortRetryIgnore);
        }
    }
}
