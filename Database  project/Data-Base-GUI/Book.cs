using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class Book
    {
        public int ISBN { get; set; }
        public int Quantity { get; set; }
        public string Title { get; set; }
        public int Rating { get; set; }
        public int BookID { get; set; }
        public int AuthorID { get; set; }
        public int PublisherID { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime PublishDate { get; set; }
    }

}
