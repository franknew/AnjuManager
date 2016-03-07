using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Anju.Fangke.Server.Model;

namespace Anju.Fangke.Client.SDK
{
    public class AddHouseRequest : FangkeRequest<AddModelResponse>
    {
        public House form { get; set; }

        public override string GetApi()
        {
            return "Anju.Fangke.Server.Api.AssetManagerApi.AddHouse";
        }
    }
}
