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
        public Boolean isDelivered { get; set; }

        public Library(int id, Student student, Book book, DateTime getDate, DateTime expiryDate, Boolean isDelivered)
        {
            this.id = id;
            this.student = student;
            this.book = book;
            this.getDate = getDate;
            this.expiryDate = expiryDate;
            this.isDelivered = isDelivered;
        }
    }
}
