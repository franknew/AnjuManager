using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class QueryRenterPagingRequest : FangkeRequest<QueryCustomerPagingResponse>
    {
        public override string GetApi()
        {
            return "Anju.Fangke.Server.Api.CustomerApi.QueryRenterPaging";
        }

        public CustomerQueryForm form { get; set; }
    }
}
