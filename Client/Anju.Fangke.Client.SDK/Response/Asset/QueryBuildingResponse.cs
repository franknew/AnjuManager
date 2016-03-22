using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Anju.Fangke.Client.SDK.Entity;
using SOAFramework.Service.SDK.Core;

namespace Anju.Fangke.Client.SDK
{
    public class QueryBuildingResponse : BaseResponse
    {
        public List<FullBuilding> List { get; set; }
    }
}
