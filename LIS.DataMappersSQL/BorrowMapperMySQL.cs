using LIS.DAO;
using LIS.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIS.DataMappersMySQL
{
    public class BorrowMapperMySQL : DataMapperMySQL<Borrow>
    {
        public override string TableName { get { return "Borrow"; } }
        public override string PrimaryKey { get { return "borrow_id"; } }
        public override string[] OtherKeys { get { return new string[] { "date", "returned", "book_id", "user_id" }; } }
        public override string[] GetOtherValues(Borrow b) { return new string[] { b.Date.ToString(DataMapper<Borrow>.DATE_FORMAT), b.Returned.ToString(DataMapper<Borrow>.DATE_FORMAT), b.BookID.ToString(), b.UserID.ToString() }; }
        public override int GetPrimaryKeyValue(Borrow b) { return b.ID; }

        private BookMapperMySQL bookMapper;
        private UserMapperMySQL userMapper;

        public BorrowMapperMySQL() : base()
        {
            bookMapper = new BookMapperMySQL();
            userMapper = new UserMapperMySQL();
        }

        protected override Borrow ParseReader(MySqlDataReader reader)
        {
            return new Borrow() {
                ID = reader.GetInt32(0),
                Date = DateTime.Parse(reader.GetString(1)),
                Returned = (reader.IsDBNull(2) ? DateTime.MinValue : DateTime.Parse(reader.GetString(2))),
                BookID = reader.GetInt32(3),
                UserID = reader.GetInt32(4)
            };
        }

        public override List<Borrow> SelectWithCommand(MySqlCommand command)
        {
            List<Borrow> borrows = base.SelectWithCommand(command);

            for (int i = 0; i < borrows.Count; i++) {
                borrows[i].user = userMapper.Get(borrows[i].UserID);
                borrows[i].book = bookMapper.Get(borrows[i].BookID);
            }

            return borrows;
        }

        protected override MySqlParameter[] GetInsertParameters(Borrow b)
        {
            return new MySqlParameter[] {
                new MySqlParameter("@date", b.Date.ToString(DataMapper<Borrow>.DATE_FORMAT)), 
                new MySqlParameter("@returned", !b.IsReturned ? null : b.Returned.ToString(DataMapperMySQL<Borrow>.DATE_FORMAT)), 
                new MySqlParameter("@book_id", b.BookID), 
                new MySqlParameter("@user_id", b.UserID) 
            };
        }

        protected override MySqlCommand GetSearchCommand(string searchText)
        {
            string LIKE = "LIKE '%" + searchText + "%'";
            string QUERY = QUERY_SELECT + " WHERE date " + LIKE + " OR returned " + LIKE;
            return new MySqlCommand(QUERY, connection);
        }
    }
}
