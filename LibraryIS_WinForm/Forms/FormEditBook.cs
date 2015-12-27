using LibraryIS_WinForm.Controllers;
using LIS.Entities;
using LIS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryIS_WinForm.Forms
{
    public partial class FormEditBook : Form
    {
        BookService bookService;
        BookController bookController;

        public FormEditBook(Book book)
        {
            InitializeComponent();

            bookService = new BookService();
            bookController = new BookController(bookDetail1);
            bookController.SetBook(book);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Book newBook = bookController.GetBook();
            bookService.Update(newBook);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
