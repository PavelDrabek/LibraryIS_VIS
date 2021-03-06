﻿using LibraryIS_WinForm.Views;
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

        public BookListController(IBookListView view)
        {
            this.view = view;

            bookService = new BookService();
            view.SetController(this);
            Refresh();
        }

        public void Refresh()
        {
            view.FilterText = "";
            Show(bookService.GetAll());
        }

        public void Show(List<Book> list)
        {
            books = list;
            view.ClearGrid();
            foreach (Book book in books) {
                view.AddToGrid(book);
            }

            //view.SetSelectedInGrid(books[0]);
        }

        public void Filter()
        {
            if (view.FilterText == "") {
                Show(bookService.GetAll());
            } else {
                Show(bookService.Search(view.FilterText));
            }
        }

        public Book GetSelectedBook()
        {
            int selectedIndex = view.GetSelectedIndex();
            if (selectedIndex >= 0 && selectedIndex < books.Count) {
                return books[selectedIndex];
            } else {
                return null;
            }
        }
    }
}

