using LibraryIS_WinForm.Controllers;
using LIS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryIS_WinForm.Views
{
    public interface IBookListView
    {
        void SetController(BookListController controller);

        void ClearGrid();
        void AddToGrid(Book book);
        int GetSelectedIndex();

        string FilterText { get; set; }
    }
}
