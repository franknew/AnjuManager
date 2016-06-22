using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOAFramework.Service.SDK.Core;

namespace Anju.Fangke.Client.SDK
{
    public class QueryFullFollowupRequest : FangkeRequest<QueryFullFollowupResponse>
    {
        public override string GetApi()
        {
            return "Anju.Fangke.Server.Api.FollowupApi.QueryFullFollowup";
        }

        public FullFollowupQueryForm form { get; set; }
    }
}
