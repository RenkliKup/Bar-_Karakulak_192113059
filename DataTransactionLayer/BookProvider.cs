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
        public Tuple<Boolean, string> InsertBook(Book book)
        {

            using (OleDbConnection conn = new SqlConnection().Conn())
            {

                try
                {
                    conn.Open();
                    OleDbCommand cmd = new SqlConnection().
                        cmd(
                        $"INSERT INTO Books(Book_name,Book_type,Book_author,Book_page) VALUES('{book.name}'," +
                        $"'{book.type}','{book.author}',{book.page})"
                        , conn
                        );
                    if (cmd.ExecuteNonQuery() != -1)
                    {
                        return Tuple.Create(true, "Başarılı");
                    }
                    else
                    {
                        return Tuple.Create(false, "Başarısız");
                    }

                }
                catch (Exception e)
                {

                    return Tuple.Create(false, e.Message);

                }
                finally
                {
                    if (conn.State != System.Data.ConnectionState.Closed)
                    {
                        conn.Close();
                    }
                }
            }
        }
        #endregion
        #region Book Delete
        public Tuple<Boolean, string> DeleteBook(int id)
        {
            using (OleDbConnection conn = new SqlConnection().Conn())
            {
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new SqlConnection().cmd($"Delete from Books Where Book_id={id}", conn);
                    if (cmd.ExecuteNonQuery() != -1)
                    {
                        return Tuple.Create(true, "Başarılı");
                    }
                    else
                    {
                        return Tuple.Create(false, "Başarısız");
                    }
                }
                catch (Exception e)
                {
                    return Tuple.Create(false, e.Message);
                }
                finally
                {
                    if (conn.State != System.Data.ConnectionState.Closed)
                    {
                        conn.Close();
                    }

                }
            }
        }
        #endregion
        #region Book Update
        public Tuple<Boolean, string> UpdateBook(Book book, int id)
        {
            using (OleDbConnection conn = new SqlConnection().Conn())
            {
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new SqlConnection().cmd($"UPDATE Books SET Book_name='{book.name}',Book_type='{book.type}'," +
                        $"Book_author='{book.author}',Book_page={book.page} Where Book_id={id}", conn);
                    if (cmd.ExecuteNonQuery() != -1)
                    {
                        return Tuple.Create(true, "Başarılı");
                    }
                    else
                    {
                        return Tuple.Create(false, "Başarısız");
                    }
                }
                catch (Exception e)
                {
                    return Tuple.Create(false, e.Message);
                }
                finally
                {
                    if (conn.State != System.Data.ConnectionState.Closed)
                    {
                        conn.Close();
                    }
                }

            }
        }
        #endregion
        #region Book 1 row Read
        public Tuple<Boolean, string, Book> OneRowReadBook(int id)
        {
            using (OleDbConnection conn = new SqlConnection().Conn())
            {
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new SqlConnection().cmd($"SELECT * FROM Books WHERE Book_id={id}", conn);
                    OleDbDataReader read = cmd.ExecuteReader();
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
                        read.Close();
                    }
                    else
                    {
                        return Tuple.Create(false, "Başarısız", new Book());
                    }

                }
                catch (Exception e)
                {

                    return Tuple.Create(false, e.Message, new Book());
                }
                finally
                {
                    if (conn.State != System.Data.ConnectionState.Closed)
                    {
                        conn.Close();
                    }
                }
            }
        }
        #endregion
        public Tuple<Boolean, string> oduncAl(int bookId)
        {

            using (OleDbConnection conn = new SqlConnection().Conn())
            {
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new SqlConnection().cmd($"UPDATE Books SET isDelivered={false} where Book_id={bookId}", conn);
                    if (cmd.ExecuteNonQuery() != -1)
                    {
                        return Tuple.Create(true, "Başarılı");
                    }
                    else
                    {
                        return Tuple.Create(false, "Başarısız");
                    }

                }

                finally
                {
                    if (conn.State != System.Data.ConnectionState.Closed)
                    {
                        conn.Close();
                    }
                }

            }
        }
        public Tuple<Boolean, string> geriVer(int bookId)
        {

            using (OleDbConnection conn = new SqlConnection().Conn())
            {
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new SqlConnection().cmd($"UPDATE Books SET isDelivered={true} Where Book_id={bookId}", conn);
                    if (cmd.ExecuteNonQuery() != -1)
                    {
                        return Tuple.Create(true, "Başarılı");
                    }
                    else
                    {
                        return Tuple.Create(false, "Başarısız");
                    }

                }

                finally
                {
                    if (conn.State != System.Data.ConnectionState.Closed)
                    {
                        conn.Close();
                    }
                }

            }
        }
            #region Read Book
            public List<Book> ReadBook()
            {
                List<Book> books = new List<Book>();
                using (OleDbConnection conn = new SqlConnection().Conn())
                {
                    try
                    {
                        conn.Open();
                        OleDbCommand cmd = new SqlConnection().cmd("SELECT * FROM Books", conn);
                        OleDbDataReader read = cmd.ExecuteReader();
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
                        read.Close();
                        return books;
                    }

                    finally
                    {
                        if (conn.State != System.Data.ConnectionState.Closed)
                        {
                            conn.Close();
                        }
                    }

                }
            }
            #endregion

            #region GoreAra
            public List<Book> GoreAra(string arananDeger, string satirAdi)
            {
                List<Book> books = new List<Book>();
                using (OleDbConnection conn = new SqlConnection().Conn())
                {
                    try
                    {
                        conn.Open();
                        OleDbCommand cmd = new SqlConnection().cmd($"SELECT * FROM Books WHERE {satirAdi} LIKE '%{arananDeger}%'", conn);
                        OleDbDataReader read = cmd.ExecuteReader();
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
                        read.Close();
                        return books;
                    }

                    finally
                    {
                        if (conn.State != System.Data.ConnectionState.Closed)
                        {
                            conn.Close();
                        }
                    }

                }
            }
            #endregion
            public List<Book> AlinmisKitaplar()
            {
                using (OleDbConnection conn = new SqlConnection().Conn())
                {
                    BookContext bookContext = new BookContext();

                    List<Book> books = new List<Book>();
                    try
                    {
                        conn.Open();
                        OleDbCommand cmd = new SqlConnection().cmd($"SELECT Books.* FROM Books where isDelivered={false}", conn);
                        OleDbDataReader read = cmd.ExecuteReader();
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
                        read.Close();
                        return books;
                    }

                    finally
                    {
                        if (conn.State != System.Data.ConnectionState.Closed)
                        {
                            conn.Close();
                        }
                    }

                }
            }


            public List<Book> AlinmamisKitaplar()
            {
                using (OleDbConnection conn = new SqlConnection().Conn())
                {
                    BookContext bookContext = new BookContext();

                    List<Book> books = new List<Book>();
                    try
                    {
                        conn.Open();
                        OleDbCommand cmd = new SqlConnection().cmd($"select * from Books Where isDelivered={true}", conn);
                        OleDbDataReader read = cmd.ExecuteReader();
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
                        read.Close();
                        return books;
                    }

                    finally
                    {
                        if (conn.State != System.Data.ConnectionState.Closed)
                        {
                            conn.Close();
                        }
                    }

                }
            }

        }
    }
