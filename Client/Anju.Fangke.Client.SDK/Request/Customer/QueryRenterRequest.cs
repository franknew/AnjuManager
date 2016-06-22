using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class QueryRenterRequest : FangkeRequest<QueryOwnerResponse>
    {
        public override string GetApi()
        {
            return "Anju.Fangke.Server.Api.CustomerApi.QueryRenter";
        }

        public CustomerQueryForm form { get; set; }
    }
}
