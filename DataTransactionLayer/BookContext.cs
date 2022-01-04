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
        //bookProvider objesi
        private BookProvider bookProvider = new BookProvider();
        //Kitap ekleme fonksiyonu
        public Tuple<Boolean, string> InsertBookContext(Book book)
        {
            //ınsert book tuple nesnesi donduruyor
            return bookProvider.InsertBook(book);
        }
        //kitap silme fonksiyonu
        public Tuple<Boolean, string> DeleteBookContext(int id)
        {
            //delete book tuple nesnesi donduruyor

            return bookProvider.DeleteBook(id);
        }
        //kitap güncelleme fonksiyonu

        public Tuple<Boolean, string> UpdateBookContext(int id, Book book)
        {
            //update book tuple nesnesi donduruyor

            return bookProvider.UpdateBook(book, id);
        }
        //1 kitabı getirme fonksiyonu

        public Tuple<Boolean, string, Book> getOneBook(int id)
        {
            //oneRowReadBook tuple nesnesi donduruyor

            return bookProvider.OneRowReadBook(id);
        }
        //bütün kitapları donduren fonksiyon
        public List<Book> GetBooks()
        {
            //kitap listelerini donduruyor
            return bookProvider.ReadBook();
        }
        //arama degerine gore fonksiyonu
        public List<Book> GoreAra(string arananDeger,string satirAdi)
        {
            //kitap listesi donduruyor
            return bookProvider.GoreAra(arananDeger,satirAdi);
        }
        //alinmamıs kitapları donduren fonksiyon
        public List<Book> AlinmamisKitaplar()
        {
            //kitap listesi donduruyor
            return bookProvider.AlinmamisKitaplar();
        }
        //alinmis kitapları donduren fonksiyon
        public List<Book> AlinmisKitaplar()
        {
            //kitap listesini donduruyor
            return bookProvider.AlinmisKitaplar();
        }
        //odunc alan fonksiyon
        public Tuple<Boolean, string> oduncAl(int bookId)
        {
            //tuple nesnesi donduruyor
            return bookProvider.oduncAl(bookId);
        }
        //kitabı geri veren fonksiyon 
        public Tuple<Boolean, string> geriVer(int bookId)
        {
            //tuple nesnesi donduruyor
            return bookProvider.geriVer(bookId);
        }
    }
}
