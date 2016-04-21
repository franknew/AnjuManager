using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class AddOwnerRequest : FangkeRequest<AddModelResponse>
    {
        public override string GetApi()
        {
            return "Anju.Fangke.Server.Api.CustomerApi.AddOwner";
        }

        public Customer form { get; set; }
    }
}
