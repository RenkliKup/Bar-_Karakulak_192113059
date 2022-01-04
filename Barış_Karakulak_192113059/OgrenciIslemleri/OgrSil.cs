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
    public partial class OgrSil : Form
    {

        public OgrSil()
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

        private void OgrSil_Load(object sender, EventArgs e)
        {
            //enabled ozelligini false yaptım
            btn_sil.Enabled = false;
            //metrogrid1 e GetStudents fonksiyonunu atadım
            metroGrid1.DataSource = StudentContext.GetStudents();
        }
        


        //studentcontext objesi olusturdum
        StudentContext StudentContext = new StudentContext();
        private void closelabel_Click(object sender, EventArgs e)
        {
            //formu kapat
            this.Close();
        }
        
        private void metroButton2_Click(object sender, EventArgs e)
        {
            //txt_aranan_deger bos degilse
            if (txt_aranan_deger.Text != "")
            {
                //aranacakDeger degiskenine txt_aranan_Degerinini atıyorum 
                string aranacakDeger = txt_aranan_deger.Text;
                //checked ozelligi true ise
                if (radio_ogr_ad.Checked)
                {

                    //metroGrid1 gridine goreAra fonksiyonunu atadım
                    metroGrid1.DataSource = StudentContext.GoreAra(aranacakDeger, "Student_name");
                }
                //checked ozelligi true ise

                else if (radio_ogr_soyad.Checked)
                {
                    //metroGrid1 gridine goreAra fonksiyonunu atadım
                    metroGrid1.DataSource = StudentContext.GoreAra(aranacakDeger, "Student_surname");

                
                }
                //checked ozelligi true ise

                else if (radio_ogr_id.Checked)
                {
                    //metroGrid1 gridine goreAra fonksiyonunu atadım

                    metroGrid1.DataSource = StudentContext.GoreAra(aranacakDeger, "Student_id");

                }

            }
            else
            {

                //messagebox yazdır
                MessageBox.Show("Aranacak Alanı Doldurunuz");
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //id degiskeni olusturdum
            //metroGrid1  gridini atadım 
            
            int id = int.Parse(metroGrid1.SelectedRows[0].Cells[0].Value.ToString());
            //tuple degiskeni olusturdum
            Tuple<bool, string> response;
            //response degiskenie fonksiyon atatım
            response = StudentContext.DeleteStudentContext(id);
            //response degiskeni true ise
            if (response.Item1)
            {
                //messagebox yazdur
                MessageBox.Show("Öğrenci Silindi");
            }
            //gride fonksiyon atadım
            metroGrid1.DataSource = StudentContext.GetStudents();

        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //secilen satır sayısı 0 dan buyukse
            if(metroGrid1.SelectedRows.Count>0)
            {
                //enabled true
                btn_sil.Enabled = true;
            }
            else
            {
                //enable false
                btn_sil.Enabled = false;
            }
            
        }

        private void txt_aranan_deger_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_aranan_deger_TextChanged(object sender, EventArgs e)
        {
            //txt_aranan_deger bos ise
            if(txt_aranan_deger.Text=="")
            {
                //gridi doldur
                metroGrid1.DataSource = StudentContext.GetStudents();

            }
        }

        private void zedGraphControl1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
