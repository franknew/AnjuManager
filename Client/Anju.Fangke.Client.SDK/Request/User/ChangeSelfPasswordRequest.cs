using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class ChangeSelfPasswordRequest : FangkeRequest<CommonResponse>
    {
        public override string GetApi()
        {
            return "Anju.Fangke.Server.Api.UserApi.ChangeSelfPassword";
        }

        public string oldpassword { get; set; }

        public string newpassword { get; set; }
    }
}
