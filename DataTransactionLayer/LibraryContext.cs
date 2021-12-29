using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DataTransactionLayer
{
    public class LibraryContext
    {
        LibraryProvider LibraryProvider = new LibraryProvider();
        public Tuple<Boolean, string> InsertLibraryContext(int bookId, int studentId)
        {
            return LibraryProvider.InsertLibrary(bookId, studentId);
        }
        public Tuple<Boolean, string> extendExpiryDateContext(int id)
        {
            return LibraryProvider.extendExpiryDate(id);
        }
        public Tuple<Boolean, string> DebtUpdate(int id, decimal updateDebt)
        {
            return LibraryProvider.DebtUpdate(id, updateDebt);
        }
        public List<Library> ReadLibrary()
        {
            return LibraryProvider.ReadLibrary();
        }
        public Tuple<Boolean, string> DebtUpdate()
        {
            return LibraryProvider.DebtUpdate();
        }
        public List<Student> OduncAldigiOgrenciler(int ktpId)
        {
            return LibraryProvider.OduncAldigiOgrenciler(ktpId);
        }
        public List<Book> OduncAldigiKitaplar(int ogrId)
        {
            return LibraryProvider.OduncAldigiKitaplar(ogrId);
        }
        public List<Library> BorcuOlanlar()
        {
            return LibraryProvider.BorcuOlanlar();
        }
        public List<Book> AlinmamisKitaplar()
        {
            return LibraryProvider.AlinmamisKitaplar();
        }
        public List<Book> AlinmisKitaplar()
        {
            return LibraryProvider.AlinmisKitaplar();
        }
    }
}
