using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOAFramework.Service.Core;

namespace Anju.Fangke.Server.Api
{
    [ServiceLayer(Module = "Anju.Fangke.Server.Api")]
    public class LoginApi
    {
        [NoneAuthFilter]
        public string Login(string username, string password)
        {
            return null;
        }
    }
}
