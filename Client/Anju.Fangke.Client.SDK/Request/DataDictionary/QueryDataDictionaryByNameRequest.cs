using SOAFramework.Service.SDK.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class QueryDataDictionaryByNameRequest : FangkeRequest<QueryDataDictionaryByNameResponse>
    {
        [ArgMapping("nameList")]
        public List<string> NameList { get; set; }

        public override string GetApi()
        {
            return "Anju.Fangke.Server.Api.DataDictionaryApi.QueryByGroupName";
        }
    }
}
