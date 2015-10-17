using SOAFramework.Service.SDK.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class ChangePasswordRequest : FangkeRequest<CommonResponse>
    {
        public override string GetApi()
        {
            return "Anju.Fangke.Server.Api.UserApi.ChangePassword";
        }

        [ArgMapping("username")]
        public string UserName { get; set; }

        [ArgMapping("password")]
        public string Password { get; set; }
    }
}
