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
            btn_sil.Enabled = false;
            metroGrid1.DataSource = StudentContext.GetStudents();
        }
        



        StudentContext StudentContext = new StudentContext();
        private void closelabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (txt_aranan_deger.Text != "")
            {
                string aranacakDeger = txt_aranan_deger.Text;
                if (radio_ogr_ad.Checked)
                {


                    metroGrid1.DataSource = StudentContext.GoreAra(aranacakDeger, "Student_name");
                }
                else if (radio_ogr_soyad.Checked)
                {
                    metroGrid1.DataSource = StudentContext.GoreAra(aranacakDeger, "Student_surname");

                }
                else if (radio_ogr_id.Checked)
                {
                    metroGrid1.DataSource = StudentContext.GoreAra(aranacakDeger, "Student_id");

                }

            }
            else
            {
                MessageBox.Show("Aranacak Alanı Doldurunuz");
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(metroGrid1.SelectedRows[0].Cells[0].Value.ToString());
            Tuple<bool, string> response;
            response = StudentContext.DeleteStudentContext(id);
            MessageBox.Show(response.Item2, response.Item1.ToString());
            metroGrid1.DataSource = StudentContext.GetStudents();

        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if(metroGrid1.SelectedRows.Count>0)
            {
                btn_sil.Enabled = true;
            }
            else
            {
                btn_sil.Enabled = false;
            }
            
        }

        private void txt_aranan_deger_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_aranan_deger_TextChanged(object sender, EventArgs e)
        {
            if(txt_aranan_deger.Text=="")
            {
                metroGrid1.DataSource = StudentContext.GetStudents();

            }
        }

        private void zedGraphControl1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
