using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace Studying_csharp_08
{
    public partial class LinkLabelApp : Form
    {
        public LinkLabelApp()
        {
            InitializeComponent();
        }
        private void linkLabel1_LinkClikced(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(linkLabel1.Text);
        }
        private void linkLabel2_LinkClikced(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(linkLabel2.Text);
        }
        private void linkLabel3_LinkClikced(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("notepad.exe",linkLabel3.Text);
        }
    }
}
