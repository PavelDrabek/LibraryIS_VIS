using LibraryIS_WinForm.Views;
using LIS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryIS_WinForm.Controllers {

    public class LoginController {

        ILoginView view = null;

        public LoginController(ILoginView view) {
            this.view = view;
            view.SetController(this);
        }

        public void Login()
        {
            LoginService loginService = new LoginService();
            if (loginService.Login(view.UserName, view.Password)) {
                view.OnLoginOK();
            } else {
                view.OnLoginError(loginService.GetErrorMsg());
            }
        }
    }
}
