using LibraryIS_WinForm.Controllers;
using LIS.Entities;
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
    public partial class FormChooseBook : Form
    {
        BookListController controller;

        private bool resultOK;
        public bool ResultOK { get { return resultOK; } }

        private Book selectedBook;
        public Book SelectedBook { get { return selectedBook; } }

        public FormChooseBook()
        {
            InitializeComponent();

            controller = new BookListController(bookList1);
            resultOK = false;
            selectedBook = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            resultOK = false;
            selectedBook = null;
            this.Close();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            selectedBook = controller.GetSelectedBook();
            if (selectedBook != null) {
                resultOK = true;
                this.Close();
            } else {
                MessageBox.Show("No book was selected", "Error");
            }
        }
    }
}
