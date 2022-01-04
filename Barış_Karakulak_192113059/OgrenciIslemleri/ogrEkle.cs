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
namespace Barış_Karakulak_192113059.OgrenciIslemleri
{
    public partial class ogrEkle : Form
    {
        public ogrEkle()
        {
            InitializeComponent();
        }

        private void ogrEkle_Load(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closelabel_Click(object sender, EventArgs e)
        {
            //formu kapat
            this.Close();
        }

        private void btn_ogr_ekle_Click(object sender, EventArgs e)
        {
            //string tipinde ogr_name adında bir degisken oluşturdum
            //ogr_name degiskenine txt_ogr_ad degerini atatım
            string ogr_name = txt_ogr_ad.Text;
            //string tipinde ogr_surname adında bir degisken oluşturdum
            //ogr_surname degiskenine txt_ogr_soyad degerini atatım
            string ogr_surname = txt_ogr_soyad.Text;
            //bool tipinde ogr_sex adında bir degisken oluşturdum
            //ogr_sex degiskenine true veya false degerini atatım
            Boolean ogr_sex = radio_erkek.Checked ? true : false;
            //student classıdan student adında bir obje oluşturdum
            Student student = new Student(ogr_name,ogr_surname,ogr_sex);
            //studentcontext classıdan studentcontext adında bir obje oluşturdum
            StudentContext studentcontext = new StudentContext();
            //Tuple<bool, string> tipinden response adında bir degisken oluşturdum
            Tuple<bool, string> response;
            //response degiskenine InsertStudentContext fonksiyonunu atatım
            response = studentcontext.InsertStudentContext(student);
            //response.Item1 degiskeni true ise
            if (response.Item1)
            {
                //messagebox yazdır
                MessageBox.Show("Öğrenci Eklenilmiş");
            }
        }
    }
}
