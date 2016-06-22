using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOAFramework.Service.SDK.Core;

namespace Anju.Fangke.Client.SDK
{
    public class QueryFullFollowupResponse : BaseResponse
    {
        public PagingEntity<FullFollowup> Data { get; set; }
    }
}
