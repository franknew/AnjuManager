using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class QueryBuildingRequest : FangkeRequest<QueryBuildingResponse>
    {
        public override string GetApi()
        {
            return "Anju.Fangke.Server.Api.AssetManagerApi.QueryBuilding";
        }

        public BuildingQueryForm form { get; set; }
    }
}
