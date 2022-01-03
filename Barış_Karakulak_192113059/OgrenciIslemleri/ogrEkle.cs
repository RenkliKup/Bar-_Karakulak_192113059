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
            this.Close();
        }

        private void btn_ogr_ekle_Click(object sender, EventArgs e)
        {
            string ogr_name = txt_ogr_ad.Text;
            string ogr_surname = txt_ogr_soyad.Text;
            Boolean ogr_sex = radio_erkek.Checked ? true : false;
            Student student = new Student(ogr_name,ogr_surname,ogr_sex);   
            StudentContext studentcontext = new StudentContext();
            Tuple<bool, string> response;
            
            response= studentcontext.InsertStudentContext(student);
            if (response.Item1)
            {
                MessageBox.Show("Öğrenci Eklenilmiş");
            }
        }
    }
}
