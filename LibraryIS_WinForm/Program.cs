using LibraryIS_WinForm.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryIS_WinForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginWindow loginWindow = new LoginWindow();
            LoginController loginController = new LoginController(loginWindow);

            loginWindow.ShowDialog();

            Application.Run(new Form1());
        }
    }
}
