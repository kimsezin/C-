﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace Studying_csharp_12
{
    public partial class WidthSampleA : Form
    {
        public WidthSampleA()
        {
            InitializeComponent();
        }
        private void WidthSampleA_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = CreateGraphics();
            Font f = new Font("Times New Roman", 12, FontStyle.Regular);
            Font bf = new Font("Times New Roman", 12, FontStyle.Bold);
            Font itf = new Font("Times New Roman", 12, FontStyle.Italic);
            Font bif = new Font("Times New Roman", 12, FontStyle.Bold | FontStyle.Italic);

            Font sf = new Font("Times New Roman", 12, FontStyle.Strikeout);
            Font uf = new Font("Times New Roman", 12, FontStyle.Underline);
            Font bsf = new Font("Times New Roman", 12, FontStyle.Bold | FontStyle.Strikeout);

            int h = f.Height;
            g.DrawString("Regular", f, Brushes.Black, 0, 0);
            g.DrawString("Bold", bf, Brushes.Black, 0, h);
            g.DrawString("Italic", itf, Brushes.Black, 0, h*2);
            g.DrawString("Bold-Italic", bif, Brushes.Black, 0, h*3);
            g.DrawString("Strikeout", sf, Brushes.Black, 0, h*4);
            g.DrawString("Underline", uf, Brushes.Black, 0, h*5);
            g.DrawString("Bold & Strikeout", bsf, Brushes.Black, 0, h*6);
        }

    }
    
}
