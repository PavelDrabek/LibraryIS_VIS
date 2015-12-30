using LIS.Entities;
using LIS.DAO;
using LIS.MapperLogic;

namespace LIS.Services
{
    public class BorrowService : EntityService<Borrow>
    {
        protected override DataMapper<Borrow> GetDataMapper()
        {
            return MapperFactory.CreateBorrowMapper();
        }
    }
}
