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
            radio_ogr_ad.Checked = true;
            radio_borc.Checked = true;
            data_grid_listele.DataSource = StudentContext.GetStudents();
            
        }

        private void data_grid_listele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            if (txt_aranan_deger.Text != "")
            {
                string aranacakDeger = txt_aranan_deger.Text;
                if (radio_ogr_ad.Checked)
                {


                    data_grid_listele.DataSource = StudentContext.GoreAra(aranacakDeger, "Student_name");
                }
                else if (radio_ogr_soyad.Checked)
                {
                    data_grid_listele.DataSource = StudentContext.GoreAra(aranacakDeger, "Student_surname");

                }
                else if (radio_ogr_id.Checked)
                {
                    data_grid_listele.DataSource = StudentContext.GoreAra(aranacakDeger, "Student_id");

                }

            }
            else
            {
                MessageBox.Show("Aranacak Alanı Doldurunuz");
            }
        }

       


        LibraryContext LibraryContext = new LibraryContext();
        private void btn_listele_Click_1(object sender, EventArgs e)
        {
             if(radio_borc.Checked)
                {
                data_grid_listele.DataSource = LibraryContext.BorcuOlanlar();
                }
             else if(radio_erkek.Checked)
            {
                data_grid_listele.DataSource = StudentContext.GoreListele("Student_sex", true);

            }

            else
            {
                data_grid_listele.DataSource = StudentContext.GoreListele("Student_sex",false);

            }
        }

        private void txt_aranan_deger_TextChanged(object sender, EventArgs e)
        {
            if(txt_aranan_deger.Text=="")
            {
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
        private void data_grid_listele_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (data_grid_listele.SelectedRows[0].Cells.Count <= 4)
                {
                    
                    int secilen_id = int.Parse(data_grid_listele.SelectedRows[0].Cells[0].Value.ToString());
                    grid_odunc_aldigi_ktp.DataSource = LibraryContext.OduncAldigiKitaplar(secilen_id,false);
                    for (int i = 0; i < grid_odunc_aldigi_ktp.Rows.Count; i++)
                    {
                        if ((DateTime.Parse(grid_odunc_aldigi_ktp.Rows[i].Cells[4].Value.ToString()) - DateTime.Now).Days < 0)
                        {
                            grid_odunc_aldigi_ktp.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        }
                        else if ((DateTime.Parse(grid_odunc_aldigi_ktp.Rows[i].Cells[4].Value.ToString()) - DateTime.Now).Days == 2)
                        {
                            grid_odunc_aldigi_ktp.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                        }
                        else if (int.Parse(grid_odunc_aldigi_ktp.Rows[i].Cells[5].Value.ToString()) > 0)
                        {
                            grid_odunc_aldigi_ktp.Rows[i].DefaultCellStyle.BackColor = Color.Red;

                        }
                        else if (bool.Parse(grid_odunc_aldigi_ktp.Rows[i].Cells[6].Value.ToString()))
                        {
                            grid_odunc_aldigi_ktp.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                        }
                    }
                }
            }
            catch(Exception s)
            {
                
                grid_odunc_aldigi_ktp.DataSource = null;
            }
        }

        private void closelabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grid_odunc_aldigi_ktp_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)

        {
            
            
           
            
            //
        }
    }
}
