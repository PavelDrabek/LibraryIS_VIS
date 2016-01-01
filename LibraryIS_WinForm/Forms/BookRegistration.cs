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
        UserListController userListController;

        public BookRegistration()
        {
            InitializeComponent();
            bookListController = new BookListController(bookList1);
            userListController = new UserListController(userList1);
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage.Equals(tabBooks)) {
                bookListController.Refresh();
            }
            if (e.TabPage.Equals(tabUsers)) {
                userListController.Refresh();
            }
            if (e.TabPage.Equals(tabBorrows)) {
                borrowList1.Refresh();
            }
        }

        private void btnBookBorrow_Click(object sender, EventArgs e)
        {
            Book book = bookListController.GetSelectedBook();
            if (book != null) {
                FormNewBorrow form = new FormNewBorrow();
                form.SetBook(book);
                form.ShowDialog();
                borrowList1.Refresh();
            } else {
                MessageBox.Show("Please select book");
            }
        }
        
        private void btnUserBorrow_Click(object sender, EventArgs e)
        {
            User user = userListController.GetSelectedUser();
            if (user != null) {
                FormNewBorrow form = new FormNewBorrow();
                form.SetUser(user);
                form.ShowDialog();
                borrowList1.Refresh();
            } else {
                MessageBox.Show("Please select book");
            }
        }

        private void btnBookNew_Click(object sender, EventArgs e)
        {
            Form newForm = new FormNewBook();
            newForm.ShowDialog();
            bookListController.Filter();
        }

        private void btnBookEdit_Click(object sender, EventArgs e)
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

        private void btnBookDelete_Click(object sender, EventArgs e)
        {
            Book book = bookListController.GetSelectedBook();
            new BookService().Delete(book.ID);
            bookListController.Filter();
        }

        private void btnUserEdit_Click(object sender, EventArgs e)
        {
            User toEdit = userListController.GetSelectedUser();
            if (toEdit == null) {
                MessageBox.Show("Please select user");
                return;
            }

            FormEditUser editForm = new FormEditUser(toEdit);
            editForm.ShowDialog();
            userListController.Filter();
        }

        private void btnUserDelete_Click(object sender, EventArgs e)
        {
            User user = userListController.GetSelectedUser();
            new UserService().Delete(user.ID);
            bookListController.Filter();
        }

        private void btnBorrowReturn_Click(object sender, EventArgs e)
        {
            Borrow borrow = borrowList1.GetSelectedBorrow();

            if (borrow == null) {
                MessageBox.Show("Please select entry");
                return;
            }

            if (borrow.IsReturned) {
                borrow.Returned = DateTime.MinValue;
            } else {
                borrow.Returned = DateTime.Now;
            }
            new BorrowService().Update(borrow);
            borrowList1.Refresh();
        }
    }
}
