using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class UpdateRoleReuqest : FangkeRequest<CommonResponse>
    {
        public override string GetApi()
        {
            return "Anju.Fangke.Server.Api.RoleApi.UpdateFullRole";
        }

        public FullRoleInfo form { get; set; }
    }
}
