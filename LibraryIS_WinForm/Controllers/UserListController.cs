using LibraryIS_WinForm.IViews;
using LIS.Entities;
using LIS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryIS_WinForm.Controllers
{
    public class UserListController
    {
        IUserListView view = null;
        UserService userService;
        List<User> users;

        public UserListController(IUserListView view)
        {
            this.view = view;

            userService = new UserService();
            view.SetController(this);
            Refresh();
        }

        public void Refresh()
        {
            view.FilterText = "";
            Show(userService.GetAll());
        }

        public void Show(List<User> list)
        {
            users = list;
            view.ClearGrid();
            foreach (User user in users) {
                view.AddToGrid(user);
            }

            //view.SetSelectedInGrid(books[0]);
        }

        public void Filter()
        {
            if (view.FilterText == "") {
                Show(userService.GetAll());
            } else {
                Show(userService.Search(view.FilterText));
            }
        }

        public User GetSelectedUser()
        {
            int selectedIndex = view.GetSelectedIndex();
            if (selectedIndex >= 0 && selectedIndex < users.Count) {
                return users[selectedIndex];
            } else {
                return null;
            }
        }
    }
}
