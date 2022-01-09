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
        //öğrenciyi ekle
        public Tuple<Boolean, string> InsertStudent(Student student)
        {
            //conn degiskeni olusturuyorum
            using (OleDbConnection conn = new SqlConnection().Conn())
            {

                try
                {
                    //baglantı aç
                    conn.Open();
                    //cmd degiskeni olusturuyorum ve ınsert sorgusu olusturuyorum
                    OleDbCommand cmd = new SqlConnection().
                        cmd(
                        $"INSERT INTO Students (Student_name,Student_surname,Student_sex)  VALUES('{student.name}'," +
                        $"'{student.surname}',{student.sex})"
                        , conn
                        );
                    //sql sorgusu çalışıyorsa
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
        #region Student Delete
        //ogrenciyi sil
        public Tuple<Boolean, string> DeleteStudent(int id)
        {
            //conn degiskeni olusturuyorum
            using (OleDbConnection conn = new SqlConnection().Conn())
            {
                try
                {
                    //baglantıyı ac
                    conn.Open();
                    //cmd degiskeni olusturuyorum ve delete sql sorgusu olusturuyorum
                    OleDbCommand cmd = new SqlConnection().cmd($"Delete from Students Where Student_id={id}", conn);
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
                    //bağlantı durumu açıksa
                    if (conn.State != System.Data.ConnectionState.Closed)
                    {
                        //kapat
                        conn.Close();
                    }

                }
            }
        }
        #endregion
        #region Student Update
        //ogrenci güncelle
        public Tuple<Boolean, string> UpdateStudent(Student student, int id)
        {
            //conn degiskeni olusturuyorum
            using (OleDbConnection conn = new SqlConnection().Conn())
            {
                try
                {
                    //bağlantıyı açıyorum
                    conn.Open();
                    //cmd degiskeni olusturuyorum ve update sql sorgusunu olusturuyorum
                    OleDbCommand cmd = new SqlConnection().cmd($"UPDATE Students SET Student_name='{student.name}',Student_surname='{student.surname}'," +
                        $"Student_sex={student.sex} Where Student_id={id}", conn);
                    //sql sorgusu çalışıyorsa
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
                    //bağlantı durumu açıksa
                    if (conn.State != System.Data.ConnectionState.Closed)
                    {
                        //kapat
                        conn.Close();
                    }
                }

            }
        }
        #endregion
        #region Student 1 row Read
        //bir satır oku
        public Tuple<Boolean, string, Student> OneRowReadStudent(int id)
        {
            //conn degiskeni olusturuyorum
            using (OleDbConnection conn = new SqlConnection().Conn())
            {
                try
                {
                    //bağlantıyı açıyorum
                    conn.Open();
                    //cmd degiskeni olusturuyorum ve select sorgusu olusturuyorum
                    OleDbCommand cmd = new SqlConnection().cmd($"SELECT * FROM Students WHERE Student_id={id}", conn);
                    OleDbDataReader read = cmd.ExecuteReader();
                    //read doluysa
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
                        //bağlatıyı kapat
                        read.Close();
                    }
                    else
                    {
                        //başarısız
                        return Tuple.Create(false, "Başarısız", new Student());
                    }

                }
                catch (Exception e)
                {
                    //hata varsa
                    return Tuple.Create(false, e.Message, new Student());
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
        #endregion
        #region Read Student
        //oğrenci oku
        public List<Student> ReadStudent()
        {
            //ogrenci listesi olusturuyorum
            List<Student> students = new List<Student>();
            //conn degiskeni olusturuyorum
            using (OleDbConnection conn = new SqlConnection().Conn())
            {
                try
                {
                    //bağlantıyı açıyorum
                    conn.Open();
                    //cmd degiskeni olusturuyoum ve select sorugusu olduturuyorum
                    OleDbCommand cmd = new SqlConnection().cmd("SELECT * FROM Students", conn);
                    OleDbDataReader read = cmd.ExecuteReader();
                    //read doluysa
                    while (read.Read())
                    {
                        students.Add(new Student(
                            read.GetInt32(0),
                            read.GetString(1),
                            read.GetString(2),
                            read.GetBoolean(3)

                            ));
                    }
                    //baglantı kapat
                    read.Close();
                    //dondur listeyi
                    return students;
                }

                finally
                {
                    //bağlantıyı durumu açıksa
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
        public List<Student> GoreAra(string arananDeger,string satirAdi)
        {
            //ogrenci listesi olusturuyorum
            List<Student> students = new List<Student>();
            //conn degiskeni olusturuyorum
            using (OleDbConnection conn = new SqlConnection().Conn())
            {
                try
                {
                    //bağlantıyı ac
                    conn.Open();
                    //cmd degiskei olusturuyorum ve select sorgusu olusturuyorum
                    OleDbCommand cmd = new SqlConnection().cmd($"SELECT * FROM Students WHERE {satirAdi} LIKE '%{arananDeger}%'", conn);
                    OleDbDataReader read = cmd.ExecuteReader();
                    //read doluysa
                    while (read.Read())
                    {
                        students.Add(new Student(
                            read.GetInt32(0),
                            read.GetString(1),
                            read.GetString(2),
                            read.GetBoolean(3)

                            ));
                    }
                    //bağlantıyı kapat
                    read.Close();
                    //dondur listeyi
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
        #endregion

       
        #region GoreListele2
        //gore listele
        public List<Student> GoreListele(string satirAdi, bool istenendeger1)
        {
            //student listesi olsuturuyorum
            List<Student> students = new List<Student>();
            //conn degiskeni olusturuyorum
            using (OleDbConnection conn = new SqlConnection().Conn())
            {
                try
                {
                    //baglantıyı aç
                    conn.Open();
                    //cmd degiskeni olusturuyorum ve select sorgusu olusturuyorum
                    OleDbCommand cmd = new SqlConnection().cmd($"SELECT * FROM Students WHERE {satirAdi}={istenendeger1}", conn);
                    OleDbDataReader read = cmd.ExecuteReader();
                    //read doluysa
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
                    //lsiteyi dondur
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
#endregion
    }
}
