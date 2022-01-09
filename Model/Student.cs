using System;

namespace Model
{
    public class Student
    {
        //int tipinde id
        public int id { get; set; }
        //string tipinde name
        public string name { get; set; }
        //string tipinde surname
        public string surname { get; set; }
        //bool tipinde sex
        public bool sex { get; set; }

        //parametreli constructor

        public Student(int id, string name, string surname, bool sex)
        {
            //atamalar
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.sex = sex;
        }

        //parametreleri farklı constructor
        public Student(string name, string surname, bool sex)
        {
         
            //atamalr
            this.name = name;
            this.surname = surname;
            this.sex = sex;
        }
        //parametresiz constructor
        public Student()
        {
            name = null;
        }
        //override tostring
        public override string ToString()
        {
            return id.ToString();
        }
    }
}
