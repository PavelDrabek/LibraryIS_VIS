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
        AuthorService authorService;

        public BookController(IBookView view)
        {
            this.view = view;
            view.SetController(this);

            authorService = new AuthorService();
        }

        public void UpdateBook(Book book)
        {
            view.ID = book.ID;
            view.Title = book.Title;
            view.author = book.author;
            view.genre = book.genre;
            view.ISBN = book.ISBN;
            view.publisher = book.publisher;
            view.Language = book.Language;
            view.Pages = book.Pages;
        }

        public Book GetBook()
        {
            Book book = new Book();
            book.ID = view.ID;
            book.Title = view.Title;
            book.ISBN = view.ISBN;
            book.Language = view.Language;
            book.Pages = view.Pages;

            book.author = view.author;
            book.genre = view.genre;
            book.publisher = view.publisher;

            return book;
        }
    }
}
