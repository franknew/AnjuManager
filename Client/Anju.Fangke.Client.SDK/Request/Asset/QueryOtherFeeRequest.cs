using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class QueryOtherFeeRequest : FangkeRequest<QueryOtherFeeResponse>
    {
        public override string GetApi()
        {
            return "Anju.Fangke.Server.Api.AssetManagerApi.QueryOtherFee";
        }

    }
}
