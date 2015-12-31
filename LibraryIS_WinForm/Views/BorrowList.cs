using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LIS.Entities;
using LIS.Services;

namespace LibraryIS_WinForm.Views
{
    public partial class BorrowList : UserControl
    {

        public BorrowList()
        {
            InitializeComponent();

            borrowService = new BorrowService();
            if (!Program.IsInDesignMode()) {
                Refresh();
            }
        }

        private bool IsSomethingSelected()
        {
            return (lvBorrows.SelectedIndices.Count > 0);
        }

        public void ClearGrid()
        {
            lvBorrows.Items.Clear();
        }

        public void AddToGrid(Borrow b)
        {
            string[] row = { 
                b.ID.ToString(), 
                b.Date.ToString(), 
                b.Returned.ToString(), 
                b.book.Title,
                b.user.ToString()
            };
            ListViewItem item = new ListViewItem(row);
            lvBorrows.Items.Add(item);
        }

        public int GetSelectedIndex()
        {
            if (IsSomethingSelected()) {
                return lvBorrows.SelectedIndices[0];
            } else {
                return -1;
            }
        }

        /// Controller
        
        BorrowService borrowService;
        List<Borrow> borrows;

        public void Refresh()
        {
            Show(borrowService.GetAll());
        }

        public void Show(List<Borrow> list)
        {
            borrows = list;
            ClearGrid();
            foreach (Borrow b in borrows) {
                AddToGrid(b);
            }
        }

        public Borrow GetSelectedBorrow()
        {
            int selectedIndex = GetSelectedIndex();
            if (selectedIndex >= 0 && selectedIndex < borrows.Count) {
                return borrows[selectedIndex];
            } else {
                return null;
            }
        }
    }
}
