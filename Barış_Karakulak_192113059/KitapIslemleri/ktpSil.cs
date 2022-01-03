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
    public partial class ktpSil : Form
    {
        public ktpSil()
        {
            InitializeComponent();
        }
        //bookcontext classından bookcontext objesi oluşturuyorum
        BookContext bookContext = new BookContext();
        private void btn_ara_Click(object sender, EventArgs e)
        {
            //eger radio_ad_gore checked ozelligi true ise
            if (radio_ad_gore.Checked)
            {
                //grid_kitapsil gridine goreAra fonksiyoununu aktarıyorum
                grid_kitap_sil.DataSource = bookContext.GoreAra(txt_aranan_deger.Text, "Book_name");
            }
            else
            {
                //grid_kitapsil gridine goreAra fonksiyoununu aktarıyorum
                grid_kitap_sil.DataSource = bookContext.GoreAra(txt_aranan_deger.Text, "Book_author");

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

        private void btn_sil_Click(object sender, EventArgs e)
        {
            //integer tipinde id adında bir degisken olusturdum
            //id degiskenine gridden secilen degerini atıyorum  
            int id =int.Parse(grid_kitap_sil.SelectedRows[0].Cells[0].Value.ToString());
            //tuple<bool,string> tipinde response adında bir degisken oluşturdum
            Tuple<bool, string> response;
            //response degiskenine deletebookcontext fonksiyonunu atıyorum
            response=bookContext.DeleteBookContext(id);
            //eger response.Item1 degiskeni true ise
            if (response.Item1)
            {
                //message göster
                MessageBox.Show("İade Edildi");
            }
            //grid_kitap_sil gridine getbooks fonksiyonunu atıyorum
            grid_kitap_sil.DataSource = bookContext.GetBooks();
        }
        
        private void grid_kitap_sil_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //grid_kitap_sil gridinde secilen satırlar 0 dan buyuk ise
            if (grid_kitap_sil.SelectedRows.Count > 0)
            {
                //btn_sil enable özelliğini true yapıyorum
                btn_sil.Enabled = true;
            }
            else
            {
                //btn_sil enable özelliğini false yapıyorum

                btn_sil.Enabled = false;
            }
        }

        private void ktpSil_Load(object sender, EventArgs e)
        {
            //radio_ad_gore enable özelliğini true yapıyorum

            radio_ad_gore.Enabled = true;
            //btn_sil enable özelliğini false yapıyorum

            btn_sil.Enabled = false;
            //grid_kitap_Sil gridine bookcontext getbooks degerini atıyorum
            grid_kitap_sil.DataSource = bookContext.GetBooks();

        }

        private void closelabel_Click(object sender, EventArgs e)
        {
            //formu kapatıyorum
            this.Close();
        }

        private void txt_aranan_deger_TextChanged(object sender, EventArgs e)
        {
            //eger txt_aranan_deger bos degilse
            if(txt_aranan_deger.Text=="")
            {
                //grid_kitap_sil gridine getbooks özelligini cagırıyorum
                grid_kitap_sil.DataSource = bookContext.GetBooks();
            }
        }
    }
}
