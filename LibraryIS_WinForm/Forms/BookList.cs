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
            new BookListController(this);
        }

        public void SetController(BookListController controller)
        {
            this.controller = controller;
        }

        private bool IsSomethingSelected()
        {
            return (lvBooks.SelectedItems.Count > 0);
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
                book.AuthorID.ToString(), 
                book.GenreID.ToString(), 
                book.ISBN, 
                book.PublisherID.ToString(), 
                book.Language, 
                book.Pages.ToString() 
            };
            ListViewItem bookItem = new ListViewItem(row);
            lvBooks.Items.Add(bookItem);
        }

        public string GetSelectedID()
        {
            if (IsSomethingSelected()) {
                return lvBooks.SelectedItems[0].SubItems[0].Text;
            } else {
                return null;
            }
        }

        public void SetSelectedInGrid(Book book)
        {
            foreach (ListViewItem row in lvBooks.Items) {
                if (row.Text == book.ID.ToString()) {
                    row.Selected = true;
                }
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
