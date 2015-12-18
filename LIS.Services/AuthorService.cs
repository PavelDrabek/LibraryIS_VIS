using LIS.Entities;
using LIS.IDataMappers;
using LIS.MapperLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIS.Services
{
    public class AuthorService : EntityService<Author>
    {
        protected override DataMapper<Author> GetDataMapper()
        {
            return MapperFactory.CreateAuthorMapper();
        }
    }
}
