using System;

namespace Model
{
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public bool sex { get; set; }

        public Student(int id, string name, string surname, bool sex)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.sex = sex;
        }
        public Student(string name, string surname, bool sex)
        {
            
            this.name = name;
            this.surname = surname;
            this.sex = sex;
        }
        public Student()
        {
            name = null;
        }
        public override string ToString()
        {
            return name;
        }
    }
}
