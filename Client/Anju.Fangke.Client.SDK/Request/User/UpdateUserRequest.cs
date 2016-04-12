using SOAFramework.Service.SDK.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class UpdateUserRequest : FangkeRequest<CommonResponse>
    {
        public override string GetApi()
        {
            return "Anju.Fangke.Server.Api.UserApi.Update";
        }

        [ArgMapping("form")]
        public FullUser Form { get; set; }
    }
}
