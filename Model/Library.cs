using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Library
    {
        public int id { get; set; }
        public Student student { get; set; }
        public Book book { get; set; }
        public DateTime getDate { get; set; }
        public DateTime expiryDate { get; set; }
        public decimal debt { get; set; }
        public string deliveredDate { get; set; }

        public Library(int id, Student student, Book book, DateTime getDate, DateTime expiryDate,decimal debt,string deliveredDate)
        {
            this.id = id;
            this.student = student;
            this.book = book;
            this.getDate = getDate;
            this.expiryDate = expiryDate;
            this.debt = debt;
            this.deliveredDate = deliveredDate;
        }
        public Library(Student student, Book book)
        {
            this.student = student;
            this.book = book;
        }
        public Library()
        {
            
        }
    }
}
