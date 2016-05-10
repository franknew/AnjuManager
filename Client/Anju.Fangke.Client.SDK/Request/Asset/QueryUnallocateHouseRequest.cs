using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class QueryUnallocateHouseRequest : FangkeRequest<QueryHouseResponse>
    {
        public override string GetApi()
        {
            return "Anju.Fangke.Server.Api.TakeHouseApi.Query";
        }

        public HouseQueryForm form { get; set; }
    }
}
