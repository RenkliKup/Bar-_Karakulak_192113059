using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DataTransactionLayer
{
    public class BookContext
    {
        private BookProvider bookProvider = new BookProvider();
        public Tuple<Boolean, string> InsertBookContext(Book book)
        {
            return bookProvider.InsertBook(book);
        }
        public Tuple<Boolean, string> DeleteBookContext(int id)
        {
            return bookProvider.DeleteBook(id);
        }
        public Tuple<Boolean, string> UpdateBookContext(int id, Book book)
        {
            return bookProvider.UpdateBook(book, id);
        }
        public Tuple<Boolean, string, Book> getOneBook(int id)
        {
            return bookProvider.OneRowReadBook(id);
        }
        public List<Book> GetBooks()
        {
            return bookProvider.ReadBook();
        }
        public List<Book> GoreAra(string arananDeger,string satirAdi)
        {
            return bookProvider.GoreAra(arananDeger,satirAdi);
        }
        public List<Book> AlinmamisKitaplar()
        {
            return bookProvider.AlinmamisKitaplar();
        }
        public List<Book> AlinmisKitaplar()
        {
            return bookProvider.AlinmisKitaplar();
        }
        public Tuple<Boolean, string> oduncAl(int bookId)
        {
            return bookProvider.oduncAl(bookId);
        }
        public Tuple<Boolean, string> geriVer(int bookId)
        {
            return bookProvider.geriVer(bookId);
        }
    }
}
