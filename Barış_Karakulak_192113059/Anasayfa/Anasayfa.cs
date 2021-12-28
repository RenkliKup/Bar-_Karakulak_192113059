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
namespace Barış_Karakulak_192113059
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
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
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = (DateTime.Now- new DateTime(2023, 3, 2)).TotalDays.ToString();
            StudentContext student = new StudentContext();
            BookContext book = new BookContext();
            txt_ogr_sayi.Text = student.GetStudents().Count().ToString();
            txt_ktp_sayi.Text = book.GetBooks().Count().ToString();
           
        }

        private void closelabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ogr_islemleri_Click(object sender, EventArgs e)
        {
            OgrenciIslemleri.ogrAnasayfa ogrAnasayfa = new OgrenciIslemleri.ogrAnasayfa();
            ogrAnasayfa.Show();
        }

        private void btn_ktp_islemleri_Click(object sender, EventArgs e)
        {
            KitapIslemleri.ktpAnasayfa ktpAnasayfa = new KitapIslemleri.ktpAnasayfa();
            ktpAnasayfa.Show();

        }

        private void btn_odunc_al_Click(object sender, EventArgs e)
        {
            oduncAl.ktpOduncAl ktpOduncAl = new oduncAl.ktpOduncAl();
            ktpOduncAl.Show();
        }

        private void btn_iade_et_Click(object sender, EventArgs e)
        {
            iadeEt.KtpIadeEt iadeEt = new iadeEt.KtpIadeEt();
            iadeEt.Show();
        }
    }
}
