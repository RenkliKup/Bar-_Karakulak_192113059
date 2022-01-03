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
using Model;
namespace Barış_Karakulak_192113059.KitapIslemleri
{
    public partial class ktpEkle : Form
    {
        public ktpEkle()
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

        private void ktpEkle_Load(object sender, EventArgs e)
        {
            //string liste tipinde types adında içinde kitap tiplerini barındaran bir liste oluturuyorum
            string[] types = {"Roman",
            "Aşk",
            "Psikoloji",
            "Gençlik",
            "Yalnızlık",
            "Gelecek Kaygısı",
            "Vb... :("};
            //combobox a oluşturduğum listeyi atıyorum
            combo_ktp_tip.Items.AddRange(types);
        }

        private void closelabel_Click(object sender, EventArgs e)
        {
            //formu kapatıyorum
            this.Close();
        }
        //bookContext class ından bookcontext adında bir obje oluşturuyorum
        BookContext BookContext = new BookContext();
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            //book clasından book objesi oluşturuyorum ve içine name,type,,author,page degerlerini atyorum
            Book book = new Book(name:txt_ktp_ad.Text,
                type:combo_ktp_tip.Text,
                author:txt_ktp_yazar.Text,
                page:(int)numeric_sayfa_sayisi.Value);
            //Tuple<bool, string> tipinden response adında bir degisken tanımlıyorum
            Tuple<bool, string> response;
            //response degiskenine bookcontext ten gelen InsertBookContext fonksiyonunun döndürdüğü şeyleri atıyorum
            response=BookContext.InsertBookContext(book);
            //eger response.Item1 degeri true ise
            if (response.Item1)
            {
                //messagebox gösterilmistir
                MessageBox.Show("Eklenilmiş");
            }
        }
    }
}
