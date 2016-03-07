using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class DeleteHouseRequest : FangkeRequest<CommonResponse>
    {
        public HouseQueryForm form { get; set; }

        public override string GetApi()
        {
            return "Anju.Fangke.Server.Api.AssetManagerApi.DeleteHouse";
        }
    }
}
