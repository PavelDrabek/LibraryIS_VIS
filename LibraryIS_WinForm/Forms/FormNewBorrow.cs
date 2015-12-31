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
    public partial class FormNewBorrow : Form
    {
        BookController bookController;

        User selectedUser;
        Book selectedBook;

        public FormNewBorrow()
        {
            InitializeComponent();
            bookController = new BookController(bookDetail1);
        }

        private void btnChooseBook_Click(object sender, EventArgs e)
        {
            FormChooseBook form = new FormChooseBook();
            form.ShowDialog();

            if (form.ResultOK) {
                selectedBook = form.SelectedBook;
                bookController.SetBook(selectedBook);
            }
        }

        private void btnChooseUser_Click(object sender, EventArgs e)
        {
            /*
            FormChooseUser form = new FormChooseUser();
            form.ShowDialog();

            if (form.ResultOK) {
                selectedUser = form.SelectedUser;
                userDetail1.SetUser(selectedUser);
            }
            */
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (selectedBook != null && selectedUser != null) {
                Borrow newBorrow = new Borrow();
                newBorrow.UserID = selectedUser.ID;
                newBorrow.BookID = selectedBook.ID;
                newBorrow.Date = DateTime.Now;
                newBorrow.Returned = DateTime.MinValue;

                new BorrowService().Insert(newBorrow);
                this.Close();
            } else {
                MessageBox.Show("User or book was not selected", "Error");
            }
        }
    }
}
