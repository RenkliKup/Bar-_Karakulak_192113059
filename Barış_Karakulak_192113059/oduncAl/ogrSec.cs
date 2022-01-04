using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Barış_Karakulak_192113059.oduncAl;
using DataTransactionLayer;
namespace Barış_Karakulak_192113059.oduncAl
{
    public partial class ogrSec : Form
    {
       //ktpOduncAl formunda form adında bir obje oluşturdum
        ktpOduncAl form;
        //ogrSec Constructerı
        public ogrSec(ktpOduncAl form)
        {
            InitializeComponent();
            //contructer parametresini this.form a atıyorum
            this.form = form;
        }

        
        private void ogrSec_Load(object sender, EventArgs e)
        {
            //btn_sec enabled ozelligini deaktiflestiriyorum
            btn_sec.Enabled = false;
            //radio_ad_gore checked ozelligini aktiflestiriyorum
            radio_ad_gore.Checked = true;
            //data_grid_listele gridine GetStudents fonksiyonunu atıyoruö
            data_grid_listele.DataSource = StudentContext.GetStudents();
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
        private void closelabel_Click(object sender, EventArgs e)
        {
            //formu kapatıyorum
            this.Close();
        }

        private void data_grid_listele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //data_grid_listele secilen satır sayısı 0 dan buyukse
            if (data_grid_listele.SelectedRows.Count > 0)
            {
                //btn_sec enabled aktiflestiriyorum
                btn_sec.Enabled = true;
            }
            else
            {
                //btn_sec enabled deaktiflestiriyorum
                btn_sec.Enabled = false;
            }
        }
        //studentcontext classından studentcontext objesi oluşturdum
        StudentContext StudentContext = new StudentContext();
        private void btn_ara_Click(object sender, EventArgs e)
        {
            //eger txt_aranan_deger bos degil ise
            if (txt_aranan_deger.Text != "")
            {
                //string tipinde aranacakDeger adında bir degisken oluşturdum
                //arancakDeger degerine txt_aranan_deger degerini atıyorum
                string aranacakDeger = txt_aranan_deger.Text;
                //radio_ad_gore checked ozelligi true ise
                if (radio_ad_gore.Checked)
                {

                    //data_grid_listele gridine goreAra fonksiyonu atıyorum
                    data_grid_listele.DataSource = StudentContext.GoreAra(aranacakDeger, "Student_name");
                }
                //eger radio_soyad_gore checked ozelligi true ise
                else if (radio_soyad_gore.Checked)
                {
                    //data_grid_listele gridine goreAra fonksiyonunu atıyorum
                    data_grid_listele.DataSource = StudentContext.GoreAra(aranacakDeger, "Student_surname");

                }
            }
            else
            {
                //messagebox yazdır
                MessageBox.Show("Aranacak Alanı Doldurunuz");
            }
        }

        private void btn_sec_Click(object sender, EventArgs e)
        {
            //string tipinde id adında bir degisken oluşturdum
            //id degiskenine data_grid_listele secilen kolonun degerini atıyorum
            string id = data_grid_listele.SelectedRows[0].Cells[0].Value.ToString();
            //string tipinde name adında bir degisken oluşturdum
            //name degiskenine data_grid_listele secilen kolonun degerini atıyorum
            string name = data_grid_listele.SelectedRows[0].Cells[1].Value.ToString();
            //string tipinde surname adında bir degisken oluşturdum
            //surname degiskenine data_grid_listele secilen kolonun degerini atıyorum
            string surname = data_grid_listele.SelectedRows[0].Cells[2].Value.ToString();
            //form.txt_id textbox ına id degerini atıyorum
            form.txt_id.Text = id;
            //form.txt_adi textbox ına name degerini atıyorum
            form.txt_adi.Text = name;
            //form.txt_soyad textbox ına surname degerini atıyorum
            form.txt_soyad.Text = surname;
            //formu kapat
            this.Close();
        }
    }
}
