using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIS.Entities
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }
        public int GenreID { get; set; }
        public string ISBN { get; set; }
        public int PublisherID { get; set; }
        public string Language { get; set; }
        public int Pages { get; set; }

        public Publisher publisher { get; set; }
        public Author author { get; set; }
        public Genre genre { get; set; }

        public override string ToString() {
            return "{ ID: " + ID +
                ", Title: " + Title +
                ", AuthorID: " + AuthorID +
                ", GenreID: " + GenreID +
                ", ISBN: " + ISBN +
                ", PublisherID: " + PublisherID +
                ", Language: " + Language +
                ", Pages: " + Pages;
        }
    }
}
