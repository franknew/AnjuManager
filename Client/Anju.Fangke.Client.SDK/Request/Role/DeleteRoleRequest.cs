using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class DeleteRoleRequest : FangkeRequest<CommonResponse>
    {
        public override string GetApi()
        {
            return "Anju.Fangke.Server.Api.RoleApi.Delete";
        }

        public string RoleID { get; set; }
    }
}
