using LIS.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIS.DataMappersMySQL
{
    public class AuthorMapperMySQL : DataMapperMySQL<Author>
    {
        public override string TableName { get { return "Author"; } }
        public override string PrimaryKey { get { return "author_id"; } }
        public override string[] OtherKeys { get { return new string[] { "firstname", "middlename", "lastname" }; } }
        public override string[] GetOtherValues(Author p) { return new string[] { p.Name }; }
        public override int GetPrimaryKeyValue(Author p) { return p.ID; }

        protected override Author ParseReader(MySqlDataReader reader)
        {
            return new Author() {
                ID = reader.GetInt32(0),
                FirstName = reader.GetString(1),
                MiddleName = reader.GetString(2),
                LastName = reader.GetString(3),
            };
        }

        protected override MySqlParameter[] GetInsertParameters(Author p)
        {
            return new MySqlParameter[] {
                new MySqlParameter("@firstname", p.FirstName), 
                new MySqlParameter("@middlename", p.MiddleName), 
                new MySqlParameter("@lastname", p.LastName)
            };
        }
    }
}
