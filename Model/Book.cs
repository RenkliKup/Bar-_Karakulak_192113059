using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Book
    {   
       //int tipinde id
        public int id { get; set; }
        //string tipinde name
        public string name { get; set; }
        //string tipinde type
        public string type { get; set; }
        //string tipinde author
        public string author { get; set; }
        //int tipinde page
        public int page { get; set; }
        //bool tipinde isDelivered
        public bool isDelivered { get; set; }
        //constructor
        public Book(int id, string name, string type, string author, int page,bool isDelivered)
        {
            //atamalar
            this.id = id;
            this.name = name;
            this.type = type;
            this.author = author;
            this.page = page;
            this.isDelivered = isDelivered;
        }
        //parametreleri farklı constructor
        public Book(string name, string type, string author, int page)
        {
            //atamalar
            this.name = name;
            this.type = type;
            this.author = author;
            this.page = page;
            
        }
        //parametresiz constructor
        public Book()
        {
            
            this.name = null;
        }
        //override to string
        public override string ToString()
        {
            return id.ToString();
        }
    }
}
