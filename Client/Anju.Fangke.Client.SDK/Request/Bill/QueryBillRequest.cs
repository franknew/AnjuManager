using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class QueryBillRequest : FangkeRequest<QueryBillResponse>
    {
        public override string GetApi()
        {
            return "Anju.Fangke.Server.Api.BillApi.Query";
        }

        public QueryBill form { get; set; }
    }
}
