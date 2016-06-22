using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public  class QueryOwnerRequest : FangkeRequest<QueryOwnerResponse>
    {
        public override string GetApi()
        {
            return "Anju.Fangke.Server.Api.CustomerApi.QueryOurHouseOwner";
        }

        public CustomerQueryForm form { get; set; }
    }
}
