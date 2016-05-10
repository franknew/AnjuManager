using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class AddRoleRequest: FangkeRequest<AddModelResponse>
    {
        public override string GetApi()
        {
            return "Anju.Fangke.Server.Api.RoleApi.Add";
        }

        public FullRoleInfo form { get; set; }
    }
}
