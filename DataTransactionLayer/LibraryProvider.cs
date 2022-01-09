using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Data.OleDb;
using Model;
namespace DataTransactionLayer
{
   public class LibraryProvider
    {
        #region Library Insert
        //kütüphaneye ekle
        public Tuple<Boolean, string> InsertLibrary(int bookId, int studentId)
        {
            //conn degiskeni oluşturuyorum

            using (OleDbConnection conn = new SqlConnection().Conn())
            {
                
                try
                {
                    //baglantıyı açıyorum
                    conn.Open();
                    //cmd degiskeni olusturuyorum ve ınsert sorgusu giriyorum
                    OleDbCommand cmd = new SqlConnection().
                        cmd(
                        $"INSERT INTO Library(Student_id,Book_id) VALUES({studentId}," +
                        $"{bookId})"
                        , conn
                        );
                    //sql sorugusu çalışıyorsa
                    if (cmd.ExecuteNonQuery() != -1)
                    {
                        //başarılı
                        return Tuple.Create(true, "Başarılı");
                    }
                    else
                    {
                        //başarısız
                        return Tuple.Create(false, "Başarısız");
                    }

                }
                catch (Exception e)
                {
                    //hata varsa
                    return Tuple.Create(false, e.Message);

                }
                finally
                {
                    //baglantı açıksa
                    if (conn.State != System.Data.ConnectionState.Closed)
                    {
                        //kapat
                        conn.Close();
                    }
                }
            }
        }
        #endregion

        #region Book expired date update
        //ulastırılmış kitap tarihlerini guncelle
        public Tuple<Boolean, string> extendExpiryDate(int id)
        {
            //conn degiskeni olusturuyorum
            using (OleDbConnection conn = new SqlConnection().Conn())
            {
                try
                {
                    //baglantı aç
                    conn.Open();
                    //cmd degiskeni degiskeni oluşturuyorum ve update sorugusu oluşturuyorum
                    OleDbCommand cmd = new SqlConnection().cmd($"UPDATE Library SET expiry_date=DateAdd('d', 15, expiry_date)" +
                        $"Where id={id}", conn);//UPDATE Library SET expiry_date = DateAdd("d", 15, expiry_date) where id = 2;
                    //sql sorugusu çalışıyorsa
                    if (cmd.ExecuteNonQuery() != -1)
                    {
                        //başarılı
                        return Tuple.Create(true, "Başarılı");
                    }
                    else
                    {
                        //başarısız
                        return Tuple.Create(false, "Başarısız");
                    }
                }
                catch (Exception e)
                {
                    //hata varsa
                    return Tuple.Create(false, e.Message);
                }
                finally
                {
                    //baglantı durumu açıksa
                    if (conn.State != System.Data.ConnectionState.Closed)
                    {
                        //kapat
                        conn.Close();
                    }
                }

            }
        }
        #endregion
        
        //borcları guncelle
        public Tuple<Boolean, string> DebtUpdate(int id, decimal updateDebt)
        {
            //conn degiskeni oluşturuyorum
            using (OleDbConnection conn = new SqlConnection().Conn())
            {
                try
                {
                    //baglantı ac
                    conn.Open();
                    //cmd degiskeni olusturuyorum ve update sorgusu oluşturuyorum
                    OleDbCommand cmd = new SqlConnection().cmd($"UPDATE Library SET debt={(int)updateDebt}" +
                        $" Where id={id} AND deliveredDate='teslim edilmedi'", conn);//UPDATE Library SET expiry_date = DateAdd("d", 15, expiry_date) where id = 2;
                    //sql sorgusunu çalıştırıyorum çalışırsa
                    if (cmd.ExecuteNonQuery() != -1)
                    {
                        //başarılı
                        return Tuple.Create(true, "Başarılı");
                    }
                    else
                    {
                        //başarısız
                        return Tuple.Create(false, "Başarısız");
                    }
                }
                catch (Exception e)
                {
                    //hata varsa
                    return Tuple.Create(false, e.Message);
                }
                finally
                {
                    //baglantı durumu açıksa
                    if (conn.State != System.Data.ConnectionState.Closed)
                    {
                        //kapat
                        conn.Close();
                    }
                }

            }
        }
        
        //iade et kütüphane kısmına
        public Tuple<Boolean, string> returnBook(int id)
        {
            //conn degiskeni olusturuyorum
            using (OleDbConnection conn = new SqlConnection().Conn())
            {
                try
                {
                    //baglantıyı açıyorum
                    conn.Open();
                    //cmd degiskeni olusturuyorum
                    OleDbCommand cmd = new SqlConnection().cmd($"UPDATE Library SET deliveredDate='{DateTime.Now.ToShortDateString()}' " +
                        $"Where id={id}", conn);
                    //sql sorgusu çalışıyorsa
                    if (cmd.ExecuteNonQuery() != -1)
                    {
                        //basarılı
                        return Tuple.Create(true, "Başarılı");
                    }
                    else
                    {
                        //basarısız
                        return Tuple.Create(false, "Başarısız");
                    }
                }
                catch (Exception e)
                {
                    //hata varsa
                    return Tuple.Create(false, e.Message);
                }
                finally
                {
                    //baglantı durumu açıksa
                    if (conn.State != System.Data.ConnectionState.Closed)
                    {
                        //kapat
                        conn.Close();
                    }
                }

            }
        }
        #region Read library
        //kütüphane oku
        public Tuple<List<Library>, bool> ReadLibrary()
        {
            //studentcontext nesnesi olusturuyorum
            StudentContext studentContext = new StudentContext();
            //bookcontext nesnesi olusturuyorum
            BookContext bookContext = new BookContext();
            //library listesi olusturuyorum

            List<Library> librarys = new List<Library>();
            //conn degiskeni olusturuyorum
            using (OleDbConnection conn = new SqlConnection().Conn())
            {
                try
                {
                    //baglantıyı ac
                    conn.Open();
                    //cmd degiskeni olusturuyorum ve sql sorgusu olusturuyorum
                    OleDbCommand cmd = new SqlConnection().cmd("SELECT * FROM Library", conn);
                    //read degiskeni olusturuyorum
                    OleDbDataReader read = cmd.ExecuteReader();
                    //read degiskeni doluysa
                    while (read.Read())
                    {
                        librarys.Add(
                            new Library(
                                read.GetInt32(0),
                               studentContext.getOneStudent(read.GetInt32(1)).Item3,
                               bookContext.getOneBook(read.GetInt32(2)).Item3,
                               read.GetDateTime(3),
                               read.GetDateTime(4),
                               decimal.Parse(read.GetInt32(5).ToString()),
                               read.GetString(6)
                                )
                            );
                    }
                    //baglantıyı kapat
                    read.Close();
                    //dondur tuple nesnesini
                    return Tuple.Create(librarys,true);
                }
                catch
                {
                    //library listesi olusturuyorum bos
                    List<Library> _ = new List<Library>();
                    //doncuruyorum tuple nesnesi
                    return Tuple.Create(_, false);
                }
                finally
                {
                    //baglantı durumu açıksa
                    if (conn.State != System.Data.ConnectionState.Closed)
                    {
                        //kapat
                        conn.Close();
                    }
                }

            }
        }
        #endregion
        //borc guncelle
        public Tuple<Boolean, string> DebtUpdate()
        {
            //conn degiskeni olusuturuyorum
            using (OleDbConnection conn = new SqlConnection().Conn())
            {
                try
                {
                    //baglantı ac
                    conn.Open();
                    //cmd degiskeni olusturuyorum ve select sorugusu olusturuyorum
                    OleDbCommand cmd = new SqlConnection().cmd($"SELECT * FROM Library Where deliveredDate='teslim edilmedi'", conn);
                    OleDbDataReader read = cmd.ExecuteReader();
                    //read degiskeni doluysa
                    while (read.Read())
                    {
                        int day= (read.GetDateTime(4) - DateTime.Now).Days;
                        if ((read.GetDateTime(4)-DateTime.Now).Days<0)
                        {
                            int day_count = (read.GetDateTime(4) - DateTime.Now).Days;
                            int newDebt = Math.Abs(day_count) * 1;
                            DebtUpdate(read.GetInt32(0), (decimal)newDebt);
                        }
                        
                        
                    }
                    //baglantıyı kapat
                    read.Close();
                    //dondur tuple nesnesi
                    return Tuple.Create(true, "Başarılı");
                }
                catch
                {
                    //dondur tuple nesnesi
                    return Tuple.Create(false, "Başarısız");
                }

                finally
                {
                    //baglantı durumu açıksa
                    if (conn.State != System.Data.ConnectionState.Closed)
                    {
                        //kapat
                        conn.Close();
                    }
                }

            }


        }
        //oducaldığı ogrenciler
        public List<Student> OduncAldigiOgrenciler(int ktpId)
        {
            //conn degiskeni olusutuyorum
            using (OleDbConnection conn = new SqlConnection().Conn())
            {
                
                //student listesi olusturuyorum
                List<Student> students = new List<Student>();
                try
                {
                    //baglantıyı kapat
                    conn.Open();
                    //cmd degiskeni olusutuyorum ve select sql sorgusu olusuturuyorum
                    OleDbCommand cmd = new SqlConnection().cmd($"SELECT Students.* FROM Library INNER JOIN Students ON Library.Student_id=Students.Student_id WHERE Library.Book_id={ktpId}", conn);
                    OleDbDataReader read = cmd.ExecuteReader();
                    //read degiskeni doluysa
                    while (read.Read())
                    {
                       students.Add(
                            new Student(
                            read.GetInt32(0),
                            read.GetString(1),
                            read.GetString(2),
                            read.GetBoolean(3)
                                )
                            );

                    }
                    //baglantıyı kapat
                    read.Close();
                    //listeyi dondur
                    return students;
                }

                finally
                {
                    //baglantı durumu açıksa
                    if (conn.State != System.Data.ConnectionState.Closed)
                    {
                        //kapat
                        conn.Close();
                    }
                }

            }
        }
       //bir ogrencinin odunc aldıgı kitaplar
        public List<Library> OduncAldigiKitaplar(int ogrId)
        {
            //conn nesnesi olustur
            using (OleDbConnection conn = new SqlConnection().Conn())
            {
                
                //bookcontext nesnesi olusturuyorum
                BookContext bookContext = new BookContext();
                //studentcontext nesnesi olusturuyorum
                StudentContext studentContext = new StudentContext();
                //librarys listesi olusuturuyorum
                List<Library> Librarys= new List<Library>();
                try
                {
                    //baglantıyı aç
                    conn.Open();
                    
                   //cmd degiskeni ve sql sorgusu olusturuyorum
                        OleDbCommand cmd = new SqlConnection().cmd($"SELECT Library.* FROM Library INNER JOIN Books ON Library.Book_id=Books.Book_id WHERE Library.Student_id={ogrId}" +
                       $"", conn);
                    OleDbDataReader read = cmd.ExecuteReader();
                    //read degiskeni doluysa
                    while (read.Read())
                    {
                        Librarys.Add(
                            new Library(
                            read.GetInt32(0),
                           studentContext.getOneStudent(read.GetInt32(1)).Item3,
                           bookContext.getOneBook(read.GetInt32(2)).Item3,
                           read.GetDateTime(3),
                           read.GetDateTime(4),
                           decimal.Parse(read.GetInt32(5).ToString()),
                           read.GetString(6)
                            )
                             );

                    }
                    //baglantıyı kapat
                    read.Close();
                    //doncur listeyi
                    return Librarys;
                }

                finally
                {
                    //baglantı durumu açıksa
                    if (conn.State != System.Data.ConnectionState.Closed)
                    {
                        //baglantı kapat
                        conn.Close();
                    }
                }

            }
        }
        //borcu olanlar
        public List<Student> BorcuOlanlar()
        {
            
            //studet listesi olusturuyorum
            List<Student> students = new List<Student>();
            //conn degiskeni olusturuyorum
            using (OleDbConnection conn = new SqlConnection().Conn())
            {
                try
                {
                    //baglantı aç
                    conn.Open();
                    //cmd degiskeni ve select sql sorugu olusturuyorum
                    OleDbCommand cmd = new SqlConnection().cmd("SELECT Students.* FROM Library INNER JOIN Students ON Library.Student_id=Students.Student_id Where Library.debt>0", conn);
                    OleDbDataReader read = cmd.ExecuteReader();
                    //read degiskeni doluysa
                    while (read.Read())
                    {
                        students.Add(new Student(
                            read.GetInt32(0),
                            read.GetString(1),
                            read.GetString(2),
                            read.GetBoolean(3)

                            ));
                    }
                    //baglantıyı kapat
                    read.Close();
                    //dondur listeyi
                    return students;
                }

                finally
                {
                    //baglantı durumu açıksa
                    if (conn.State != System.Data.ConnectionState.Closed)
                    {
                        //baglantıyı kapat
                        conn.Close();
                    }
                }

            }
        }

        
        //bir ogrencinin teslim ettigi kitaplar
        public List<Library> teslimEtigiKitaplar(int ogr_id)
        {
            //studentcontext nesnesi olusturuyorum
            StudentContext studentContext = new StudentContext();
            //bookcontext nesnesi olusturuyorum
            BookContext bookContext = new BookContext();
            //library listesi olusturuyorum
            List<Library> librarys = new List<Library>();
            //conn degiskeni olusturuyorum
            using (OleDbConnection conn = new SqlConnection().Conn())
            {
                try
                {
                    //baglantıyı açıyorum
                    conn.Open();
                    //cmd degiskeni olusturuyorum ve select sorgusu olusturuyorum
                    OleDbCommand cmd = new SqlConnection().cmd($"SELECT * FROM Library WHERE Student_id={ogr_id} and deliveredDate<>'teslim edilmedi'", conn);
                    OleDbDataReader read = cmd.ExecuteReader();
                    //read degiskeni doluysa
                    while(read.Read())
                    {
                        librarys.Add(
                        new Library(
                            read.GetInt32(0),
                           studentContext.getOneStudent(read.GetInt32(1)).Item3,
                           bookContext.getOneBook(read.GetInt32(2)).Item3,
                           read.GetDateTime(3),
                           read.GetDateTime(4),
                           decimal.Parse(read.GetInt32(5).ToString()),
                           read.GetString(6)
                            )
                        );
                    }


                    
                    //baglantıyı kapat
                    read.Close();
                    //dondur listeyi
                    return librarys;
                }

                finally
                {
                    //baglantı durumu açıksa
                    if (conn.State != System.Data.ConnectionState.Closed)
                    {
                        //kapat
                        conn.Close();
                    }
                }

            }
        }
        
        //bir ogrencini teslim etmediği kitaplar
        public List<Library> teslimEtmedigiKitaplar(int ogr_id)
        {
            //studentcontext nesnesi olusturuyorum
            StudentContext studentContext = new StudentContext();
            //bookcontext nesnesi olusturuyorum
            BookContext bookContext = new BookContext();
            //library listesi olusuturuyorum
            List<Library> librarys = new List<Library>();
            //conn degiskeni olusturuyorum
            using (OleDbConnection conn = new SqlConnection().Conn())
            {
                try
                {
                    //baglantıyı açıyorum
                    conn.Open();
                    //cmd degiskeni olusturuyorum ve sql sorgusu 
                    OleDbCommand cmd = new SqlConnection().cmd($"SELECT * FROM Library WHERE Student_id={ogr_id} and deliveredDate='teslim edilmedi'", conn);
                    OleDbDataReader read = cmd.ExecuteReader();
                    //read doluysa
                    while (read.Read())
                    {
                        librarys.Add(
                        new Library(
                            read.GetInt32(0),
                           studentContext.getOneStudent(read.GetInt32(1)).Item3,
                           bookContext.getOneBook(read.GetInt32(2)).Item3,
                           read.GetDateTime(3),
                           read.GetDateTime(4),
                           decimal.Parse(read.GetInt32(5).ToString()),
                           read.GetString(6)
                            )
                        );
                    }



                    //baglantıyı kapat
                    read.Close();
                    //dondur listeyi
                    return librarys;
                }

                finally
                {
                    //baglantı durumu açıksa 
                    if (conn.State != System.Data.ConnectionState.Closed)
                    {
                        //kapat
                        conn.Close();
                    }
                }

            }
        }
        //alinan kitaplar
        public List<Library> alinanKitaplar(int ogr_id)
        {
            //studentcontext nesnesi olusturuyorum
            StudentContext studentContext = new StudentContext();
            //bookcontext nesnesi olusturuyorum
            BookContext bookContext = new BookContext();
            //library listesi olusturuyoruö
            List<Library> librarys = new List<Library>();
            //conn degiskeni olusturuyorum
            using (OleDbConnection conn = new SqlConnection().Conn())
            {
                try
                {
                    //baglantı aç
                    conn.Open();
                    //cmd degiskeni olusturuyorum ve select sql sorgusu oluşturuyorum
                    OleDbCommand cmd = new SqlConnection().cmd($"SELECT * FROM Library Where Student_id={ogr_id} and deliveredDate<>'teslim edilmedi'", conn);
                    OleDbDataReader read = cmd.ExecuteReader();
                    //read doluysa
                    while(read.Read())
                    {
                        librarys.Add(
                       new Library(
                           read.GetInt32(0),
                          studentContext.getOneStudent(read.GetInt32(1)).Item3,
                          bookContext.getOneBook(read.GetInt32(2)).Item3,
                          read.GetDateTime(3),
                          read.GetDateTime(4),
                          decimal.Parse(read.GetInt32(5).ToString()),
                          read.GetString(6)
                           )
                       );
                    }


                   
                    //baglantıyı kapat
                    read.Close();
                    //dondur listeyi
                    return librarys;
                }

                finally
                {
                    //baglantı durumu açıksa
                    if (conn.State != System.Data.ConnectionState.Closed)
                    {
                        //kapat
                        conn.Close();
                    }
                }

            }
        }
        
        //kütüphaneden bir satır oku
        public List<Library> ReadOneLib(int id)
        {
            //studentcontext nesnesi olusturuyorum
            StudentContext studentContext = new StudentContext();
            //bookcontext nesnesi olusturuyorum
            BookContext bookContext = new BookContext();
            //library listesi olusturuyorum
            List<Library> librarys = new List<Library>();
            //conn degiskeni olusturuyorum
            using (OleDbConnection conn = new SqlConnection().Conn())
            {
                try
                {
                    //baglantıyı aç
                    conn.Open();
                    //cmd degiskeni olusturuyorum ve sql select sorgusu oluşturuyorum
                    OleDbCommand cmd = new SqlConnection().cmd($"SELECT Library.* FROM Library Where id={id}", conn);
                    OleDbDataReader read = cmd.ExecuteReader();
                    //okuyorum
                    read.Read();
                   


                        librarys.Add(
                            new Library(
                                read.GetInt32(0),
                               studentContext.getOneStudent(read.GetInt32(1)).Item3,
                               bookContext.getOneBook(read.GetInt32(2)).Item3,
                               read.GetDateTime(3),
                               read.GetDateTime(4),
                               decimal.Parse(read.GetInt32(5).ToString()),
                               read.GetString(6)
                                )
                            );
                    //bağlantıyı kapatıyorum
                    read.Close();
                    //dondur listeyi
                    return librarys;
                }

                finally
                {
                    //bağlantı durumu açıksa
                    if (conn.State != System.Data.ConnectionState.Closed)
                    {
                        //kapat
                        conn.Close();
                    }
                }
               
            }
        }
       
    }
}
