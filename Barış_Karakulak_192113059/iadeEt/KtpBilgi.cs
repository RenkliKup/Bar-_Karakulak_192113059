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
        //ktpIadeEt form degiskeni oluşturdum
        KtpIadeEt form;
            
        //form dergiskenini constructera parametre olarak attım
        //ktpbilgi contructer
        public KtpBilgi(KtpIadeEt form)
        {
            InitializeComponent();
            //constructerdan gelen form parametresini this.form parametresine attım
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
        //librarycontext objesi oluşturdum
        LibraryContext LibraryContext = new LibraryContext();

        //ktpbilgi ön yükleme
        private void KtpBilgi_Load(object sender, EventArgs e)
        {
            
            //ktp_id degiskeni oluşturdum ve alinan kitapların id sini atıyorum    
            int ktp_id = int.Parse(form.grid_alinan_kitaplar.SelectedRows[0].Cells[0].Value.ToString());
            //library classından ktp adında bir liste oluşturdum
            List<Library> ktp;
            //oluşturduğum ktp listesine libraryContext objesinden getirdiğim bir kitap oku fonksiyonuna atıyorum
            //böylelikle ktp listesini dolduruyorum
            ktp = LibraryContext.ReadOneLib(ktp_id);
            //txt_ktp_ad textbox ına gridden gelen kitap adını atıyorum
            txt_ktp_ad.Text = ktp[0].book.name.ToString();
            //txt_ktp_sayfa textbox ında gridden gelen kitap sayfa sayısını atıyorum
            txt_ktp_sayfa.Text = ktp[0].book.page.ToString();
            //txt_ktp_yazari textbox ına gridden gelen kitap yazarini atıyorum
            txt_ktp_yazari.Text = ktp[0].book.author.ToString();
            //txt_durumu textbox ına gridden gelen teslim durumunu atıyorum
            txt_durumu.Text = ktp[0].book.isDelivered ? "Rafta" : "Ödünç Alınmış";
            //txt_ogr_ad textbox ına gridden gelen öğrenci adını atıyorum
            txt_ogr_ad.Text = ktp[0].student.name.ToString();
            //txt_ogr_soyad textbox ına gridden gelen ogrenci soyadını atıyorum
            txt_ogr_soyad.Text = ktp[0].student.surname.ToString();
        }

        //close label clik eventi
        private void closelabel_Click(object sender, EventArgs e)
        {
            //formu kapatıyorum
            this.Close();
        }
    }
}
