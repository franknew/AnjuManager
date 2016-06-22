using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class QuerySelfAndUnallocateHouseRequest : FangkeRequest<QueryHousePagingResponse>
    {
        public override string GetApi()
        {
            return "Anju.Fangke.Server.Api.AssetManagerApi.QuerySelfAndUnallocateHousePaging";
        }

        public HouseQueryForm form { get; set; }
    }
}
