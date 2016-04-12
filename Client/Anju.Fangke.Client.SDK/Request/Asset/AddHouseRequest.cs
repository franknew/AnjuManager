using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class AddHouseRequest : FangkeRequest<AddHouseResponse>
    {
        public FullHouse form { get; set; }

        public override string GetApi()
        {
            return "Anju.Fangke.Server.Api.AssetManagerApi.AddHouse";
        }
    }
}
