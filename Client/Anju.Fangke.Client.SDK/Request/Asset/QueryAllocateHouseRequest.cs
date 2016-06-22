using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class QueryAllocateHouseRequest : FangkeRequest<QueryHousePagingResponse>
    {
        public override string GetApi()
        {
            return "Anju.Fangke.Server.Api.AssetManagerApi.QueryAllocateHousePaging";
        }

        public HouseQueryForm form { get; set; }
    }
}
