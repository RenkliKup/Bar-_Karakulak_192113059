using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTransactionLayer;
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
            txt_ad.Enabled = false;
            txt_id.Enabled = false;
            txt_soyad.Enabled = false;
            btn_iade_et.Enabled = false;
            
        }

        private void closelabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        BookContext BookContext = new BookContext();
        private void button2_Click(object sender, EventArgs e)
        {
         if(grid_alinan_kitaplar.SelectedRows.Count>0)
            {
                int secilen_id = int.Parse(grid_alinan_kitaplar.SelectedRows[0].Cells[0].Value.ToString());
                Tuple<bool, string> response;
                Tuple<bool, string> response2;
                response = LibraryContext.returnBook(secilen_id);
                response2= BookContext.geriVer(secilen_id);
                MessageBox.Show(response.Item2, response.Item2.ToString());
                MessageBox.Show(response2.Item2, response2.Item2.ToString());

                int id = int.Parse(txt_id.Text);
                grid_alinan_kitaplar.DataSource = LibraryContext.teslimEtmedigiKitaplar(id);
                grid_teslim_ettigi_ktp.DataSource = LibraryContext.teslimEtigiKitaplar(id);
            }

            


        }

        private void txt_ad_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ogrSec ogrSec = new ogrSec(this);
            ogrSec.Show();
        }
        LibraryContext LibraryContext = new LibraryContext();
        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            int id = int.Parse(txt_id.Text);

            grid_alinan_kitaplar.DataSource = LibraryContext.teslimEtmedigiKitaplar(id);

            grid_teslim_ettigi_ktp.DataSource = LibraryContext.teslimEtigiKitaplar(id);


        }


        private void grid_alinan_kitaplar_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (grid_alinan_kitaplar.SelectedRows.Count > 0)
            {
                btn_iade_et.Enabled = true;
                
            }
            else
            {
                btn_iade_et.Enabled = false;
            }

        }

        private void grid_alinan_kitaplar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(grid_alinan_kitaplar.SelectedRows.Count>0)
            {
                KtpBilgi form = new KtpBilgi(this);
                form.Show();
            }

        }
    }
}
