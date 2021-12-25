﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Barış_Karakulak_192113059.KitapIslemleri;
namespace Barış_Karakulak_192113059.KitapIslemleri
{
    public partial class ktpAnasayfa : Form
    {
        public ktpAnasayfa()
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
        private void ktpAnasayfa_Load(object sender, EventArgs e)
        {

        }

        private void closelabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btn_sil_Click(object sender, EventArgs e)
        {
            ktpSil ktpSilForm = new ktpSil();
            ktpSilForm.Show();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            
                ktpEkle ktpEkleForm = new ktpEkle();
                ktpEkleForm.Show();
            
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            ktpGuncelle ktpGuncelleForm = new ktpGuncelle();
            ktpGuncelleForm.Show();
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            ktpListele ktpListeleForm = new ktpListele();
            ktpListeleForm.Show();
        }
    }
}
