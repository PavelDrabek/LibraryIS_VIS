using LIS.Entities;
using LIS.DAO;
using LIS.MapperLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIS.Services
{
    public class GenreService : EntityService<Genre>
    {
        protected override DataMapper<Genre> GetDataMapper()
        {
            return MapperFactory.CreateGenreMapper();
        }
    }
}
