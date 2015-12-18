using LIS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIS.IDataMappers {
    public abstract class DataLogin {

        public User loggedUser { get; set; }

        protected abstract User GetUser(string userName, string pwdSHA1);
        public abstract bool ChangePassword(string username, string oldPwdSHA1, string newPwdSHA1);

        public bool Login(string userName, string password)
        {
            string pwdSHA1 = password;

            loggedUser = GetUser(userName, pwdSHA1);
            return loggedUser != null;
        }
    }
}
