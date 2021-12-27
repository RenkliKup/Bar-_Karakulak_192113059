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
        private StudentProvider studentProvider = new StudentProvider();
        public Tuple<Boolean, string> InsertStudentContext(Student student)
        {
            return studentProvider.InsertStudent(student);
        }
        public Tuple<Boolean, string> DeleteStudentContext(int id)
        {
            return studentProvider.DeleteStudent(id);
        }
        public Tuple<Boolean, string> UpdateStudentContext(int id, Student student)
        {
            return studentProvider.UpdateStudent(student, id);
        }
        public Tuple<Boolean, string, Student> getOneStudent(int id)
        {
            return studentProvider.OneRowReadStudent(id);
        }
        public List<Student> GetStudents()
        {
            return studentProvider.ReadStudent();
        }
        public List<Student> GoreAra(string aranacakDeger,string satirAdi)
        {
            return studentProvider.GoreAra(aranacakDeger,satirAdi);
        }
        
        public List<Student> GoreListele(string satirAdi, bool istenenDeger)
        {
            return studentProvider.GoreListele(satirAdi, istenenDeger);
        }
    }
}
