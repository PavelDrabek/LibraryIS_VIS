using LIS.Entities;
using LIS.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIS.Services
{
    public abstract class EntityService<T> where T : Entity
    {
        DataMapper<T> mapper;
        protected abstract DataMapper<T> GetDataMapper();

        public EntityService() {
            mapper = GetDataMapper();
        }

        public List<T> GetAll() {
            return mapper.Select();
        }

        public T Get(int id) {
            return mapper.Get(id);
        }

        public bool Update(T instance) {
            return mapper.Update(instance);
        }

        public bool Insert(T instance) {
            return mapper.Insert(instance);
        }

        public bool Delete(int id) {
            return mapper.Delete(id);
        }

        public List<T> Search(string searchText) {
            return mapper.Search(searchText);
        }
    }
}
