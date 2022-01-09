using Model;
using System;
using System.Data.OleDb;
using DataLayer;
using System.Collections.Generic;

namespace DataTransactionLayer
{
    public class BookProvider
    {
        #region Book Insert
        //kitap ekleme 
        public Tuple<Boolean, string> InsertBook(Book book)
        {
            //conn değişkeni oluşturuluyor sqlconnection dan
            using (OleDbConnection conn = new SqlConnection().Conn())
            {

                try
                {
                    //bağlantı açılıyor
                    conn.Open();
                    //cmd degiskeni olusturuluyor ve insert komutu giriliyor
                    OleDbCommand cmd = new SqlConnection().
                        cmd(
                        $"INSERT INTO Books(Book_name,Book_type,Book_author,Book_page) VALUES('{book.name}'," +
                        $"'{book.type}','{book.author}',{book.page})"
                        , conn
                        );
                    //insert çalışıyorsa
                    if (cmd.ExecuteNonQuery() != -1)
                    {
                        //başarılı
                        return Tuple.Create(true, "Başarılı");
                    }
                    else
                    {
                        //başarılı
                        return Tuple.Create(false, "Başarısız");
                    }

                }
                //hata varsa
                catch (Exception e)
                {

                    //hata varsa
                    return Tuple.Create(false, e.Message);

                }
                finally
                {
                    //baglantı kapatılmamamıssa kapat
                    if (conn.State != System.Data.ConnectionState.Closed)
                    {
                        conn.Close();
                    }
                }
            }
        }
        #endregion
        #region Book Delete
        //kitap silme
        public Tuple<Boolean, string> DeleteBook(int id)
        {
            //con degiskeni olusturuyorum
            using (OleDbConnection conn = new SqlConnection().Conn())
            {
                try
                {
                    //baglantı açılıyor ve delete sorgusu giriliyor
                    conn.Open();
                    //cmd değişkeni oluşturuyorun
                    OleDbCommand cmd = new SqlConnection().cmd($"Delete from Books Where Book_id={id}", conn);
                    //cmd çalışıyorsa başarılı
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
                    //hata mesajı
                    return Tuple.Create(false, e.Message);
                }
                finally
                {
                    //baglantıyı kapat açıksa
                    if (conn.State != System.Data.ConnectionState.Closed)
                    {
                        conn.Close();
                    }

                }
            }
        }
        #endregion
        #region Book Update
        //kitap güncelle223
        public Tuple<Boolean, string> UpdateBook(Book book, int id)
        {
            //conn degiskeni oluşturuyorum
            using (OleDbConnection conn = new SqlConnection().Conn())
            {
                try
                {
                    //baglantıyı açıyorum ve sql güncelleme sorgusunu giridiyorum
                    conn.Open();
                    OleDbCommand cmd = new SqlConnection().cmd($"UPDATE Books SET Book_name='{book.name}',Book_type='{book.type}'," +
                        $"Book_author='{book.author}',Book_page={book.page} Where Book_id={id}", conn);
                    //sorgu çalışıyorsa
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
                    //hata varsa hata mesajı dönn
                    return Tuple.Create(false, e.Message);
                }
                finally
                {
                    //bağlantı açıksa
                    if (conn.State != System.Data.ConnectionState.Closed)
                    {
                        //kapat baglantıyı
                        conn.Close();
                    }
                }

            }
        }
        #endregion
        #region Book 1 row Read
        //kitabın tek satırını oku
        public Tuple<Boolean, string, Book> OneRowReadBook(int id)
        {
            //con degiskeni oluşturuyorum
            using (OleDbConnection conn = new SqlConnection().Conn())
            {
                try
                {
                    //baglantıyı açıyorum ve select sorgusunu giriyorum
                    conn.Open();
                    OleDbCommand cmd = new SqlConnection().cmd($"SELECT * FROM Books WHERE Book_id={id}", conn);
                    //okuma degiskeni oluyorum
                    OleDbDataReader read = cmd.ExecuteReader();
                    //varsa kayıt okuyacak
                    if (read.Read())
                    {
                        return Tuple.Create(true, "Başarılı",
                            new Book(
                            read.GetInt32(0),
                            read.GetString(1),
                            read.GetString(2),
                            read.GetString(3),
                            read.GetInt32(4),
                            read.GetBoolean(5)
                            )
                            );
                        //okumayı kapat
                        read.Close();
                    }
                    else
                    {
                        //başarısız
                        return Tuple.Create(false, "Başarısız", new Book());
                    }

                }
                catch (Exception e)
                {
                    //hata varsa
                    return Tuple.Create(false, e.Message, new Book());
                }
                finally
                {
                    //baglanntıyı kapat
                    if (conn.State != System.Data.ConnectionState.Closed)
                    {
                        conn.Close();
                    }
                }
            }
        }
        #endregion
        //odunc al
        public Tuple<Boolean, string> oduncAl(int bookId)
        {
            //con degiskeni oluşturuyorum
            using (OleDbConnection conn = new SqlConnection().Conn())
            {
                try
                {
                    //baglantıyı açıyorum
                    conn.Open();
                    OleDbCommand cmd = new SqlConnection().cmd($"UPDATE Books SET isDelivered={false} where Book_id={bookId}", conn);
                    //cmd çalışıyorsa
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

                finally
                {
                    //baglantı açıksa
                    if (conn.State != System.Data.ConnectionState.Closed)
                    {
                        //bağlantıyı kapat
                        conn.Close();
                    }
                }

            }
        }
        //kitap iade et
        public Tuple<Boolean, string> geriVer(int bookId)
        {

            //conn degiskeni olusturuyorum
            using (OleDbConnection conn = new SqlConnection().Conn())
            {
                try
                {
                    //baglantıyı açıyorum
                    conn.Open();
                    OleDbCommand cmd = new SqlConnection().cmd($"UPDATE Books SET isDelivered={true} Where Book_id={bookId}", conn);
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

                finally
                {
                    //bağlantı açıksa
                    if (conn.State != System.Data.ConnectionState.Closed)
                    {
                        //kapat
                        conn.Close();
                    }
                }

            }
        }
            #region Read Book
        //kitap oku
            public List<Book> ReadBook()
            {
                //kitap listesi oluşturuyorum
                List<Book> books = new List<Book>();
            //con değişkeni oluşturuyorum
                using (OleDbConnection conn = new SqlConnection().Conn())
                {
                    try
                    {
                    //bğlantıyı açıyorum ve select sorugusu giriyorum
                        conn.Open();
                        OleDbCommand cmd = new SqlConnection().cmd("SELECT * FROM Books", conn);
                    //read objesi oluşturuyorum
                        OleDbDataReader read = cmd.ExecuteReader();
                    //read i false ise okumayı bırak
                        while (read.Read())
                        {
                            books.Add(new Book(
                                read.GetInt32(0),
                                read.GetString(1),
                                read.GetString(2),
                                read.GetString(3),
                                read.GetInt32(4),
                                read.GetBoolean(5)
                                ));
                        }
                        //baglantıyı kapat
                        read.Close();
                    //listeyi dondur
                        return books;
                    }

                    finally
                    {
                    //bağlantı kapalı değilse
                        if (conn.State != System.Data.ConnectionState.Closed)
                        {
                        //kapat
                            conn.Close();
                        }
                    }

                }
            }
            #endregion

            #region GoreAra
        //gore ara
            public List<Book> GoreAra(string arananDeger, string satirAdi)
            {
            //kitap listesi oluşturuyorum
                List<Book> books = new List<Book>();
            //conn değiskeni oluyorum
                using (OleDbConnection conn = new SqlConnection().Conn())
                {
                    try
                    {
                    //baglantıyı acıyorum ve select sorgusu oluşturuyorum
                        conn.Open();
                        OleDbCommand cmd = new SqlConnection().cmd($"SELECT * FROM Books WHERE {satirAdi} LIKE '%{arananDeger}%'", conn);
                        OleDbDataReader read = cmd.ExecuteReader();
                    //read bos degilse oku
                        while (read.Read())
                        {
                            books.Add(new Book(
                                read.GetInt32(0),
                                read.GetString(1),
                                read.GetString(2),
                                read.GetString(3),
                                read.GetInt32(4),
                                read.GetBoolean(5)
                                ));
                        }
                        //kapat baglantıyı
                        read.Close();
                    //listeyi dondur
                        return books;
                    }

                    finally
                    {
                    //baglantı acıksa
                        if (conn.State != System.Data.ConnectionState.Closed)
                        {
                        //kapat
                            conn.Close();
                        }
                    }

                }
            }
            #endregion
        //alinmis kitapalr
            public List<Book> AlinmisKitaplar()
            {
            //coon degiskeni olusturuyorum
                using (OleDbConnection conn = new SqlConnection().Conn())
                {
                //bookcontext nesnesi olustuyuroum
                    BookContext bookContext = new BookContext();
                //kitap listesi oluşturuyorum
                    List<Book> books = new List<Book>();
                    try
                    {
                    //baglantıyı açıyorum ve select sorugusu oluşturuyorum
                        conn.Open();
                        OleDbCommand cmd = new SqlConnection().cmd($"SELECT Books.* FROM Books where isDelivered={false}", conn);
                        OleDbDataReader read = cmd.ExecuteReader();
                    //read degiskeni doluysa oku
                        while (read.Read())
                        {
                            books.Add(
                                 new Book(
                                read.GetInt32(0),
                                read.GetString(1),
                                read.GetString(2),
                                read.GetString(3),
                                read.GetInt32(4),
                                read.GetBoolean(5)
                                     )
                                 );

                        }
                        //baglantıyı kapat
                        read.Close();
                    //listeyi dondur
                        return books;
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

        //alinmamis kitaplar
            public List<Book> AlinmamisKitaplar()
            {
            //conn nesnesi oluşturuyorum
                using (OleDbConnection conn = new SqlConnection().Conn())
                {
                //bookcontext objesi oluşturuyorum
                    BookContext bookContext = new BookContext();
                //kitap listesi oluşturuyoruö
                    List<Book> books = new List<Book>();
                    try
                    {
                    //baglatıyı açıyorums
                        conn.Open();
                    //cmd degiskeni oluşşturuyorum ve select sorgusu oluşturuyorum
                        OleDbCommand cmd = new SqlConnection().cmd($"select * from Books Where isDelivered={true}", conn);
                        OleDbDataReader read = cmd.ExecuteReader();
                    //read degiskeni doluysa
                        while (read.Read())
                        {
                            books.Add(
                                 new Book(
                                read.GetInt32(0),
                                read.GetString(1),
                                read.GetString(2),
                                read.GetString(3),
                                read.GetInt32(4),
                                read.GetBoolean(5)

                                     )
                                 );

                        }
                        //baglantıyı kapat
                        read.Close();
                    //listeyi dondur
                        return books;
                    }

                    finally
                    {
                    //baglantı acıksa
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
