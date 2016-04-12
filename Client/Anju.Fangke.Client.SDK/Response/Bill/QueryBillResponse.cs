using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using SOAFramework.Service.SDK.Core;

namespace Anju.Fangke.Client.SDK
{
    public class QueryBillResponse : BaseResponse
    {
        public DataTable Table { get; set; }
    }
}
