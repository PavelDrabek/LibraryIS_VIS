using LIS.IDataMappers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIS.DataMappersMySQL
{
    public abstract class DataMapperMySQL<T> : DataMapper<T>
    {
        protected MySqlConnection connection;
        public abstract string TableName { get; }
        public abstract string PrimaryKey { get; }
        public abstract string[] OtherKeys { get; }
        public abstract string[] OtherValues(T instance);

        public string QUERY_SELECT { get { return "SELECT " + PrimaryKey + ", " + string.Join(",", OtherKeys) + " FROM " + TableName; } }
        public string QUERY_INSERT(T instance) { return "INSERT INTO " + TableName + " (" + string.Join(",", OtherKeys) + ") VALUES (" + string.Join(",", OtherValues(instance)) + ")"; }

        public DataMapperMySQL()
        {
            string server = "localhost";
            string database = "knihovna";
            string uid = "root";
            string password = "root";
            string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }

        protected abstract T ParseReader(MySqlDataReader reader);
        public override List<T> Select()
        {
            List<T> returnValue = new List<T>();

            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                using (MySqlCommand command = new MySqlCommand(QUERY_SELECT, connection)) {
                    using (MySqlDataReader reader = command.ExecuteReader()) {
                        while (reader.Read()) {
                            returnValue.Add(ParseReader(reader));
                        }
                    }
                }
            }
            catch (Exception e) {
                throw;
            }

            return returnValue;
        }
    }
}
