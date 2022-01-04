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
    public partial class ogrListele : Form
    {
        public ogrListele()
        {
            InitializeComponent();
        }
        StudentContext StudentContext = new StudentContext();
        private void ogrListele_Load(object sender, EventArgs e)
        {
            //checked ozelligini true yaptım
            radio_ogr_ad.Checked = true;
            //checked ozelligini true yaptım
            radio_borc.Checked = true;
            //data_grid_listele gridine getstudents fonksiyonunu atatım
            data_grid_listele.DataSource = StudentContext.GetStudents();
            
        }

        private void data_grid_listele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            //txt_aranan_deger bos degilse
            if (txt_aranan_deger.Text != "")
            {
                //aranacakDeger degiskeni olusturdum
                //degiskene txt_aranan_deger degerini atatım
                string aranacakDeger = txt_aranan_deger.Text;
                //radio_ogr_ad checked ozelligi true ise
                if (radio_ogr_ad.Checked)
                {

                    //data_grid_listele gridine goreAra fonksiyonunu atatım
                    data_grid_listele.DataSource = StudentContext.GoreAra(aranacakDeger, "Student_name");
                }
                //radio_ogr_soyad checked ozelligi true ise

                else if (radio_ogr_soyad.Checked)
                {
                    //data_grid_listele gridine goreAra fonksiyonunu atatım

                    data_grid_listele.DataSource = StudentContext.GoreAra(aranacakDeger, "Student_surname");

                }
                //radio_ogr_id checked ozelligi true ise

                else if (radio_ogr_id.Checked)
                {
                    //data_grid_listele gridine goreAra fonksiyonunu atatım

                    data_grid_listele.DataSource = StudentContext.GoreAra(aranacakDeger, "Student_id");

                }

            }
            else
            {
                //messagebox yazdır
                MessageBox.Show("Aranacak Alanı Doldurunuz");
            }
        }

       

        //libraryContext classından obje ouşturdum
        LibraryContext LibraryContext = new LibraryContext();
        private void btn_listele_Click_1(object sender, EventArgs e)
        {
            //checked ozelligi true ise
             if(radio_borc.Checked)
                {
                //data_grid_listele borcu olanları listeledim
                data_grid_listele.DataSource = LibraryContext.BorcuOlanlar();
                }
            //checked ozelligi true ise

            else if (radio_erkek.Checked)
            {
                //data_grid_listele gorelistele olanları listeledim

                data_grid_listele.DataSource = StudentContext.GoreListele("Student_sex", true);

            }

            else
            {
                //data_grid_listele gorelistele olanları listeledim

                data_grid_listele.DataSource = StudentContext.GoreListele("Student_sex",false);

            }
        }

        private void txt_aranan_deger_TextChanged(object sender, EventArgs e)
        {
            //deger bos ise
            if(txt_aranan_deger.Text=="")
            {
                //data_grid_listele getstudents olanları listeledim
                data_grid_listele.DataSource = StudentContext.GetStudents();

            }
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
        BookContext BookContext = new BookContext();
        private void data_grid_listele_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //secilen satırların kolonları 5 den eşit veya kucuk ise
                if (data_grid_listele.SelectedRows[0].Cells.Count <= 5)
                {
                    //secilen_id degiskeni olusturdum
                    //secilen satırı gonderdim
                    int secilen_id = int.Parse(data_grid_listele.SelectedRows[0].Cells[0].Value.ToString());
                    //grid_odunc_aldigi_ktp gridine  OduncAldigiKitaplar fonksiyonunu atatım
                    grid_odunc_aldigi_ktp.DataSource = LibraryContext.OduncAldigiKitaplar(secilen_id);
                    //griddeki satırlarının for dongusuyle satır indexlerini buluyorum
                    for (int i = 0; i < grid_odunc_aldigi_ktp.Rows.Count; i++)
                    {
                        //eger secilen satırın tarihi ile suanki tarihi cıkardığımızda 0 dan kücükse
                        if ((DateTime.Parse(grid_odunc_aldigi_ktp.Rows[i].Cells[4].Value.ToString()) - DateTime.Now).Days < 0)
                        {
                            //o satırı kırmızı yap
                            grid_odunc_aldigi_ktp.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        }
                        //eger secilen satırın tarihi ile suanki tarihi cıkardığımızda 2 ise

                        else if ((DateTime.Parse(grid_odunc_aldigi_ktp.Rows[i].Cells[4].Value.ToString()) - DateTime.Now).Days == 2)
                        {
                            //o satırı sarı yap

                            grid_odunc_aldigi_ktp.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                        }
                        //borcu varsa kızmızı yap
                        else if (int.Parse(grid_odunc_aldigi_ktp.Rows[i].Cells[5].Value.ToString()) > 0)
                        {
                            //kırmızı yap
                            grid_odunc_aldigi_ktp.Rows[i].DefaultCellStyle.BackColor = Color.Red;

                        }
                        //teslim edildiyse yesil yap
                        else if (grid_odunc_aldigi_ktp.Rows[i].Cells[6].Value.ToString()!="teslim edilmedi")
                        {

                            //yesil yap
                            grid_odunc_aldigi_ktp.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                        }
                    }
                }
            }
            catch(Exception s)
            {
                //grid_odunc_aldigi_ktp degerini null yapıyorum
                grid_odunc_aldigi_ktp.DataSource = null;
            }
        }

        private void closelabel_Click(object sender, EventArgs e)
        {//formu kapat
            this.Close();
        }

        private void grid_odunc_aldigi_ktp_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)

        {
            
            
           
            
            //
        }
    }
}
