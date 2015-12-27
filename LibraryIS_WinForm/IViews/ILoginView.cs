using LibraryIS_WinForm.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryIS_WinForm.Views {
   
    public interface ILoginView {
        void SetController(LoginController controller);

        void OnLoginOK();
        void OnLoginError(string errorMsg);
        
        string UserName { get; set; }
        string Password { get; set; }
    }
}
