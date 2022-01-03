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
        //bookcontext classından bookcontext isminde bir obje 
        BookContext bookContext = new BookContext();
        private void ktpListele_Load(object sender, EventArgs e)
        {
            //grid_listele gridine bookcontextten gelen getbooks fonksiyonunun listesini atıyorum
            grid_listele.DataSource = bookContext.GetBooks();
            //radio_ad_gore checked ozelligini aktiflesiriyorum
            radio_ad_gore.Checked = true;
            //radio_alinmamis_ktp checked ozelligini aktiflesiriyorum

            radio_alinmamis_ktp.Checked = true;

        }

        private void closelabel_Click(object sender, EventArgs e)
        {
            //formu kapatıyorum
            this.Close();
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            //radio_ad_gore checked özelliği true ise
            if (radio_ad_gore.Checked)
            {
                //grid_listele nin datasoruce a bookcontextten gelen goreAra fonksiyonunu atıyorum
                grid_listele.DataSource = bookContext.GoreAra(txt_aranan_deger.Text, "Book_name");
            }
            else
            {
                //grid_listele nin datasoruce a bookcontextten gelen goreAra fonksiyonunu atıyorum
                grid_listele.DataSource = bookContext.GoreAra(txt_aranan_deger.Text, "Book_author");

            }
        }

        private void grid_listele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //integer tipinde ktpId adında bir degisken olusturdum
                //grid_listele de secilen degerleri atıyorum
                int ktpId =int.Parse(grid_listele.SelectedRows[0].Cells[0].Value.ToString());
                //oducAldigiOgrenciler fonksiyonunu gride atıyorum
                grid_odunc_aldigi_ogr.DataSource= LibraryContext.OduncAldigiOgrenciler(ktpId);
            }
            catch
            {
                //gride null degeri atıyorum

                grid_odunc_aldigi_ogr.DataSource = null;
            }
        }
        //librarycontext classından librarycontext objesi atıyorum
        LibraryContext LibraryContext = new LibraryContext();
        private void btn_listele_Click(object sender, EventArgs e)
        {
            //eger radio_alinmamis_ktp checked ozelligi true ise
            if(radio_alinmamis_ktp.Checked)
            {
                //alinmamiskitaplar ı gride atıyorum
               grid_listele.DataSource= bookContext.AlinmamisKitaplar();
            }
            else
            {
                //alinmiskitaplar ı gride atıyorum

                grid_listele.DataSource = bookContext.AlinmisKitaplar();

            }
        }

        private void radio_alinmis_ktp_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
