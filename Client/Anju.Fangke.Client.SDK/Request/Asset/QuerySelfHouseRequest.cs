using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class QuerySelfHouseRequest : FangkeRequest<QueryHousePagingResponse>
    {
        public override string GetApi()
        {
            return "Anju.Fangke.Server.Api.AssetManagerApi.QuerySelfHousePaging";
        }

        public HouseQueryForm form { get; set; }
    }
}
