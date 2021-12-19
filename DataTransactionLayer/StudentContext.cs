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
        public Tuple<Boolean, string> UpdateStudentContext(int id, Student book)
        {
            return studentProvider.UpdateStudent(book, id);
        }
        public Tuple<Boolean, string, Student> getOneStudent(int id)
        {
            return studentProvider.OneRowReadStudent(id);
        }
        public List<Student> GetStudents()
        {
            return studentProvider.ReadStudent();
        }
    }
}
