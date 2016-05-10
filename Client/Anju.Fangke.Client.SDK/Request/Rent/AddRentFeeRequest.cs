using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class AddRentFeeRequest : FangkeRequest<AddModelResponse>
    {
        public override string GetApi()
        {
            return "Anju.Fangke.Server.Api.RentApi.Add";
        }

        public FullHouse form { get; set; }
    }
}
