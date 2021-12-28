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
    public partial class ktpGuncelle : Form
    {
        public ktpGuncelle()
        {
            InitializeComponent();
        }

        private void closelabel_Click(object sender, EventArgs e)
        {
            this.Close();
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
        BookContext bookContext = new BookContext();
        private void ktpGuncelle_Load(object sender, EventArgs e)
        {
            radio_ad_gore.Checked = true;
            grid_ktp_guncelle.DataSource = bookContext.GetBooks();
            txt_ktp_id.Enabled = false;
            numeric_ktp_sayfa.Maximum = 100000;
            btn_ktp_guncelle.Enabled = false;
            string[] types = {"Roman",
            "Aşk",
            "Psikoloji",
            "Gençlik",
            "Yalnızlık",
            "Gelecek Kaygısı",
            "Vb... :("};
            combo_ktp_tip.Items.AddRange(types);
        }
        

        private void grid_ktp_guncelle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_ktp_id.Text = grid_ktp_guncelle.SelectedRows[0].Cells[0].Value.ToString();
                txt_ktp_name.Text = grid_ktp_guncelle.SelectedRows[0].Cells[1].Value.ToString();
                combo_ktp_tip.Text = grid_ktp_guncelle.SelectedRows[0].Cells[2].Value.ToString();
                txt_ktp_yazar.Text = grid_ktp_guncelle.SelectedRows[0].Cells[3].Value.ToString();
                numeric_ktp_sayfa.Value = int.Parse(grid_ktp_guncelle.SelectedRows[0].Cells[4].Value.ToString());
            }
            catch
            {
                txt_ktp_id.Text = "";
                txt_ktp_name.Text = "";
                combo_ktp_tip.Text = "";
                txt_ktp_yazar.Text = "";
                numeric_ktp_sayfa.Value = 0;
            }
            
        }

        private void txt_ktp_id_TextChanged(object sender, EventArgs e)
        {
            if(txt_ktp_id.Text=="")
            {
                btn_ktp_guncelle.Enabled = false;
            }
            else
            {
                btn_ktp_guncelle.Enabled = true;
            }

        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            if(radio_ad_gore.Checked)
            {
                grid_ktp_guncelle.DataSource = bookContext.GoreAra(txt_aranan_deger.Text,"Book_name");
            }
            else
            {
                grid_ktp_guncelle.DataSource = bookContext.GoreAra(txt_aranan_deger.Text, "Book_author");

            }
        }

        private void btn_ktp_guncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_ktp_id.Text);
            Book book = new Book(
                name:txt_ktp_name.Text,
                type:combo_ktp_tip.Text,
                author:txt_ktp_yazar.Text,
                (int)numeric_ktp_sayfa.Value
                );
            Tuple<bool, string> response;
            response= bookContext.UpdateBookContext(id, book);
            MessageBox.Show(response.Item2, response.Item1.ToString());
            grid_ktp_guncelle.DataSource = bookContext.GetBooks();

        }
    }
}
