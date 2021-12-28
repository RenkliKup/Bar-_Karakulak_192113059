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
namespace Barış_Karakulak_192113059.KitapIslemleri
{
    public partial class ktpEkle : Form
    {
        public ktpEkle()
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

        private void ktpEkle_Load(object sender, EventArgs e)
        {
            string[] types = {"Roman",
            "Aşk",
            "Psikoloji",
            "Gençlik",
            "Yalnızlık",
            "Gelecek Kaygısı",
            "Vb... :("};
            combo_ktp_tip.Items.AddRange(types);
        }

        private void closelabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        BookContext BookContext = new BookContext();
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Book book = new Book(name:txt_ktp_ad.Text,
                type:combo_ktp_tip.Text,
                author:txt_ktp_yazar.Text,
                page:(int)numeric_sayfa_sayisi.Value);
            Tuple<bool, string> response;
            response=BookContext.InsertBookContext(book);
            MessageBox.Show(response.Item2, response.Item1.ToString());
        }
    }
}
