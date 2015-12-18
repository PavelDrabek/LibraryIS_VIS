using LIS.IDataMappers;
using LIS.MapperLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIS.Services
{
    public class LoginService
    {
        DataLogin datalogin;
        private string errorMsg;

        public LoginService()
        {
            datalogin = MapperFactory.CreateDataLogin();
        }

        public bool Login(string username, string password)
        {
            try {
                return datalogin.Login(username, password);
            } catch(Exception e) {
                errorMsg = e.Message;
                return false;
            }
        }

        public string GetErrorMsg() {
            return errorMsg;
        }
    }
}
