using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Barış_Karakulak_192113059.iadeEt;
using DataTransactionLayer;
using Model;
namespace Barış_Karakulak_192113059.iadeEt
{
    
    public partial class KtpBilgi : Form
    {
        KtpIadeEt form;
            
        public KtpBilgi(KtpIadeEt form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

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
        LibraryContext LibraryContext = new LibraryContext();
        private void KtpBilgi_Load(object sender, EventArgs e)
        {
            
            
            int ktp_id = int.Parse(form.grid_alinan_kitaplar.SelectedRows[0].Cells[0].Value.ToString());
            List<Library> ktp;
            ktp = LibraryContext.ReadOneLib(ktp_id);
            txt_ktp_ad.Text = ktp[0].book.name.ToString();
            txt_ktp_sayfa.Text = ktp[0].book.page.ToString();
            txt_ktp_yazari.Text = ktp[0].book.author.ToString();
            txt_durumu.Text = ktp[0].isDelivered ? "Rafta" : "Ödünç Alınmış";
            txt_ogr_ad.Text = ktp[0].student.name.ToString();
            txt_ogr_soyad.Text = ktp[0].student.surname.ToString();
        }

        private void closelabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
