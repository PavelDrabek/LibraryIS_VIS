using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIS.Entities
{
    public class Book : Entity
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }
        public int GenreID { get; set; }
        public string ISBN { get; set; }
        public int PublisherID { get; set; }
        public string Language { get; set; }
        public int Pages { get; set; }

        private Publisher _publisher;
        private Author _author;
        private Genre _genre;

        public Publisher publisher { 
            get { return _publisher; } 
            set { 
                _publisher = value;
                if (_publisher != null)
                    PublisherID = _publisher.ID; 
            } 
        }
        public Author author
        {
            get { return _author; }
            set
            {
                _author = value;
                if (_author != null)
                    AuthorID = _author.ID;
            }
        }
        public Genre genre
        {
            get { return _genre; }
            set
            {
                _genre = value;
                if (_genre != null)
                    GenreID = _genre.ID;
            }
        }

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
