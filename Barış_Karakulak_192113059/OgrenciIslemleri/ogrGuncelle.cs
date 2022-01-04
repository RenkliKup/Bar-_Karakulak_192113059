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
    public partial class ogrGuncelle : Form
    {
        public ogrGuncelle()
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
        //studentcontnext classından studentcontext objesi oluşturdum
        StudentContext StudentContext = new StudentContext();
        private void ogrGuncelle_Load(object sender, EventArgs e)
        {
            //txt_guncelle_id enabled ozelligini deaktiflestirdim
            txt_guncelle_id.Enabled = false;
            //radio_ogr_ad checked ozelligini aktiflestirdim
            radio_ogr_ad.Checked = true;
            //btn_guncelle enabled ozelligini deaktiflestirdim
            btn_guncelle.Enabled = false;
            //dataGrid_Ogr_guncelle gridine GetStudents fonksiyonuyla ogrenci listesini atatım  
            dataGrid_Ogr_guncelle.DataSource = StudentContext.GetStudents();
            
        }

        private void closelabel_Click(object sender, EventArgs e)
        {//formu kapat
            this.Close();
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            //txt_aranan_deger degeri bos degilse
            if(txt_aranan_deger.Text!="")
            {
                //string tipinde aranacakDeger adında bir degisken olusturdum
                //txt_aranan_deger degiskenine txt_aranan_deger textbox ın degerini atatım
                string aranacakDeger = txt_aranan_deger.Text;
                //eger radio_ogr_ad checked ozelligi true ise
                if (radio_ogr_ad.Checked)
                {

                    //dataGrid_Ogr_guncelle gridine GoreAra fonksiyonunu atatım
                    dataGrid_Ogr_guncelle.DataSource= StudentContext.GoreAra(aranacakDeger, "Student_name");
                }
                //radio_ogr_soyad checked ozelligi true ise
                else if(radio_ogr_soyad.Checked)
                {
                    //dataGrid_Ogr_guncelle gridine GoreAra fonksiyonunu atatım

                    dataGrid_Ogr_guncelle.DataSource = StudentContext.GoreAra(aranacakDeger, "Student_surname");

                }
                //radio_ogr_id checked ozelligi true ise

                else if (radio_ogr_id.Checked)
                {
                    //dataGrid_Ogr_guncelle gridine GoreAra fonksiyonunu atatım

                    dataGrid_Ogr_guncelle.DataSource = StudentContext.GoreAra(aranacakDeger, "Student_id");

                }

            }
            else
            {
                //messeagebox yazdır
                MessageBox.Show("Aranacak Alanı Doldurunuz");
            }
        }

        private void dataGrid_Ogr_guncelle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
           




        }

        private void txt_guncelle_id_Click(object sender, EventArgs e)
        {

        }

        private void txt_guncelle_id_TextChanged(object sender, EventArgs e)
        {
            //eger txt_guncelle_id bos ise
            if(txt_guncelle_id.Text=="")
            {
                //btn_guncelle enabled ozelligini deaktiflestırıyorum
                btn_guncelle.Enabled = false;
                
            }
            else
            {
                //btn_guncelle enabled ozelligini aktiflestırıyorum

                btn_guncelle.Enabled = true;

            }

        }

        private void dataGrid_Ogr_guncelle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                //txt_guncelle_id textbox ına datagrid secilen degerini atıyorum
                txt_guncelle_id.Text =dataGrid_Ogr_guncelle.SelectedRows[0].Cells[0].Value.ToString();
                //txt_guncelle_ad textbox ına datagrid secilen degerini atıyorum
                txt_guncelle_ad.Text =dataGrid_Ogr_guncelle.SelectedRows[0].Cells[1].Value.ToString();
                //txt_guncelle_soyad textbox ına datagrid secilen degerini atıyorum
                txt_guncelle_soyad.Text =dataGrid_Ogr_guncelle.SelectedRows[0].Cells[2].Value.ToString();
                //bool tipinde guncelle_ogr_sex adında bir degisken olusturdum
                //guncelle_ogr_sex degiskenine gridine secilmis degerleri gönderiyorum
                bool guncelle_ogr_sex = Boolean.Parse(dataGrid_Ogr_guncelle.SelectedRows[0].Cells[3].Value.ToString());
                //guncelle_ogr_sec true ise
                if (guncelle_ogr_sex)
                {
                    //radio_guncelle_erkek checked ozelligini aktiflestiriyorum
                    radio_guncelle_erkek.Checked = true;
                }
                else
                {
                    //radio_guncelle_kadin checked ozelligini aktiflestiriyorum
                    radio_guncelle_kadin.Checked = true;
                }

            }
            catch
            {
                //txt_guncelle_id degerini bos olarak ayarlıyorum
                txt_guncelle_id.Text = "";
                //txt_guncelle_ad degerini bos olarak ayarlıyorum
                txt_guncelle_ad.Text = "";
                //txt_guncelle_soyad degerini bos olarak ayarlıyorum
                txt_guncelle_soyad.Text = "";
                //radio_guncelle_erkek checked ozelligini deaktiflestiriyorum
                radio_guncelle_erkek.Checked = false;
                //radio_guncelle_kadin checked ozelligini deaktiflestiriyorum
                radio_guncelle_kadin.Checked = false;
            }
        }

        private void txt_aranan_deger_ClearClicked()
        {

        }

        private void txt_aranan_deger_TextChanged(object sender, EventArgs e)
        {
            //txt_aranan_deger bos ise
            if(txt_aranan_deger.Text=="")
            {
                //dataGrid_Ogr_guncelle degerine GetStudents fonksiyonunu atatım
                dataGrid_Ogr_guncelle.DataSource = StudentContext.GetStudents();

            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            //id degiskeni olusturdum
            //degiskene txt_guncelle_id degerini atatım
            int id = Convert.ToInt32(txt_guncelle_id.Text);
            //name degiskini olusturdum 
            //txt_guncelle_ad degerini atatım name degiskenine
            string name = txt_guncelle_ad.Text;
            //surname degiskeni olusturdum
            //txt_guncelle_soyad degerini atatım degiskene
            string surname = txt_guncelle_soyad.Text;
            //sex degiskeni olusturdum
            //sex degiskenine radio_guncelle_erkek degerini atatım
            bool sex = radio_guncelle_erkek.Checked ? true : false;
            //student objesi oluşturdum
            Student student = new Student(name, surname, sex);
            //tuple degiskeni olusturdum
            Tuple<bool, string> response;
            //response degiskenine  UpdateStudentContext fonksiyonunu atatıms
            response = StudentContext.UpdateStudentContext(id, student);
            //eger response.Item1 true ise
            if (response.Item1)
            {
                //messagebox yazdır
                MessageBox.Show("Öğrenci Güncellendi");
            }
        }
    }
}
