using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Barış_Karakulak_192113059.OgrenciIslemleri;
namespace Barış_Karakulak_192113059.OgrenciIslemleri
{
    public partial class ogrAnasayfa : Form
    {
        public ogrAnasayfa()
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
        private void OgrenciIslemleri_Load(object sender, EventArgs e)
        {

        }
       

        private void closelabel_Click(object sender, EventArgs e)
        {
            //formu kapat
            this.Close();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            //ogrEkle formunun ogrEkleForm adında bir objesini oluşturuyorum
            ogrEkle ogrEkleForm = new ogrEkle();
            //ogrEkleForm objesini gosteriyorum
            ogrEkleForm.Show();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            //ogrSil formunun ogrSilForm adında bir objesini oluşturuyorum
            OgrSil ogrSilForm = new OgrSil();
            //ogrSilForm objesini gosteriyorum
            ogrSilForm.Show();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            //ogrGuncelle formunun ogrGuncelleForm adında bir objesini oluşturuyorum
            ogrGuncelle ogrGuncelleForm = new ogrGuncelle();
            //ogrGuncelleForm objesini gosteriyorum
            ogrGuncelleForm.Show();
        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            //ogrListele formunun ogrListeleForm adında bir objesini oluşturuyorum
            ogrListele ogrListeleForm = new ogrListele();
            ogrListeleForm.Show();
        }
    }
}
