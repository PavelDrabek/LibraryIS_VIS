using LIS.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIS.DataMappersMySQL
{
    public class UserMapperMySQL : DataMapperMySQL<User>
    {
        public override string TableName { get { return "User"; } }
        public override string PrimaryKey { get { return "user_id"; } }
        public override string[] OtherKeys { get { return new string[] { "username", "firstname", "lastname" }; } }
        public override string[] GetOtherValues(User p) { return new string[] { p.UserName, p.FirstName, p.LastName }; }
        public override int GetPrimaryKeyValue(User p) { return p.ID; }

        protected override User ParseReader(MySqlDataReader reader)
        {
            return new User() {
                ID = reader.GetInt32(0),
                UserName = reader.GetString(1),
                FirstName = reader.GetString(2),
                LastName = reader.GetString(3),
            };
        }

        protected override MySqlParameter[] GetInsertParameters(User p)
        {
            return new MySqlParameter[] {
                new MySqlParameter("@username", p.UserName), 
                new MySqlParameter("@firstname", p.FirstName), 
                new MySqlParameter("@lastname", p.LastName) 
            };
        }

        protected override MySqlCommand GetSearchCommand(string searchText)
        {
            string LIKE = "LIKE '%" + searchText + "%'";
            string QUERY = QUERY_SELECT + " WHERE username " + LIKE + " OR firstname " + LIKE + " OR lastname " + LIKE;
            return new MySqlCommand(QUERY, connection);
        }
    }
}
