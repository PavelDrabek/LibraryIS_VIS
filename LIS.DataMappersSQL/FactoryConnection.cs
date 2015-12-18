using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIS.DataMappersMySQL
{
    public static class FactoryConnection
    {
        public static MySqlConnection Create() {
            string server = "localhost";
            string database = "knihovna";
            string uid = "root";
            string password = "root";
            string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            return new MySqlConnection(connectionString);
        }
    }
}
