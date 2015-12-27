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

namespace LibraryIS_WinForm
{
    public partial class Form1 : Form
    {
        EntityService<Author> service = null;

        public Form1()
        {
            InitializeComponent();

            service = new AuthorService();
        }

        private void btnSelectAll_Click(object sender, EventArgs e) {
            String[] str = service.GetAll().Select(x => x.ToString()).ToArray();
            MessageBox.Show(string.Join("\n", str));
        }

        private void btnSelectById_Click(object sender, EventArgs e) {
            MessageBox.Show(service.Get(GetIDFromTextBox()).ToString());
        }

        private void btnUpdatePages_Click(object sender, EventArgs e) {
            Author entity = service.Get(GetIDFromTextBox());
            entity.FirstName = GetPagesFromTextBox();
            MessageBox.Show(service.Update(entity).ToString());
        }

        private void btnInsertPages_Click(object sender, EventArgs e) {
            Author entity = service.Get(GetIDFromTextBox());
            entity.FirstName = GetPagesFromTextBox();
            MessageBox.Show(service.Insert(entity).ToString());
        }

        private void btnDeleteById_Click(object sender, EventArgs e) {
            MessageBox.Show(service.Delete(GetIDFromTextBox()).ToString());
        }

        private int GetIDFromTextBox() {
            return int.Parse(tbID.Text);
        }

        private string GetPagesFromTextBox() {
            return tbPages.Text;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            LoginService ls = new LoginService();
            bool result = ls.Login(tbUsername.Text, tbPassword.Text);
            MessageBox.Show(result.ToString());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String[] str = service.Search(tbSearch.Text).Select(x => x.ToString()).ToArray();
            MessageBox.Show(string.Join("\n", str));
        }
    }
}
