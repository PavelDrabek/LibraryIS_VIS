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
    public partial class FormEditUser : Form
    {
        public FormEditUser(User user)
        {
            InitializeComponent();
            userDetail1.SetUser(user);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            User newUser = userDetail1.GetUser();
            new UserService().Update(newUser);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
