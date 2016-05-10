using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class QueryAuthorityRequest : FangkeRequest<QueryAuthorityResponse>
    {
        public override string GetApi()
        {
            return "Anju.Fangke.Server.Api.RoleApi.QueryAuthority";
        }
    }
}
