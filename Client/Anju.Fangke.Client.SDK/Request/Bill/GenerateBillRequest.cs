using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class GenerateBillRequest : FangkeRequest<GenerateBillResponse>
    {
        public override string GetApi()
        {
            return "Anju.Fangke.Server.Api.BillApi.GenerateBill";
        }
    }
}
