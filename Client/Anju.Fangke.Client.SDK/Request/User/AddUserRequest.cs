using SOAFramework.Service.SDK.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK.Request.User
{
    public class AddUserRequest : FangkeRequest<AddUserResponse>
    {
        public override string GetApi()
        {
            return "Anju.Fangke.Server.Api.UserApi.Add";
        }

        [ArgMapping("form")]
        public FullUser Form { get; set; }
    }
}
