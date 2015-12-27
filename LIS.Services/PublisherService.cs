using LIS.Entities;
using LIS.DAO;
using LIS.MapperLogic;

namespace LIS.Services
{
    public class PublisherService : EntityService<Publisher>
    {
        protected override DataMapper<Publisher> GetDataMapper()
        {
            return MapperFactory.CreatePublisherMapper();
        }
    }
}
