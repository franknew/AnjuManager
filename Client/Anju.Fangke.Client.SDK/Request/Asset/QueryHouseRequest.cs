using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class QueryHouseRequest : FangkeRequest<QueryHouseResponse>
    {
        public override string GetApi()
        {
            return "Anju.Fangke.Server.Api.AssetManagerApi.QueryHouse";
        }

        public HouseQueryForm form { get; set; }
    }
}
