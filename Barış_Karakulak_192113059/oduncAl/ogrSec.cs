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
       
        ktpOduncAl form;
        public ogrSec(ktpOduncAl form)
        {
            InitializeComponent();
            this.form = form;
        }

        
        private void ogrSec_Load(object sender, EventArgs e)
        {
            btn_sec.Enabled = false;
            radio_ad_gore.Checked = true;
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
            this.Close();
        }

        private void data_grid_listele_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (data_grid_listele.SelectedRows.Count > 0)
            {
                btn_sec.Enabled = true;
            }
            else
            {
                btn_sec.Enabled = false;
            }
        }
        StudentContext StudentContext = new StudentContext();
        private void btn_ara_Click(object sender, EventArgs e)
        {
            if (txt_aranan_deger.Text != "")
            {
                string aranacakDeger = txt_aranan_deger.Text;
                if (radio_ad_gore.Checked)
                {


                    data_grid_listele.DataSource = StudentContext.GoreAra(aranacakDeger, "Student_name");
                }
                else if (radio_soyad_gore.Checked)
                {
                    data_grid_listele.DataSource = StudentContext.GoreAra(aranacakDeger, "Student_surname");

                }
            }
            else
            {
                MessageBox.Show("Aranacak Alanı Doldurunuz");
            }
        }

        private void btn_sec_Click(object sender, EventArgs e)
        {
            string id = data_grid_listele.SelectedRows[0].Cells[0].Value.ToString();
            string name = data_grid_listele.SelectedRows[0].Cells[1].Value.ToString();
            string surname = data_grid_listele.SelectedRows[0].Cells[2].Value.ToString();

            form.txt_id.Text = id;
            form.txt_adi.Text = name;
            form.txt_soyad.Text = surname;
            this.Close();
        }
    }
}
