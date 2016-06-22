using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class QueryOurHouseRequest : FangkeRequest<QueryHousePagingResponse>
    {
        public override string GetApi()
        {
            return "Anju.Fangke.Server.Api.TakeHouseApi.QueryPaging";
        }
        public HouseQueryForm form { get; set; }
    }
}
