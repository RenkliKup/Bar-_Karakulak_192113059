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
        StudentContext StudentContext = new StudentContext();
        private void ogrGuncelle_Load(object sender, EventArgs e)
        {
            txt_guncelle_id.Enabled = false;
            radio_ogr_ad.Checked = true;
            btn_guncelle.Enabled = false;
            dataGrid_Ogr_guncelle.DataSource = StudentContext.GetStudents();
            
        }

        private void closelabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            if(txt_aranan_deger.Text!="")
            {
                string aranacakDeger = txt_aranan_deger.Text;
                if (radio_ogr_ad.Checked)
                {

                    
                    dataGrid_Ogr_guncelle.DataSource= StudentContext.GoreAra(aranacakDeger, "Student_name");
                }
                else if(radio_ogr_soyad.Checked)
                {
                    dataGrid_Ogr_guncelle.DataSource = StudentContext.GoreAra(aranacakDeger, "Student_surname");

                }
                else if (radio_ogr_id.Checked)
                {
                    dataGrid_Ogr_guncelle.DataSource = StudentContext.GoreAra(aranacakDeger, "Student_id");

                }

            }
            else
            {
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
            if(txt_guncelle_id.Text=="")
            {
                btn_guncelle.Enabled = false;
                
            }
            else
            {
                btn_guncelle.Enabled = true;

            }

        }

        private void dataGrid_Ogr_guncelle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                txt_guncelle_id.Text =dataGrid_Ogr_guncelle.SelectedRows[0].Cells[0].Value.ToString();
                txt_guncelle_ad.Text =dataGrid_Ogr_guncelle.SelectedRows[0].Cells[1].Value.ToString();
                txt_guncelle_soyad.Text =dataGrid_Ogr_guncelle.SelectedRows[0].Cells[2].Value.ToString();
                bool guncelle_ogr_sex = Boolean.Parse(dataGrid_Ogr_guncelle.SelectedRows[0].Cells[3].Value.ToString());

                if (guncelle_ogr_sex)
                {
                    radio_guncelle_erkek.Checked = true;
                }
                else
                {
                    radio_guncelle_kadin.Checked = true;
                }

            }
            catch
            {
                txt_guncelle_id.Text = "";
                txt_guncelle_ad.Text = "";
                txt_guncelle_soyad.Text = "";
                radio_guncelle_erkek.Checked = false;
                radio_guncelle_kadin.Checked = false;
            }
        }

        private void txt_aranan_deger_ClearClicked()
        {

        }

        private void txt_aranan_deger_TextChanged(object sender, EventArgs e)
        {
            if(txt_aranan_deger.Text=="")
            {
                dataGrid_Ogr_guncelle.DataSource = StudentContext.GetStudents();

            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_guncelle_id.Text);
            string name = txt_guncelle_ad.Text;
            string surname = txt_guncelle_soyad.Text;
            bool sex = radio_guncelle_erkek.Checked ? true : false;
            Student student = new Student(name, surname, sex);
            Tuple<bool, string> response;
            response= StudentContext.UpdateStudentContext(id, student);
            if (response.Item1)
            {
                MessageBox.Show("Öğrenci Güncellendi");
            }
        }
    }
}
