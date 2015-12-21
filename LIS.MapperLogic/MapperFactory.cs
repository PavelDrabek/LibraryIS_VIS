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

        /*
        public static DataMapper<T> CreateMapper<T>() where T : Entity
        {
            object mapper = null;
            Type type = typeof(T);

            if (typeof(Author) == type) {
                mapper = CreateAuthorMapper();
            } else if (typeof(Book) == type) {
                mapper = CreateBookMapper();
            }

            return (DataMapper<T>)Convert.ChangeType(mapper, typeof(DataMapper<T>));
        }
        */

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

        public static DataMapper<Genre> CreateGenreMapper()
        {
            if (!isInitialized) {
                Init();
            }

            switch (dataSource) {
                case "MySQL": return new GenreMapperMySQL();
                case "XML": throw new NotImplementedException();
                default:
                    throw new WrongDataSourceException("Not known DataSource " + dataSource);
            }
        }

        public static DataMapper<Publisher> CreatePublisherMapper()
        {
            if (!isInitialized) {
                Init();
            }

            switch (dataSource) {
                case "MySQL": return new PublisherMapperMySQL();
                case "XML": throw new NotImplementedException();
                default:
                    throw new WrongDataSourceException("Not known DataSource " + dataSource);
            }
        }

        public static DataMapper<User> CreateUserMapper()
        {
            if (!isInitialized) {
                Init();
            }

            switch (dataSource) {
                case "MySQL": return new UserMapperMySQL();
                case "XML": throw new NotImplementedException();
                default:
                    throw new WrongDataSourceException("Not known DataSource " + dataSource);
            }
        }
    }
}
