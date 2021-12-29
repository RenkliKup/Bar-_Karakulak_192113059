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
        public Tuple<Boolean, string> InsertLibrary(int bookId, int studentId)
        {

            using (OleDbConnection conn = new SqlConnection().Conn())
            {

                try
                {
                    conn.Open();
                    OleDbCommand cmd = new SqlConnection().
                        cmd(
                        $"INSERT INTO Library(Student_id,Book_id) VALUES({studentId}," +
                        $"{bookId}"
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

        #region Book expired date update
        public Tuple<Boolean, string> extendExpiryDate(int id)
        {
            using (OleDbConnection conn = new SqlConnection().Conn())
            {
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new SqlConnection().cmd($"UPDATE Library SET expiry_date=DateAdd('d', 15, expiry_date)" +
                        $"Where id={id}", conn);//UPDATE Library SET expiry_date = DateAdd("d", 15, expiry_date) where id = 2;
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
        #region Book expired date update
        public Tuple<Boolean, string> DebtUpdate(int id, decimal updateDebt)
        {
            
            using (OleDbConnection conn = new SqlConnection().Conn())
            {
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new SqlConnection().cmd($"UPDATE Library SET debt={(int)updateDebt}" +
                        $"Where id={id}", conn);//UPDATE Library SET expiry_date = DateAdd("d", 15, expiry_date) where id = 2;
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

        #region Read library
        public List<Library> ReadLibrary()
        {
            StudentContext studentContext = new StudentContext();
            BookContext bookContext = new BookContext();
            List<Library> librarys = new List<Library>();
            using (OleDbConnection conn = new SqlConnection().Conn())
            {
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new SqlConnection().cmd("SELECT * FROM Library", conn);
                    OleDbDataReader read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        librarys.Add(
                            new Library(
                                read.GetInt16(0),
                               studentContext.getOneStudent(read.GetInt16(1)).Item3,
                               bookContext.getOneBook(read.GetInt16(2)).Item3,
                               read.GetDateTime(3),
                               read.GetDateTime(4),
                               
                               read.GetDecimal(5),
                               read.GetBoolean(6)
                                )
                            );
                    }
                    read.Close();
                    return librarys;
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
        public Tuple<Boolean, string> DebtUpdate()
        {
            using (OleDbConnection conn = new SqlConnection().Conn())
            {
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new SqlConnection().cmd("SELECT * FROM Library", conn);
                    OleDbDataReader read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        if((read.GetDateTime(4)-DateTime.Now).Days<0)
                        {
                            int day_count = (read.GetDateTime(4) - DateTime.Now).Days;
                            int newDebt = Math.Abs(day_count) * 1;
                            DebtUpdate(read.GetInt32(0), (decimal)newDebt);
                        }
                               
                        
                    }
                    read.Close();
                    return Tuple.Create(true, "sds");
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
        public List<Student> OduncAldigiOgrenciler(int ktpId)
        {
            using (OleDbConnection conn = new SqlConnection().Conn())
            {
                
                
                List<Student> students = new List<Student>();
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new SqlConnection().cmd($"SELECT Students.* FROM Library INNER JOIN Students ON Library.Student_id=Students.Student_id WHERE Library.Book_id={ktpId}", conn);
                    OleDbDataReader read = cmd.ExecuteReader();
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
                    read.Close();
                    return students;
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
        public List<Book> OduncAldigiKitaplar(int ogrId)
        {
            using (OleDbConnection conn = new SqlConnection().Conn())
            {
                BookContext bookContext = new BookContext();

                List<Book> books = new List<Book>();
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new SqlConnection().cmd($"SELECT Books.* FROM Library INNER JOIN Books ON Library.Book_id=Books.Book_id WHERE Library.Student_id={ogrId}", conn);
                    OleDbDataReader read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        books.Add(
                             new Book(
                            read.GetInt32(0),
                            read.GetString(1),
                            read.GetString(2),
                            read.GetString(3),
                            read.GetInt32(4)
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
        public List<Library> BorcuOlanlar()
        {
            StudentContext studentContext = new StudentContext();
            BookContext bookContext = new BookContext();
            List<Library> librarys = new List<Library>();
            using (OleDbConnection conn = new SqlConnection().Conn())
            {
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new SqlConnection().cmd("SELECT * FROM Library Where debt>0", conn);
                    OleDbDataReader read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        librarys.Add(
                            new Library(
                                read.GetInt16(0),
                               studentContext.getOneStudent(read.GetInt16(1)).Item3,
                               bookContext.getOneBook(read.GetInt16(2)).Item3,
                               read.GetDateTime(3),
                               read.GetDateTime(4),

                               read.GetDecimal(5),
                               read.GetBoolean(6)
                                )
                            );
                    }
                    read.Close();
                    return librarys;
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
        public List<Book> AlinmisKitaplar()
        {
            using (OleDbConnection conn = new SqlConnection().Conn())
            {
                BookContext bookContext = new BookContext();

                List<Book> books = new List<Book>();
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new SqlConnection().cmd($"SELECT Books.* FROM Library INNER JOIN Books ON Library.Book_id=Books.Book_id", conn);
                    OleDbDataReader read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        books.Add(
                             new Book(
                            read.GetInt32(0),
                            read.GetString(1),
                            read.GetString(2),
                            read.GetString(3),
                            read.GetInt32(4)
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
                    OleDbCommand cmd = new SqlConnection().cmd($"SELECT Books.* FROM Library RIGHT JOIN Books ON Library.Book_id=Books.Book_id Where Library.Book_id IS NULL", conn);
                    OleDbDataReader read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        books.Add(
                             new Book(
                            read.GetInt32(0),
                            read.GetString(1),
                            read.GetString(2),
                            read.GetString(3),
                            read.GetInt32(4)
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
