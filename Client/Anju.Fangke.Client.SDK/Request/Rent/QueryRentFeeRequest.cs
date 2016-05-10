using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class QueryRentFeeRequest : FangkeRequest<QueryHouseResponse>
    {
        public override string GetApi()
        {
            return "Anju.Fangke.Server.Api.RentApi.Query";
        }

        public HouseQueryForm form { get; set; }
    }
}
