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

namespace LibraryIS_WinForm
{
    public partial class Form1 : Form
    {
        BookService bookService = null;

        public Form1()
        {
            InitializeComponent();

            bookService = new BookService();
        }

        private void btnSelectAll_Click(object sender, EventArgs e) {
            List<Book> books = bookService.GetAllBooks();

            String[] str = books.Select(x => x.ToString()).ToArray();
            MessageBox.Show(string.Join("\n", str));
        }

        private void btnSelectById_Click(object sender, EventArgs e) {
            Book book = bookService.GetBook(GetIDFromTextBox());
            MessageBox.Show(book.ToString());
        }

        private void btnUpdatePages_Click(object sender, EventArgs e) {
            Book book = bookService.GetBook(GetIDFromTextBox());
            book.Pages = GetPagesFromTextBox();
            MessageBox.Show(bookService.UpdateBook(book).ToString());
        }

        private void btnInsertPages_Click(object sender, EventArgs e) {
            Book book = bookService.GetBook(GetIDFromTextBox());
            book.Pages = GetPagesFromTextBox();
            MessageBox.Show(bookService.InsertBook(book).ToString());
        }

        private void btnDeleteById_Click(object sender, EventArgs e) {
            MessageBox.Show(bookService.DeleteBook(GetIDFromTextBox()).ToString());
        }

        private int GetIDFromTextBox() {
            return int.Parse(tbID.Text);
        }

        private int GetPagesFromTextBox() {
            return int.Parse(tbPages.Text);
        }
    }
}
