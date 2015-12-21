using LIS.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIS.DataMappersMySQL
{
    public class PublisherMapperMySQL : DataMapperMySQL<Publisher>
    {
        public override string TableName { get { return "Publisher"; } }
        public override string PrimaryKey { get { return "publisher_id"; } }
        public override string[] OtherKeys { get { return new string[] { "name" }; } }
        public override string[] GetOtherValues(Publisher p) { return new string[] { p.Name }; }
        public override int GetPrimaryKeyValue(Publisher p) { return p.ID; }

        protected override Publisher ParseReader(MySqlDataReader reader)
        {
            return new Publisher() {
                ID = reader.GetInt32(0),
                Name = reader.GetString(1),
            };
        }

        protected override MySqlParameter[] GetInsertParameters(Publisher p)
        {
            return new MySqlParameter[] {
                new MySqlParameter("@name", p.Name) 
            };
        }
    }
}
