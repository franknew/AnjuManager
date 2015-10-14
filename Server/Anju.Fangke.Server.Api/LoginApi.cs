using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOAFramework.Service.Core;
using Anju.Fangke.Server.BLL;
using Anju.Fangke.Server.Forms;

namespace Anju.Fangke.Server.Api
{
    [ServiceLayer(Module = "Anju.Fangke.Server.Api")]
    public class LoginApi
    {
        LoginBLL bll = new LoginBLL();

        [NoneAuthFilter]
        public LoginResultForm Login(string username, string password)
        {
            return bll.Login(username, password);
        }

        [AuthFilter]
        public bool Logout()
        {
            return bll.Logout();
        }
    }
}
