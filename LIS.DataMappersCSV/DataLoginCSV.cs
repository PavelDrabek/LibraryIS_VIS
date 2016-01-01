using LIS.DAO;
using LIS.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIS.DataMappersCSV
{
    public class DataLoginCSV : DataLogin
    {
        protected string path;

        public DataLoginCSV(string filePath)
        {
            path = filePath + "user.csv";
        }

        protected override User GetUser(string userName, string password)
        {
            User user = null;
            using (StreamReader reader = File.OpenText(path)) {
                string line;
                while ((line = reader.ReadLine()) != null) {
                    string[] p = line.Split(';');
                    if (p[1].Equals(userName) && p[4].Equals(password)) {
                        user = new User();
                        user.ID = int.Parse(p[0]);
                        user.UserName = p[1];
                        user.FirstName = p[2];
                        user.LastName = p[3];

                        break;
                    }
                }
            }

            if (user == null) {
                throw new Exception("wrong username or password");
            }

            return user;
        }

        public override bool ChangePassword(string username, string oldPassword, string newPassword)
        {
            throw new NotImplementedException();
        }
    }
}
