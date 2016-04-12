using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOAFramework.Service.SDK.Core;

namespace Anju.Fangke.Client.SDK
{
    public class QueryOtherFeeResponse : BaseResponse
    {
        public List<OtherFee> List { get; set; }
    }
}
