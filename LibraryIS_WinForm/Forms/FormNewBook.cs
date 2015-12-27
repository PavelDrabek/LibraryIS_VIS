using LibraryIS_WinForm.Controllers;
using LIS.Entities;
using LIS.Services;
using System;
using System.Windows.Forms;

namespace LibraryIS_WinForm.Forms
{
    public partial class FormNewBook : Form
    {
        BookService bookService;
        BookController bookController;

        public FormNewBook()
        {
            InitializeComponent();
            bookService = new BookService();
            bookController = new BookController(bookDetail1);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Book newBook = bookController.GetBook();
            bookService.Insert(newBook);
            this.Close();
        }
    }
}
