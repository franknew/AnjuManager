using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class EditBuildingRequest : FangkeRequest<CommonResponse>
    {
        public override string GetApi()
        {
            return "Anju.Fangke.Server.Api.AssetManagerApi.UpdateBuilding";
        }

        public Building form { get; set; }
    }
}
