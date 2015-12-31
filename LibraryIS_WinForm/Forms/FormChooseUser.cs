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
    public partial class FormChooseUser : Form
    {
        UserListController controller;

        private bool resultOK;
        public bool ResultOK { get { return resultOK; } }

        private User selectedUser;
        public User SelectedUser { get { return selectedUser; } }

        public FormChooseUser()
        {
            InitializeComponent();

            controller = new UserListController(userList1);
            resultOK = false;
            selectedUser = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            resultOK = false;
            selectedUser = null;
            this.Close();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            selectedUser = controller.GetSelectedUser();
            if (selectedUser != null) {
                resultOK = true;
                this.Close();
            } else {
                MessageBox.Show("No book was selected", "Error");
            }
        }
    }
}
