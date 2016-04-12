using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class UpdateBillModelRequest : FangkeRequest<CommonResponse>
    {
        public override string GetApi()
        {
            return base.GetApi();
        }

        public BillModel Bill { get; set; }
    }
}
