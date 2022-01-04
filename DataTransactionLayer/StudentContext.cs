using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransactionLayer
{
    public class StudentContext
    {
        //studentProvider nesnesi
        private StudentProvider studentProvider = new StudentProvider();
        //ogrenci ekliyor
        public Tuple<Boolean, string> InsertStudentContext(Student student)
        {
            //tuple nesnesi donduruyor
            return studentProvider.InsertStudent(student);
        }
        //ogrenci siliyor
        public Tuple<Boolean, string> DeleteStudentContext(int id)
        {
            //tuple nesnesi donduruyor
            return studentProvider.DeleteStudent(id);
        }
        //ogrenci guncelliyor
        public Tuple<Boolean, string> UpdateStudentContext(int id, Student student)
        {
            //tuple nesnesi donduruyor
            return studentProvider.UpdateStudent(student, id);
        }
        //1 ogrenci donduruyor
        public Tuple<Boolean, string, Student> getOneStudent(int id)
        {
            //tuple objesi donduruyor
            return studentProvider.OneRowReadStudent(id);
        }
        //butun ogrencilerini donduruyor
        public List<Student> GetStudents()
        {
            //ogrenci listesi donduruyor
            return studentProvider.ReadStudent();
        }
        //aranan degerleri gore arıyor
        public List<Student> GoreAra(string aranacakDeger,string satirAdi)
        {
            //ogrenci listesi donduruyor
            return studentProvider.GoreAra(aranacakDeger,satirAdi);
        }
        //aranan degerleri gore listeliyor
        public List<Student> GoreListele(string satirAdi, bool istenenDeger)
        {
            //ogrenci listesi donduruyor
            return studentProvider.GoreListele(satirAdi, istenenDeger);
        }
    }
}
