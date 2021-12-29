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

        private void ktpOduncAl_Load(object sender, EventArgs e)
        {
            grid_listele.DataSource = bookContext.GetBooks();
            radio_ad_gore.Checked = true;
            btn_odunc_al.Enabled = false;

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
            int bookId= int.Parse(grid_listele.SelectedRows[0].Cells[0].Value.ToString());
            int StudentId =int.Parse(txt_id.Text);
            LibraryContext.InsertLibraryContext(bookId, StudentId);
            
        }
    }
}
