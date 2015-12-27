using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryIS_WinForm.IViews;
using LibraryIS_WinForm.Controllers;
using LIS.Entities;

namespace LibraryIS_WinForm.Views
{
    public partial class UserList : UserControl, IUserListView
    {
        UserListController controller;

        public UserList()
        {
            InitializeComponent();
        }

        public void SetController(UserListController controller)
        {
            this.controller = controller;
        }

        private bool IsSomethingSelected()
        {
            return (lvUsers.SelectedIndices.Count > 0);
        }

        public void ClearGrid()
        {
            lvUsers.Items.Clear();
        }

        public void AddToGrid(User user)
        {
            string[] row = { 
                user.ID.ToString(), 
                user.UserName, 
                user.FirstName, 
                user.LastName, 
            };
            ListViewItem item = new ListViewItem(row);
            lvUsers.Items.Add(item);
        }

        public int GetSelectedIndex()
        {
            if (IsSomethingSelected()) {
                return lvUsers.SelectedIndices[0];
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
