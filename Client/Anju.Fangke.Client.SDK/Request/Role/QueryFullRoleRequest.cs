using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class QueryFullRoleRequest : FangkeRequest<QueryFullRoleResponse>
    {
        public override string GetApi()
        {
            return "Anju.Fangke.Server.Api.RoleApi.QueryFullRole";
        }

        public RoleQueryForm form { get; set; }
    }
}
