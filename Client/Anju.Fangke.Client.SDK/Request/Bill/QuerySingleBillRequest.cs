using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class QuerySingleBillRequest : FangkeRequest<QuerySingleBillResponse>
    {
        public override string GetApi()
        {
            return "Anju.Fangke.Server.Api.BillApi.QuerySingleBill";
        }

        public string BillID { get; set; }
    }
}
