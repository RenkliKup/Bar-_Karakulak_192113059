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
        BookContext bookContext = new BookContext();
        private void btn_ara_Click(object sender, EventArgs e)
        {
            if (radio_ad_gore.Checked)
            {
                grid_kitap_sil.DataSource = bookContext.GoreAra(txt_aranan_deger.Text, "Book_name");
            }
            else
            {
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
            int id =int.Parse(grid_kitap_sil.SelectedRows[0].Cells[0].Value.ToString());
            Tuple<bool, string> response;
            response=bookContext.DeleteBookContext(id);
            MessageBox.Show(response.Item2, response.Item1.ToString());
            grid_kitap_sil.DataSource = bookContext.GetBooks();
        }
        
        private void grid_kitap_sil_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grid_kitap_sil.SelectedRows.Count > 0)
            {
                btn_sil.Enabled = true;
            }
            else
            {
                btn_sil.Enabled = false;
            }
        }

        private void ktpSil_Load(object sender, EventArgs e)
        {
            radio_ad_gore.Enabled = true;
            btn_sil.Enabled = false;
            grid_kitap_sil.DataSource = bookContext.GetBooks();

        }

        private void closelabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_aranan_deger_TextChanged(object sender, EventArgs e)
        {
            if(txt_aranan_deger.Text=="")
            {
                grid_kitap_sil.DataSource = bookContext.GetBooks();
            }
        }
    }
}
