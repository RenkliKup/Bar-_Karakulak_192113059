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
        //ktpiadeet ön yükleme
        private void KtpIadeEt_Load(object sender, EventArgs e)
        {
            //txt_ad enabled ozelligini deaktifleştiriyorum
            txt_ad.Enabled = false;
            //txt_id enabled ozelligini deaktifleştiriyorum
            txt_id.Enabled = false;
            //txt_soyad enabled ozelligini deaktifleştiriyorum
            txt_soyad.Enabled = false;
            //btn_iade_et enabled ozelligini deaktifleştiriyorum
            btn_iade_et.Enabled = false;
            
        }
        //closelabel click eventi
        private void closelabel_Click(object sender, EventArgs e)
        {
            //formu kapatma
            this.Close();
        }
        //bookcontext classından bookcontext objesi oluşturdum
        BookContext BookContext = new BookContext();
        //kitap iade et butonu
        private void button2_Click(object sender, EventArgs e)
        {
            //eğer grid_alinan_kitaplar da selecilent satırların sayısı sıfırdan büyükse
         if(grid_alinan_kitaplar.SelectedRows.Count>0)
            {
                //integer tipinde lib_secilen_id degiskeni oluşturdum
                //lib_secilen_id degiskenine grid_alinan_kitaplar da secilen satırın 0. kolonunun degerini atıyorum
                int lib_secilen_id = int.Parse(grid_alinan_kitaplar.SelectedRows[0].Cells[0].Value.ToString());

                //integer tipinde book_secilen_id degiskeni oluşturdum
                //book_secilen_id degiskenine grid_alinan_kitaplar da secilen satırın 2. kolonunun degerini atıyorum
                int book_secilen_id = int.Parse(grid_alinan_kitaplar.SelectedRows[0].Cells[2].Value.ToString());
                //tuple<bool,string> tipinde response adında bir değişken oluşturuyorum
                Tuple<bool, string> response;
                //tuple<bool,string> tipinde response2 adında bir değişken oluşturuyorum
                Tuple<bool, string> response2;
                //response degiskenini returnbookdan gelen degeri atıyorum
                response = LibraryContext.returnBook(lib_secilen_id);
                //response2 degiskenini returnbookdan gelen degeri atıyorum
                response2 = BookContext.geriVer(book_secilen_id);
                //response.Item1 degeri ve respınse2.Item1 degeri true ise
                if(response.Item1 && response2.Item1)
                {
                    //messagebox.show dondur
                    MessageBox.Show("İade Edildi");
                }
                //integer tipinde id ismine bir degisken oluşturdum
                //bu degiskene txt_id den gelen degeri atıyorum
                int id = int.Parse(txt_id.Text);
                //grid_alinan_kitaplar griddine LibraryContextden gelen teslimEtmedigiKitaplar listesini atıyorum
                grid_alinan_kitaplar.DataSource = LibraryContext.teslimEtmedigiKitaplar(id);
                //grid_alinan_kitaplar griddine LibraryContextden gelen teslimEtigiKitaplar listesini atıyorum
                grid_teslim_ettigi_ktp.DataSource = LibraryContext.teslimEtigiKitaplar(id);
                
            }

            


        }

        private void txt_ad_TextChanged(object sender, EventArgs e)
        {

        }
        //ogrenci secme butonu
        //click eventi
        private void button1_Click(object sender, EventArgs e)
        {
            //ogrsec formunun objesini oluşturuyorum oluşturuyorum
            ogrSec ogrSec = new ogrSec(this);
            //ogrsec objesini gosteriyorum
            ogrSec.Show();
        }
        //librarycontext classıdan librarycontext objesi oluşturdum
        LibraryContext LibraryContext = new LibraryContext();
        //txt_id textboxu degeri degistiginde
        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            //integer tipinde id isminde degisken oluşturdum
            //degiskene txt_id den gelen degeri atıyorum
            int id = int.Parse(txt_id.Text);
            //grid_alinan_kitaplar griddine LibraryContextden gelen teslimEtmedigiKitaplar listesini atıyorum

            grid_alinan_kitaplar.DataSource = LibraryContext.teslimEtmedigiKitaplar(id);
            //grid_alinan_kitaplar griddine LibraryContextden gelen teslimEtigiKitaplar listesini atıyorum

            grid_teslim_ettigi_ktp.DataSource = LibraryContext.teslimEtigiKitaplar(id);


        }

        //grid_alinan_kitaplar kolona tıklandığında
        //cellclick eventi
        private void grid_alinan_kitaplar_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //grid_alinan_kitaplar secilen satır sayısı sıfırdan büyükse
            if (grid_alinan_kitaplar.SelectedRows.Count > 0)
            {
                //btn_iade_et enable özelliğini aktifleştiriyorum
                btn_iade_et.Enabled = true;
                
            }
            else
            {
                //btn_iade_et enable özelliğini deaktifleştiriyorum
                btn_iade_et.Enabled = false;
            }

        }
        //grid_alinan_kitaplar kolonuna çift tıklanırsa
        private void grid_alinan_kitaplar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //grid_alinan_kitaplar secilen satır sayısı sıfırdan büyükse

            if (grid_alinan_kitaplar.SelectedRows.Count>0)
            {
                //ktpibilgi formunun objesini oluşturdum
                KtpBilgi form = new KtpBilgi(this);
                //formu gosteriyorum
                form.Show();
            }

        }
    }
}
