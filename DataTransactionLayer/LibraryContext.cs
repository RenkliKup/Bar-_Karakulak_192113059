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
        public Tuple<List<Library>, bool> ReadLibrary()
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
        public List<Library> OduncAldigiKitaplar(int ogrId)
        {
            return LibraryProvider.OduncAldigiKitaplar(ogrId);
        }
        public List<Student> BorcuOlanlar()
        {
            return LibraryProvider.BorcuOlanlar();
        }
      
        public Tuple<Boolean, string> returnBook(int id)
        {
            return LibraryProvider.returnBook(id);
        }
        public List<Library> ReadOneLib(int ktpId)
        {
            return LibraryProvider.ReadOneLib(ktpId);
        }
        public List<Library> teslimEtigiKitaplar(int ogr_id)
        {
            return LibraryProvider.teslimEtigiKitaplar(ogr_id);
        }
        public List<Library> alinanKitaplar(int ogr_id)
        {
            return LibraryProvider.alinanKitaplar(ogr_id);
        }
        public List<Library> teslimEtmedigiKitaplar(int ogr_id)
        {
            return LibraryProvider.teslimEtmedigiKitaplar(ogr_id);
        }
    }
}
