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
        //libraryProvider objesi
        LibraryProvider LibraryProvider = new LibraryProvider();
        //kayıdı library tablosuna ekliypr
        public Tuple<Boolean, string> InsertLibraryContext(int bookId, int studentId)
        {
            //tuple nesnesi donduruyor
            return LibraryProvider.InsertLibrary(bookId, studentId);
        }
        //tarihi uzatıyor
        public Tuple<Boolean, string> extendExpiryDateContext(int id)
        {
            //tuple nesnesi donduruyor
            return LibraryProvider.extendExpiryDate(id);
        }
        //borcları guncelliyor
        public Tuple<Boolean, string> DebtUpdate(int id, decimal updateDebt)
        {
            //tuple nesnesi donduruyor
            return LibraryProvider.DebtUpdate(id, updateDebt);
        }
        //lib i okuyor
        public Tuple<List<Library>, bool> ReadLibrary()
        {
            //tuple ve lib listesi donduruyor
            return LibraryProvider.ReadLibrary();
        }
        //borcları guncelliyor
        public Tuple<Boolean, string> DebtUpdate()
        {
            //tuple nesnesi donduruyor
            return LibraryProvider.DebtUpdate();
        }
        //kitabı odunc aldıgı orencileri listeliyor
        public List<Student> OduncAldigiOgrenciler(int ktpId)
        {
            //student listesi donduruyor
            return LibraryProvider.OduncAldigiOgrenciler(ktpId);
        }
        //odunc aldığı kitapları donduruyor
        public List<Library> OduncAldigiKitaplar(int ogrId)
        {
            //kitap listesi donduruyor
            return LibraryProvider.OduncAldigiKitaplar(ogrId);
        }
        //borcu olanları donduruyor 
        public List<Student> BorcuOlanlar()
        {
            //student listesi donduruyor
            return LibraryProvider.BorcuOlanlar();
        }
      
        //kitabı geri veriyor ve geri verilme tarihi ekliyor
        public Tuple<Boolean, string> returnBook(int id)
        {
            //tuple objesi donduruyor
            return LibraryProvider.returnBook(id);
        }
        //bir tane satır okuyor
        public List<Library> ReadOneLib(int ktpId)
        {
            //lib listesi donduruyor
            return LibraryProvider.ReadOneLib(ktpId);
        }
        //teslim ettigi kitapları donduruyor
        public List<Library> teslimEtigiKitaplar(int ogr_id)
        {
            //lib listesi donduruyor
            return LibraryProvider.teslimEtigiKitaplar(ogr_id);
        }
        //alinan kitapları doduruyor
        public List<Library> alinanKitaplar(int ogr_id)
        {
            //lib listesi donduruyor
            return LibraryProvider.alinanKitaplar(ogr_id);
        }
        //teslim etmediği kitapları donduruyor
        public List<Library> teslimEtmedigiKitaplar(int ogr_id)
        {
            //lib listesi donduruyor
            return LibraryProvider.teslimEtmedigiKitaplar(ogr_id);
        }
    }
}
