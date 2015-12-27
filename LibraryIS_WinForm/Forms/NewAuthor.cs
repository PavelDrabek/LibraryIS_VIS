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
    public partial class NewAuthor : Form
    {
        public NewAuthor()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Author newAuthor = new Author();
            newAuthor.FirstName = tbFirstname.Text;
            newAuthor.MiddleName = tbMiddlename.Text;
            newAuthor.LastName = tbLastname.Text;

            new AuthorService().Insert(newAuthor);

            this.Close();
        }
    }
}
