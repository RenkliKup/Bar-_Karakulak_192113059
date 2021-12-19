using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Book
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string author { get; set; }
        public int page { get; set; }

        public Book(int id, string name, string type, string author, int page)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.author = author;
            this.page = page;
        }
        public Book()
        {
            this.name = null;
        }

    }
}
