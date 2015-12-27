using LIS.DAO;
using LIS.Entities;
using LIS.MapperLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIS.Services
{
    public class UserService : EntityService<User>
    {
        protected override DataMapper<User> GetDataMapper()
        {
            return MapperFactory.CreateUserMapper();
        }

    }
}
