using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barış_Karakulak_192113059.iadeEt
{
    public partial class KtpIadeEt : Form
    {
        public KtpIadeEt()
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

            base.WndProc(ref m);
        }
        private void KtpIadeEt_Load(object sender, EventArgs e)
        {

        }

        private void closelabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
