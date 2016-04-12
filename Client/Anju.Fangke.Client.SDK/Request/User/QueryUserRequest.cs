using SOAFramework.Service.SDK.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class QueryUserRequest : FangkeRequest<QueryUserResponse>
    {
        public override string GetApi()
        {
            return "Anju.Fangke.Server.Api.UserApi.Query";
        }

        [ArgMapping("form")]
        public FullUserQueryForm Form { get; set; }
    }
}
