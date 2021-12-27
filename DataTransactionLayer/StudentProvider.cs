using Model;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransactionLayer
{
    public class StudentProvider
    {
        #region Student Insert
        public Tuple<Boolean, string> InsertStudent(Student student)
        {

            using (OleDbConnection conn = new SqlConnection().Conn())
            {

                try
                {
                    conn.Open();
                    OleDbCommand cmd = new SqlConnection().
                        cmd(
                        $"INSERT INTO Students (Student_name,Student_surname,Student_sex)  VALUES('{student.name}'," +
                        $"'{student.surname}',{student.sex})"
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
        #region Student Delete
        public Tuple<Boolean, string> DeleteStudent(int id)
        {
            using (OleDbConnection conn = new SqlConnection().Conn())
            {
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new SqlConnection().cmd($"Delete from Students Where Student_id={id}", conn);
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
        #region Student Update
        public Tuple<Boolean, string> UpdateStudent(Student student, int id)
        {
            using (OleDbConnection conn = new SqlConnection().Conn())
            {
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new SqlConnection().cmd($"UPDATE Students SET Student_name='{student.name}',Student_surname='{student.surname}'," +
                        $"Student_sex={student.sex} Where Student_id={id}", conn);
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
        #region Student 1 row Read
        public Tuple<Boolean, string, Student> OneRowReadStudent(int id)
        {
            using (OleDbConnection conn = new SqlConnection().Conn())
            {
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new SqlConnection().cmd($"SELECT * FROM Students WHERE Student_id={id}", conn);
                    OleDbDataReader read = cmd.ExecuteReader();
                    if (read.Read())
                    {
                        return Tuple.Create(true, "Başarılı",
                            new Student(
                            read.GetInt32(0),
                            read.GetString(1),
                            read.GetString(2),
                            read.GetBoolean(3)
                            )
                            );
                        read.Close();
                    }
                    else
                    {
                        return Tuple.Create(false, "Başarısız", new Student());
                    }

                }
                catch (Exception e)
                {

                    return Tuple.Create(false, e.Message, new Student());
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
        #region Read Student
        public List<Student> ReadStudent()
        {
            List<Student> students = new List<Student>();
            using (OleDbConnection conn = new SqlConnection().Conn())
            {
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new SqlConnection().cmd("SELECT * FROM Students", conn);
                    OleDbDataReader read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        students.Add(new Student(
                            read.GetInt32(0),
                            read.GetString(1),
                            read.GetString(2),
                            read.GetBoolean(3)

                            ));
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
        #endregion
        #region GoreAra
        public List<Student> GoreAra(string arananDeger,string satirAdi)
        {
            List<Student> students = new List<Student>();
            using (OleDbConnection conn = new SqlConnection().Conn())
            {
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new SqlConnection().cmd($"SELECT * FROM Students WHERE {satirAdi} LIKE '%{arananDeger}%'", conn);
                    OleDbDataReader read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        students.Add(new Student(
                            read.GetInt32(0),
                            read.GetString(1),
                            read.GetString(2),
                            read.GetBoolean(3)

                            ));
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
        #endregion

       
        #region GoreListele2
        public List<Student> GoreListele(string satirAdi, bool istenendeger1)
        {
            List<Student> students = new List<Student>();
            using (OleDbConnection conn = new SqlConnection().Conn())
            {
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new SqlConnection().cmd($"SELECT * FROM Students WHERE {satirAdi}={istenendeger1}", conn);
                    OleDbDataReader read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        students.Add(new Student(
                            read.GetInt32(0),
                            read.GetString(1),
                            read.GetString(2),
                            read.GetBoolean(3)

                            ));
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
#endregion
    }
}
