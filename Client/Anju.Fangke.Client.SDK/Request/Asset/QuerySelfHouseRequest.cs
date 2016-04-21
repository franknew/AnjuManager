using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class QuerySelfHouseRequest : FangkeRequest<QueryHouseResponse>
    {
        public override string GetApi()
        {
            return "Anju.Fangke.Server.Api.AssetManagerApi.QuerySelfHouse";
        }

        public HouseQueryForm form { get; set; }
    }
}
