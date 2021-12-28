using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DataTransactionLayer
{
    class LibraryContext
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
        public List<Student> OduncAldigiOgrenciler(int ogrId)
        {
            return LibraryProvider.OduncAldigiOgrenciler(ogrId);
        }
        public List<Book> OduncAldigiKitaplar(int ktpId)
        {
            return LibraryProvider.OduncAldigiKitaplar(ktpId);
        }
    }
}
