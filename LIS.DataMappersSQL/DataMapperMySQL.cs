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

        public abstract int GetPrimaryKeyValue(T instance);
        public abstract string[] GetOtherValues(T instance);

        public string QUERY_SELECT { get { return "SELECT " + PrimaryKey + ", " + string.Join(",", OtherKeys) + " FROM " + TableName; } }
        public string QUERY_SELECT_ONE { get { return QUERY_SELECT + " WHERE " + PrimaryKey + " = @" + PrimaryKey; } }
        public string QUERY_INSERT { get { return "INSERT INTO " + TableName + " (" + string.Join(",", OtherKeys) + ") VALUES (@" + string.Join(", @", OtherKeys) + ")"; } }
        public string QUERY_UPDATE { get { return "UPDATE " + TableName + " SET " + QUERY_SET_PAIRS + " WHERE " + PrimaryKey + " = @" + PrimaryKey; } }
        public string QUERY_DELETE { get { return "DELETE FROM " + TableName + " WHERE " + PrimaryKey + " = @" + PrimaryKey; } }

        private string QUERY_SET_PAIRS { 
            get {
                /*
                string[] keys = OtherKeys;
                string[] pairs = new string[keys.Length];
                for(int i = 0; i < keys.Length; i++) {
                    pairs[i] = (keys[i] + "=@" + keys[i]);
                }
                return string.Join(",", pairs);
                */
                return string.Join(",", OtherKeys.Select(x => (x + "=@" + x)));
            }
        }

        protected abstract T ParseReader(MySqlDataReader reader);
        protected abstract MySqlParameter[] GetInsertParameters(T instance);
        
        public DataMapperMySQL()
        {
            connection = FactoryConnection.Create();
        }

        public override List<T> Select()
        {
            List<T> returnValue = new List<T>();
           
            if (connection.State != ConnectionState.Open)
                connection.Open();
           
            using (MySqlCommand command = new MySqlCommand(QUERY_SELECT, connection)) {
                using (MySqlDataReader reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        returnValue.Add(ParseReader(reader));
                    }
                }
            }

            return returnValue;
        }

        public override bool Insert(T instance)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            using (MySqlCommand command = new MySqlCommand(QUERY_INSERT, connection)) {
                MySqlParameter[] parameters = GetInsertParameters(instance);
                foreach (MySqlParameter param in parameters) {
                    command.Parameters.Add(param);
                }
                return command.ExecuteNonQuery() > 0;
            }
        }

        public override T Get(int ID) {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            using (MySqlCommand command = new MySqlCommand(QUERY_SELECT_ONE, connection)) {
                command.Parameters.AddWithValue("@" + PrimaryKey, ID);
                using (MySqlDataReader reader = command.ExecuteReader()) {
                    if (reader.Read()) {
                        return ParseReader(reader);
                    } else {
                        return default(T);
                    }
                }
            }
        }

        public override bool Update(T instance) {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            using (MySqlCommand command = new MySqlCommand(QUERY_UPDATE, connection)) {
                MySqlParameter[] parameters = GetInsertParameters(instance);
                foreach (MySqlParameter param in parameters) {
                    command.Parameters.Add(param);
                }
                command.Parameters.AddWithValue("@" + PrimaryKey, GetPrimaryKeyValue(instance));

                return command.ExecuteNonQuery() > 0;
            }
        }

        public override bool Delete(int ID) {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            using (MySqlCommand command = new MySqlCommand(QUERY_DELETE, connection)) {
                command.Parameters.AddWithValue("@" + PrimaryKey, ID);
                return command.ExecuteNonQuery() > 0;
            }
        }
    }
}
