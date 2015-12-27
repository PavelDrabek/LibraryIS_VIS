using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryIS_WinForm.Views;
using LibraryIS_WinForm.Controllers;
using LIS.Entities;

namespace LibraryIS_WinForm.Forms
{
    public partial class BookList : UserControl, IBookListView
    {
        BookListController controller;

        public BookList()
        {
            InitializeComponent();
        }

        public void SetController(BookListController controller)
        {
            this.controller = controller;
        }

        private bool IsSomethingSelected()
        {
            return (lvBooks.SelectedIndices.Count > 0);
        }

        public void ClearGrid()
        {
            lvBooks.Items.Clear();
        }

        public void AddToGrid(Book book)
        {
            string[] row = { 
                book.ID.ToString(), 
                book.Title, 
                book.author.ToString(), 
                book.genre.ToString(), 
                book.ISBN, 
                book.publisher.ToString(), 
                book.Pages.ToString() 
            };
            ListViewItem bookItem = new ListViewItem(row);
            lvBooks.Items.Add(bookItem);
        }

        public int GetSelectedIndex()
        {
            if (IsSomethingSelected()) {
                return lvBooks.SelectedIndices[0];
            } else {
                return -1;
            }
        }

        public string FilterText  {
            get { return tbFilter.Text; }
            set { tbFilter.Text = value; }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            controller.Filter();
        }
    }
}
