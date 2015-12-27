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
    public partial class BookRegistration : Form 
    {
        BookListController bookListController;

        public BookRegistration()
        {
            InitializeComponent();
            bookListController = new BookListController(bookList1);
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Form newForm = new FormNewBook();
            newForm.ShowDialog();
            bookListController.Filter();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Book bookToEdit = bookListController.GetSelectedBook();
            if (bookToEdit == null) {
                MessageBox.Show("Please select book");
                return;
            }

            FormEditBook editForm = new FormEditBook(bookToEdit);
            editForm.ShowDialog();
            bookListController.Filter();
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Book book = bookListController.GetSelectedBook();
            new BookService().Delete(book.ID);
            bookListController.Filter();
        }
    }
}
