using LIS.DataMappersMySQL;
using LIS.DataMappersCSV;
using LIS.Entities;
using LIS.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LIS.MapperLogic
{
    public static class MapperFactory
    {
        private static bool isInitialized = false;
        
        private static string dataSource = null;
        private static string csvPath = null;        

        public static void Init()
        {
            //dataSource = "CSV";
            //csvPath = "..\\..\\..\\db_CSV\\";
            LoadConfigFile("..\\..\\..\\conf.ini");
            isInitialized = true;
        }

        private static bool LoadConfigFile(string filePath)
        {
            StreamReader reader = File.OpenText(filePath);
            string line;
            while ((line = reader.ReadLine()) != null) {
                string[] p = line.Split('=');
                switch (p[0]) {
                    case "DataSource":
                        dataSource = p[1];
                        break;
                    case "CsvPath":
                        csvPath = p[1];
                        break;
                    default:
                        throw new Exception("Unknown parameter in config file: " + p[0]);
                }
            }
            reader.Close();

            return true;
        }

        public static DataLogin CreateDataLogin()
        {
            if (!isInitialized) {
                Init();
            }

            switch (dataSource) {
                case "MySQL": return new DataLoginMySQL();
                case "CSV": return new DataLoginCSV(csvPath);
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
                case "CSV": return new BookMapperCSV(csvPath);
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
                case "CSV": return new AuthorMapperCSV(csvPath);
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
                case "CSV": return new GenreMapperCSV(csvPath);
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
                case "CSV": return new PublisherMapperCSV(csvPath);
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
                case "CSV": return new UserMapperCSV(csvPath);
                default:
                    throw new WrongDataSourceException("Not known DataSource " + dataSource);
            }
        }

        public static DataMapper<Borrow> CreateBorrowMapper()
        {
            if (!isInitialized) {
                Init();
            }

            switch (dataSource) {
                case "MySQL": return new BorrowMapperMySQL();
                case "CSV": return new BorrowMapperCSV(csvPath);
                default:
                    throw new WrongDataSourceException("Not known DataSource " + dataSource);
            }
        }
    }
}
