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

namespace LibraryIS_WinForm.Views
{
    public partial class UserDetail : UserControl
    {

        private int userId = -1;

        public UserDetail()
        {
            InitializeComponent();
            userId = -1;
        }

        public void SetUser(User user)
        {
            tbUsername.Text = user.UserName;
            tbFirstname.Text = user.FirstName;
            tbLastname.Text = user.LastName;
            userId = user.ID;
        }

        public User GetUser()
        {
            User user = new User();

            user.ID = userId;
            user.UserName = tbUsername.Text;
            user.FirstName = tbFirstname.Text;
            user.LastName = tbLastname.Text;

            return user;
        }
    }
}
