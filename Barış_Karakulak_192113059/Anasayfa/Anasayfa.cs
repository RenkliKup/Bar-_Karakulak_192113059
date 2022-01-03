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
using Barış_Karakulak_192113059.zed;
namespace Barış_Karakulak_192113059
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
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
        //Kütüphane objesi oluşturdum
        LibraryContext LibraryContext = new LibraryContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            //Tuple<bool,string> şeklinde response adında bir degisken oluşturdum 
            Tuple<bool, string> response;
            //response degiskenini borc güncelleme fonksiyonunu atıyorum
            response= LibraryContext.DebtUpdate();
            //studentcontext classından oluşturduğum student objesi
            StudentContext student = new StudentContext();
            //bookcontext classından oluşturduğum book objesi
            BookContext book = new BookContext();
            //txt_ogr_sayi textbox'ına öğrencilerin sayısını attım 
            txt_ogr_sayi.Text = student.GetStudents().Count().ToString();
            //txt_ktp_sayi textbox'ına kitapların sayısını attım 
            txt_ktp_sayi.Text = book.GetBooks().Count().ToString();
            
        }

        private void closelabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ogr_islemleri_Click(object sender, EventArgs e)
        {
            //ogrAnasayfa form objesi oluşturdum  
            OgrenciIslemleri.ogrAnasayfa ogrAnasayfa = new OgrenciIslemleri.ogrAnasayfa();
            //ogrAnasayfa form objesini gösteriyorum
            ogrAnasayfa.Show();
        }

        private void btn_ktp_islemleri_Click(object sender, EventArgs e)
        {
            //ktpAnasayfa form objesi oluşturdum  
            KitapIslemleri.ktpAnasayfa ktpAnasayfa = new KitapIslemleri.ktpAnasayfa();
            //ktpAnasayfa form objesini gösteriyorum
            ktpAnasayfa.Show();

        }

        private void btn_odunc_al_Click(object sender, EventArgs e)
        {
            //ktpOduncAl form objesi oluşturdum  
            oduncAl.ktpOduncAl ktpOduncAl = new oduncAl.ktpOduncAl();
            //ktpOduncAl form objesini gösteriyorum  
            ktpOduncAl.Show();
        }

        private void btn_iade_et_Click(object sender, EventArgs e)
        {
            //ktpIadeEt form objesi oluşturdum  
            iadeEt.KtpIadeEt iadeEt = new iadeEt.KtpIadeEt();
            //ktpIadeEt form objesini gösteriyorum  
            iadeEt.Show();
        }

        private void btn_zedgrapgh_Click(object sender, EventArgs e)
        {
            //zed form objesi oluşturdum 
            zed.zed form = new zed.zed();
            //zed form objesini gösteriyorum

            form.Show();
            
        }
    }
}
