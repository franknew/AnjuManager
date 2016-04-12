using SOAFramework.Service.SDK.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class QueryUserResponse : BaseResponse
    {
        public List<FullUser> Users { get; set; }
    }
}
