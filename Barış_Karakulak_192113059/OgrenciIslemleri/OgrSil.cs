﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barış_Karakulak_192113059.OgrenciIslemleri
{
    public partial class OgrSil : Form
    {
        public OgrSil()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }
        }
        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void OgrSil_Load(object sender, EventArgs e)
        {

        }

        private void closelabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
