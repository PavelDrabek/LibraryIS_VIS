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
        public override string[] GetOtherValues(Book b) { return new string[] { b.Title, b.ISBN, b.Pages.ToString(), b.GenreID.ToString(), b.AuthorID.ToString(), b.PublisherID.ToString() }; }
        public override int GetPrimaryKeyValue(Book b) { return b.ID; }

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

        protected override MySqlParameter[] GetInsertParameters(Book b) 
        {
            return new MySqlParameter[] {
                new MySqlParameter("@title", b.Title), 
                new MySqlParameter("@isbn", b.ISBN), 
                new MySqlParameter("@pages", b.Pages), 
                new MySqlParameter("@genre_id", b.GenreID), 
                new MySqlParameter("@author_id", b.AuthorID), 
                new MySqlParameter("@publisher_id", b.PublisherID)
            };
        }

        protected override MySqlCommand GetSearchCommand(string searchText)
        {
            string LIKE = "LIKE '%" + searchText + "%'";
            string QUERY = QUERY_SELECT + " WHERE title " + LIKE + " OR isbn " + LIKE;
            return new MySqlCommand(QUERY, connection);
        }
    }
}
