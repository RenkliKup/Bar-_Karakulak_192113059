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
namespace Barış_Karakulak_192113059.oduncAl
{
    public partial class ktpOduncAl : Form
    {

       

        public ktpOduncAl()
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
        private void ktpOduncAl_Load(object sender, EventArgs e)
        {
            //grid_listele gridine bookcontext gelen getbooks fonksiyonunu atıyorum
            grid_listele.DataSource = bookContext.GetBooks();
            //radio_ad_gore checked özelligini aktiflestiriyorum
            radio_ad_gore.Checked = true;
            //btn_odunc_al enabled özelligini deaktiflestiriyorum
            btn_odunc_al.Enabled = false;
            //txt_id enabled ozelligini deaktiflestiriyorum
            txt_id.Enabled = false;
            //txt_adi enabled ozelligini deaktiflestiriyorum
            txt_adi.Enabled = false;
            //btn_uzat enabled ozelligini deaktiflestiriyorum
            btn_uzat.Enabled = false;
            //txt_soyad enabled ozelligini deaktiflestiriyorum
            txt_soyad.Enabled = false;

        }
        //bookcontext class ından bookcontext isminde bir obje oluşturuyorum
        BookContext bookContext = new BookContext();
        private void btn_ara_Click(object sender, EventArgs e)
        {
           //radio_ad_gore checked özelligi true ise
            if (radio_ad_gore.Checked)
            {
                //grid_listele gridine bookcontext goreAra fonksiyonunu atıyorum
                grid_listele.DataSource = bookContext.GoreAra(txt_aranan_deger.Text, "Book_name");
            }
            else
            {
                //grid_listele gridine bookcontext goreAra fonksiyonunu atıyorum
                grid_listele.DataSource = bookContext.GoreAra(txt_aranan_deger.Text, "Book_author");

            }
        }

        private void txt_aranan_deger_TextChanged(object sender, EventArgs e)
        {
            //txt_aranan_deger degeri boş ise
            if(txt_aranan_deger.Text=="")
            {
                //grid_listele gridine bookcontext getbooks fonksiyonunu atıyorum
                grid_listele.DataSource = bookContext.GetBooks();

            }

        }
        //librarycontext sınıfından librarycontext objesi oluşturuyorum
        LibraryContext LibraryContext = new LibraryContext();
        private void grid_listele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void btn_odunc_al_Click(object sender, EventArgs e)
        {
            //grid_listele gridinin seçilen öğesi false ise
            if (!bool.Parse(grid_listele.SelectedRows[0].Cells[5].Value.ToString()))
            {
                //messagebox yazdır
                MessageBox.Show("Bu kitap alınmış");
                //sonlandır
                return;
            }
            //integer tipinde bookId isminde bir degisken oluşturdum
            //bookId degiskeninine grid_listele gridinin secilen degerini atıyorum
            int bookId= int.Parse(grid_listele.SelectedRows[0].Cells[0].Value.ToString());
            //integer tipinde StudentId isminde bir degisken oluşturdum
            //StudentId degiskeninine txt_id degerini atıyorum
            int StudentId =int.Parse(txt_id.Text);
            //Tuple<bool,string> tipinde response adında bir degisken oluşturuyorum
            Tuple<bool, string> response;
            //Tuple<bool,string> tipinde response2 adında bir degisken oluşturuyorum
            Tuple<bool, string> response2;
            //response degiskenine librarycontext objesinden insertlibrarycontext fonksiyonunu atıyorum
            response = LibraryContext.InsertLibraryContext(bookId, StudentId);
            //response2 degiskenine bookcontext objesinden oduncAl fonksiyonunu atıyorum
            response2 = bookContext.oduncAl(bookId);
            //eger response.Item1 ve response.Item1 degerleri true ise
            if (response.Item1 && response2.Item1)
            {
                //messagebox yazdır
                MessageBox.Show("Ödünç Alındı");
            }

            //integer tipinde ogr_id adında bir degisken oluşturuyorum
            //ogr_id degiskeninie txt_id den gelen degeri atıyorum
            int ogr_id = int.Parse(txt_id.Text);
            //grid_listele gridine bookcontext den gelen getbooks fonksiyonunu atıyorum
            grid_listele.DataSource = bookContext.GetBooks();
            //grid_odunc_alinan_ktp gridine librarycontext objesinden gelen teslimEtmedigiKitaplar fonksiyounun atıyorum
            grid_odunc_alinan_ktp.DataSource = LibraryContext.teslimEtmedigiKitaplar(ogr_id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ogrSec formundan ogrSec adında bir obje oluşturuyorum
            ogrSec ogrSec = new ogrSec(this);
            //ogrSec objesini gosteriyorum
            ogrSec.ShowDialog();
            
        }

        private void closelabel_Click(object sender, EventArgs e)
        {
            //formu kapat
            this.Close();
        }
        
        private void grid_listele_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //grid_listele secilen satır sayısı 0 dan büyük ve txt_id degeri bos degil ise
            if (grid_listele.SelectedRows.Count > 0 && txt_id.Text!="")
            {
                //btn_odunc_al enabled ozelligini aktiflestiriyorum
                btn_odunc_al.Enabled = true;
               
            }
            else
            {
                //btn_odunc_al enabled ozelligini deaktiflestiriyorum
                btn_odunc_al.Enabled = false;
            }
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            //integer tipinde ogr_id isminde txt_id degerini atıyorum
            int ogr_id = int.Parse(txt_id.Text);
            //grid_odunc_alinan_ktp gridini librarycontext objesinden gelen teslimEtmedigiKitaplar fonksiyonunu atıyorum 
            grid_odunc_alinan_ktp.DataSource = LibraryContext.teslimEtmedigiKitaplar(ogr_id);

        }

        private void btn_uzat_Click(object sender, EventArgs e)
        {
            //eger grid_odunc_alinan_ktp nin secilen kolonların sayısı 0 dan büyükse
            if(grid_odunc_alinan_ktp.SelectedRows.Count>0)
            {
                //integer tipinde id adında bir degisken oluşturdum
                //id degiskenine grid_odunc_alinan_ktp secilen degerini atıyorum
                int id =int.Parse(grid_odunc_alinan_ktp.SelectedRows[0].Cells[0].Value.ToString());
                //tuple<bool,string> tipinde response adında bir degisken olusturuyorum
                Tuple<bool, string> response;
                //repsonse degiskenine extendExpiryDateContext fonksiyonunu atıyorum
                response = LibraryContext.extendExpiryDateContext(id);
                //response.Item1 degeri true ise
                if (response.Item1)
                {
                    //messagebox yazdır
                    MessageBox.Show("İade Edildi");
                }
                //integer tipine ogr_id adında bir degisken olusturuyorum
                //ogr_id degiskenine txt_id den gelen degeri atıyorum
                int ogr_id = int.Parse(txt_id.Text);
                //grid_odunc_alinan_ktp gridine teslimEtmedigiKitaplar fonksiyonunu atıyorum
                grid_odunc_alinan_ktp.DataSource = LibraryContext.teslimEtmedigiKitaplar(ogr_id);
            }
        }

        private void grid_odunc_alinan_ktp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //grid_odunc_alinan_ktp secilen kolon sayısı 0 dan buyukse
            if (grid_odunc_alinan_ktp.SelectedRows.Count > 0)
            {
                //btn_uzat enable ozelligini aktiflestiriyorum
                btn_uzat.Enabled = true;
            }
            else
            {
                //btn_uzat enable ozelligini deaktiflestiriyorum
                btn_uzat.Enabled = false;
            }
        }
    }
}
