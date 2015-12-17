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
    public class BookService {
        DataMapper<Book> bookMapper;

        public BookService() {
            bookMapper = MapperFactory.CreateBookMapper();
        }

        public List<Book> GetAllBooks() {
            return bookMapper.Select();
        }

        public Book GetBook(int id) {
            return bookMapper.Get(id);
        }

        public bool UpdateBook(Book book) {
            return bookMapper.Update(book);
        }

        public bool InsertBook(Book book) {
            return bookMapper.Insert(book);
        }

        public bool DeleteBook(int id) {
            return bookMapper.Delete(id);
        }
    }
}
