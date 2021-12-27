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
                        $"INSERT INTO Books VALUES({book.name}," +
                        $"{book.type},{book.author},{book.page})"
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
                            read.GetInt32(4)
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
                            read.GetInt32(4)
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
        #region AdaGoreListele
        public List<Book> AdaGoreListele()
        {
            List<Book> books = new List<Book>();
            using (OleDbConnection conn = new SqlConnection().Conn())
            {
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new SqlConnection().cmd("SELECT * FROM Books WHERE Book_name LIKE '%or%'", conn);
                    OleDbDataReader read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        books.Add(new Book(
                            read.GetInt32(0),
                            read.GetString(1),
                            read.GetString(2),
                            read.GetString(3),
                            read.GetInt32(4)
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
    }
}
