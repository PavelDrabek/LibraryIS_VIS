using LibraryIS_WinForm.Controllers;
using LIS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryIS_WinForm.IViews
{
    public interface IUserListView
    {
        void SetController(UserListController controller);

        void ClearGrid();
        void AddToGrid(User user);
        int GetSelectedIndex();

        string FilterText { get; set; }
    }
}
