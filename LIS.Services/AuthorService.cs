using LIS.Entities;
using LIS.DAO;
using LIS.MapperLogic;

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
