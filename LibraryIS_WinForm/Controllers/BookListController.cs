using LibraryIS_WinForm.Views;
using LIS.Entities;
using LIS.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryIS_WinForm.Controllers
{
    public class BookListController
    {
        IBookListView view = null;
        BookService bookService;
        List<Book> books;
        Book selectedBook;

        public BookListController(IBookListView view)
        {
            this.view = view;

            bookService = new BookService();
            view.SetController(this);
            Refresh();
        }

        public IList Books
        {
            get { return ArrayList.ReadOnly(books); }
        }

        /*
        private void updateViewDetailValues(Book book)
        {
            view.ID = book.ID.ToString();
            view.Title = book.Title;
            view.Author = book.author.Name;
            view.Genre = book.genre.Name;
            view.ISBN = book.ISBN;
            view.Publisher = book.publisher.Name;
            view.Language = book.Language;
            view.Pages = book.Pages.ToString();
        }
        */
        public void Refresh()
        {
            view.FilterText = "";
            books = bookService.GetAllBooks();
            Show(books);
        }

        public void SelectedIdChanged(string selectedId)
        {
            foreach (Book book in this.books)
            {
                if (book.ID.ToString() == selectedId)
                {
                    selectedBook = book;
                    view.SetSelectedInGrid(book);
                    break;
                }
            }
        }

        public void Show(List<Book> list)
        {
            view.ClearGrid();
            foreach (Book book in list) {
                view.AddToGrid(book);
            }

            view.SetSelectedInGrid((Book)list[0]);
        }

        public void Filter()
        {
            Show(books.Where(x => x.Title.Contains(view.FilterText)).ToList());
        }
    }
}

