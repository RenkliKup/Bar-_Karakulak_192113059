using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Library
    {
        //int tipinde id
        public int id { get; set; }
        //student tipinde student
        public Student student { get; set; }
        //BOOK TİPİNDE BOOK
        public Book book { get; set; }
        //datetime tipinde getDate
        public DateTime getDate { get; set; }
        //Datetime tipinde expiryDate
        public DateTime expiryDate { get; set; }
        //decimal tipinde debt
        public decimal debt { get; set; }
        //string tipinde deliveredDate
        public string deliveredDate { get; set; }

        //constructor parametreli
        public Library(int id, Student student, Book book, DateTime getDate, DateTime expiryDate,decimal debt,string deliveredDate)
        {
            //atamalar
            this.id = id;
            this.student = student;
            this.book = book;
            this.getDate = getDate;
            this.expiryDate = expiryDate;
            this.debt = debt;
            this.deliveredDate = deliveredDate;
        }
        //farklı parametreli constructor
        public Library(Student student, Book book)
        {
            //atamalar
            this.student = student;
            this.book = book;
        }
        //parametresiz constructor
        public Library()
        {
            
        }
    }
}
