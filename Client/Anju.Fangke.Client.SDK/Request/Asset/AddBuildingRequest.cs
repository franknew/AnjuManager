using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class AddBuildingRequest : FangkeRequest<AddModelResponse>
    {
        public Building form { get; set; }

        public override string GetApi()
        {
            return "Anju.Fangke.Server.Api.AssetManagerApi.AddBuilding";
        }
    }
}
