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
    public partial class ktpListele : Form
    {
        public ktpListele()
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
        private void metroUserControl1_Load(object sender, EventArgs e)
        {

        }
        BookContext bookContext = new BookContext();
        private void ktpListele_Load(object sender, EventArgs e)
        {
            grid_listele.DataSource = bookContext.GetBooks();
            radio_ad_gore.Checked = true;
            radio_alinmamis_ktp.Checked = true;

        }

        private void closelabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

        private void grid_listele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int ktpId =int.Parse(grid_listele.SelectedRows[0].Cells[0].Value.ToString());
                grid_odunc_aldigi_ogr.DataSource= LibraryContext.OduncAldigiOgrenciler(ktpId);
            }
            catch
            {
                grid_odunc_aldigi_ogr.DataSource = null;
            }
        }
        LibraryContext LibraryContext = new LibraryContext();
        private void btn_listele_Click(object sender, EventArgs e)
        {
            if(radio_alinmamis_ktp.Checked)
            {
               grid_listele.DataSource= bookContext.AlinmamisKitaplar();
            }
            else
            {
                grid_listele.DataSource = bookContext.AlinmisKitaplar();

            }
        }
    }
}
