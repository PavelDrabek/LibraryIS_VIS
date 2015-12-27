using LibraryIS_WinForm.Controllers;
using LIS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryIS_WinForm.Views
{
    public interface IBookView
    {
        void SetController(BookController controller);

        int ID { get; set; }
        string Title { get; set; }
        Author author { get; set; }
        Genre genre { get; set; }
        string ISBN { get; set; }
        Publisher publisher { get; set; }
        int Pages { get; set; }
    }
}
