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
    public partial class ogrSec : Form
    {
        //ktpIadeET formundan form23 objesi oluşturdum 
        KtpIadeEt form23;
        //ogrSec constructerı
        //parametresini ktpIadeEt formundan form adında bir parametre atadım 
        public ogrSec(KtpIadeEt form)
        {
            InitializeComponent();

            //this.form23 degiskenine form parametresini atıyorum
            this.form23 = form;
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            //string tipinde id isminde bir degisken oluşturdum
            //bu degiskene data_grid_listele secilen satırının 0. kolununun degerini atıyorum
            string id =data_grid_listele.SelectedRows[0].Cells[0].Value.ToString();
            //string tipinde name isminde bir degisken oluşturdum
            //bu degiskene data_grid_listele secilen satırının 1. kolununun degerini atıyorum
            string name = data_grid_listele.SelectedRows[0].Cells[1].Value.ToString();
            //string tipinde surname isminde bir degisken oluşturdum
            //bu degiskene data_grid_listele secilen satırının 2. kolununun degerini atıyorum
            string surname = data_grid_listele.SelectedRows[0].Cells[2].Value.ToString();

            //form23.txt_id textboxuna id degerini atıyorum
            form23.txt_id.Text=id;
            //form23.txt_ad textboxuna name degerini atıyorum
            form23.txt_ad.Text =name;
            //form23.txt_soyad textboxuna surname degerini atıyorum
            form23.txt_soyad.Text = surname;
            //formu kapatıyorum
            this.Close();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
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
        private void ogrSec_Load(object sender, EventArgs e)
        {
            //btn_sec butonunun enabled özelliğini deaktifleştiriyorum
            btn_sec.Enabled = false;
            //radio_ad_gore checked özelliğini aktifleştiriyorum
            radio_ad_gore.Checked = true;
            //data_grid_listele gridine bütün öğrencileri atıyorum
            data_grid_listele.DataSource = StudentContext.GetStudents();
        }
        //closelabel clik eventi
        private void closelabel_Click(object sender, EventArgs e)
        {
            //formu kapatma
            this.Close();
        }
        //studentcontext class ından studentcontex adında bir nesne oluşturdum
        StudentContext StudentContext = new StudentContext();
        //btn_ara click eventi
        private void btn_ara_Click(object sender, EventArgs e)
        {
            //txt_aranan_deger textboxu boş değilse
            if (txt_aranan_deger.Text != "")
            {
                //string tipinde aranacakDeger isminde bir değisken oluşturdum
                string aranacakDeger = txt_aranan_deger.Text;
                //eger radio_ad_gore butonu tıklanmamıssa
                if (radio_ad_gore.Checked)
                {

                    //data_grid_listele griddine studentcontext objesinde goreAra fonksiyonunu atatım
                    data_grid_listele.DataSource = StudentContext.GoreAra(aranacakDeger, "Student_name");
                }
                //radio_soyad_gore butonu tıklanmıssa
                else if (radio_soyad_gore.Checked)
                {
                    //data_grid_listele gridine studentcontext objesinde goreAra fonksiyonunu atatım
                    data_grid_listele.DataSource = StudentContext.GoreAra(aranacakDeger, "Student_surname");

                }
            }
            else
            {
                //messagebox gosteriyorum
                MessageBox.Show("Aranacak Alanı Doldurunuz");
            }
        }
        //data_grid_listele kolona tıklandığında
        private void data_grid_listele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //data_grid_listele gridinde secilen satırlarında sayısı sıfırdan büyükse
            if (data_grid_listele.SelectedRows.Count>0)
            {
                //btn_sec butonunu aktiflestiriyorum
                btn_sec.Enabled = true;
            }
            else
            {
                //btn_sec butonunu deaktiflestiriyorum

                btn_sec.Enabled = false;
            }
        }
    }
}
