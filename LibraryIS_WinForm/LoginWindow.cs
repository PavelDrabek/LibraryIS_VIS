using LibraryIS_WinForm.Controllers;
using LibraryIS_WinForm.Views;
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
    public partial class LoginWindow : Form, ILoginView
    {
        LoginController loginController = null;

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginController.Login();
        }

        public void SetController(LoginController controller)
        {
            loginController = controller;
        }

        public void OnLoginOK()
        {
            this.Hide();
            Form1 f = new Form1();
            f.Closed += (s, args) => this.Close(); 
            f.ShowDialog();
        }

        public void OnLoginError(string errorMsg)
        {
            MessageBox.Show(errorMsg);
        }

        public string UserName {
            get { return tbUsername.Text; }
            set { tbUsername.Text = value; }
        }

        public string Password
        {
            get { return tbPassword.Text; }
            set { tbPassword.Text = value; }
        }
    }
}
