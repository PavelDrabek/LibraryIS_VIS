using LibraryIS_WinForm.Views;
using LIS.Entities;
using LIS.DAO;
using LIS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryIS_WinForm.Controllers
{
    public class BookController
    {
        IBookView view;

        public BookController(IBookView view)
        {
            this.view = view;
            view.SetController(this);
        }

        public void SetBook(Book book)
        {
            view.ID = book.ID;
            view.Title = book.Title;
            view.author = book.author;
            view.genre = book.genre;
            view.ISBN = book.ISBN;
            view.publisher = book.publisher;
            view.NumOfPages = book.Pages;
        }

        public Book GetBook()
        {
            Book book = new Book();
            book.ID = view.ID;
            book.Title = view.Title;
            book.ISBN = view.ISBN;
            book.Pages = view.NumOfPages;

            book.author = view.author;
            book.genre = view.genre;
            book.publisher = view.publisher;

            return book;
        }
    }
}
