using SOAFramework.Service.SDK.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class FangkeRequest<T> : BaseRequest<T> where T : BaseResponse
    {
        public override string GetApi()
        {
            throw new NotImplementedException();
        }

        public string token { get; set; }
    }
}
