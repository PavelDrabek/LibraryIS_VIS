using LIS.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIS.DataMappersMySQL
{
    public class GenreMapperMySQL : DataMapperMySQL<Genre>
    {
        public override string TableName { get { return "Genre"; } }
        public override string PrimaryKey { get { return "genre_id"; } }
        public override string[] OtherKeys { get { return new string[] { "name" }; } }
        public override string[] GetOtherValues(Genre p) { return new string[] { p.Name }; }
        public override int GetPrimaryKeyValue(Genre p) { return p.ID; }

        protected override Genre ParseReader(MySqlDataReader reader)
        {
            return new Genre() {
                ID = reader.GetInt32(0),
                Name = reader.GetString(1),
            };
        }

        protected override MySqlParameter[] GetInsertParameters(Genre p)
        {
            return new MySqlParameter[] {
                new MySqlParameter("@name", p.Name) 
            };
        }
    }
}
