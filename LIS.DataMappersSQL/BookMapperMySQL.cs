using LIS.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIS.DataMappersMySQL
{
    public class BookMapperMySQL : DataMapperMySQL<Book>
    {
        public override string TableName { get { return "Book"; } }
        public override string PrimaryKey { get { return "book_id"; } }
        public override string[] OtherKeys { get { return new string[]{ "title", "isbn", "pages", "genre_id", "author_id", "publisher_id" }; } }
        public override string[] OtherValues(Book b) { return new string[] { b.Title, b.ISBN, b.Pages.ToString(), b.GenreID.ToString(), b.AuthorID.ToString(), b.PublisherID.ToString() }; }

        protected override Book ParseReader (MySqlDataReader reader)
        {
            return new Book()
            {
                ID = reader.GetInt32(0),
                Title = reader.GetString(1),
                ISBN = reader.GetString(2),
                Pages = reader.GetInt32(3),
                GenreID = reader.GetInt32(4),
                AuthorID = reader.GetInt32(5),
                PublisherID = reader.GetInt32(6)
            };
        }

        public override Book Get(int ID)
        {
            throw new NotImplementedException();
        }

        public override Book Get(Book instance)
        {
            throw new NotImplementedException();
        }

        public override bool Insert(Book instance)
        {
            throw new NotImplementedException();
        }

        public override bool Update(Book instance)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(Book instance)
        {
            throw new NotImplementedException();
        }
    }
}
