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
namespace Barış_Karakulak_192113059.oduncAl
{
    public partial class ktpOduncAl : Form
    {

       

        public ktpOduncAl()
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
        private void ktpOduncAl_Load(object sender, EventArgs e)
        {
            //grid_listele
            grid_listele.DataSource = bookContext.GetBooks();
            radio_ad_gore.Checked = true;
            btn_odunc_al.Enabled = false;
            txt_id.Enabled = false;
            txt_adi.Enabled = false;
            btn_uzat.Enabled = false;
            txt_soyad.Enabled = false;

        }
        BookContext bookContext = new BookContext();
        private void btn_ara_Click(object sender, EventArgs e)
        {
           
            if (radio_ad_gore.Checked)
            {
                grid_listele.DataSource = bookContext.GoreAra(txt_aranan_deger.Text, "Book_name");
            }
            else
            {
                grid_listele.DataSource = bookContext.GoreAra(txt_aranan_deger.Text, "Book_author");

            }
        }

        private void txt_aranan_deger_TextChanged(object sender, EventArgs e)
        {
            if(txt_aranan_deger.Text=="")
            {
                grid_listele.DataSource = bookContext.GetBooks();

            }

        }
        LibraryContext LibraryContext = new LibraryContext();
        private void grid_listele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void btn_odunc_al_Click(object sender, EventArgs e)
        {
            if (!bool.Parse(grid_listele.SelectedRows[0].Cells[5].Value.ToString()))
            {
                MessageBox.Show("Bu kitap alınmış");
                return;
            }
            int bookId= int.Parse(grid_listele.SelectedRows[0].Cells[0].Value.ToString());
            int StudentId =int.Parse(txt_id.Text);
            Tuple<bool, string> response;
            Tuple<bool, string> response2;

            response = LibraryContext.InsertLibraryContext(bookId, StudentId);
            response2 = bookContext.oduncAl(bookId);
            if (response.Item1 && response2.Item1)
            {
                MessageBox.Show("Ödünç Alındı");
            }


            int ogr_id = int.Parse(txt_id.Text);
            grid_listele.DataSource = bookContext.GetBooks();
            grid_odunc_alinan_ktp.DataSource = LibraryContext.teslimEtmedigiKitaplar(ogr_id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ogrSec ogrSec = new ogrSec(this);
            ogrSec.ShowDialog();
            
        }

        private void closelabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        LibraryProvider LibraryProvider = new LibraryProvider();
        private void grid_listele_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (grid_listele.SelectedRows.Count > 0 && txt_id.Text!="")
            {
                
                btn_odunc_al.Enabled = true;
               
            }
            else
            {
                btn_odunc_al.Enabled = false;
            }
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            int ogr_id = int.Parse(txt_id.Text);
            grid_odunc_alinan_ktp.DataSource = LibraryContext.teslimEtmedigiKitaplar(ogr_id);

        }

        private void btn_uzat_Click(object sender, EventArgs e)
        {
            if(grid_odunc_alinan_ktp.SelectedRows.Count>0)
            {
                int id =int.Parse(grid_odunc_alinan_ktp.SelectedRows[0].Cells[0].Value.ToString());
                Tuple<bool, string> response;
                response=LibraryContext.extendExpiryDateContext(id);
                
                if (response.Item1)
                {
                    MessageBox.Show("İade Edildi");
                }
                int ogr_id = int.Parse(txt_id.Text);
                grid_odunc_alinan_ktp.DataSource = LibraryContext.teslimEtmedigiKitaplar(ogr_id);
            }
        }

        private void grid_odunc_alinan_ktp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grid_odunc_alinan_ktp.SelectedRows.Count > 0)
            {
                btn_uzat.Enabled = true;
            }
            else
            {
                btn_uzat.Enabled = false;
            }
        }
    }
}
