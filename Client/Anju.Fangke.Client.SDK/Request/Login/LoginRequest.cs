using SOAFramework.Service.SDK.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class LoginRequest : BaseRequest<LoginResponse>
    {
        [ArgMapping("username")]
        public string UserName { get; set; }

        [ArgMapping("password")]
        public string Password { get; set; }

        public override string GetApi()
        {
            return "Anju.Fangke.Server.Api.LoginApi.Login";
        }
    }
}
