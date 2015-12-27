using LIS.Entities;
using LIS.DAO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIS.DataMappersMySQL
{
    public class DataLoginMySQL : DataLogin
    {

        protected MySqlConnection connection;

        public DataLoginMySQL()
        {
            connection = ConnectionFactory.Create();
        }

        protected override User GetUser(string userName, string password)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            string query = "SELECT user_id, username, firstname, lastname FROM User WHERE username = @username AND password = @password";

            using (MySqlCommand command = new MySqlCommand(query, connection)) {
                command.Parameters.AddWithValue("@username", userName);
                command.Parameters.AddWithValue("@password", password);
                using (MySqlDataReader reader = command.ExecuteReader()) {

                    if (reader.Read()) {
                        User user = new User();
                        user.ID = reader.GetInt32(0);
                        user.UserName = reader.GetString(1);
                        user.FirstName = reader.GetString(2);
                        user.LastName = reader.GetString(3);

                        connection.Close();
                        return user;
                    } else {
                        connection.Close();
                        throw new Exception("wrong username or password");
                    }
                }
            }
        }

        public override bool ChangePassword(string username, string oldPassword, string newPassword)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            string query = "UPDATE User SET password = @newpassword WHERE username = @username AND password = @password";

            using (MySqlCommand command = new MySqlCommand(query, connection)) {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@oldpassword", oldPassword);
                command.Parameters.AddWithValue("@newpassword", newPassword);

                int result = command.ExecuteNonQuery();
                connection.Close();

                if (result > 0) {
                    return true;
                } else {
                    throw new Exception("username or old password does not match");
                }
            }
        }
    }
}
