using LIS.DataMappersMySQL;
using LIS.Entities;
using LIS.IDataMappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIS.MapperLogic
{
    public static class MapperFactory
    {
        private static string dataSource = null;
        private static bool isInitialized = false;

        public static void Init()
        {
            dataSource = "MySQL";
            isInitialized = true;
        }

        public static DataLogin CreateDataLogin()
        {
            if (!isInitialized) {
                Init();
            }

            switch (dataSource) {
                case "MySQL": return new DataLoginMySQL();
                case "XML": throw new NotImplementedException();
                default:
                    throw new WrongDataSourceException("Not known DataSource " + dataSource);
            }
        }

        public static DataMapper<Book> CreateBookMapper()
        {
            if (!isInitialized) {
                Init();
            }

            switch (dataSource) {
                case "MySQL": return new BookMapperMySQL();
                case "XML": throw new NotImplementedException();
                default:
                    throw new WrongDataSourceException("Not known DataSource " + dataSource);
            }
        }

        public static DataMapper<Author> CreateAuthorMapper()
        {
            if (!isInitialized) {
                Init();
            }

            switch (dataSource) {
                case "MySQL": return new AuthorMapperMySQL();
                case "XML": throw new NotImplementedException();
                default:
                    throw new WrongDataSourceException("Not known DataSource " + dataSource);
            }
        }
    }
}
