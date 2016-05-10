using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOAFramework.Service.SDK.Core;

namespace Anju.Fangke.Client.SDK
{
    public class QueryMenuResponse : BaseResponse
    {
        public List<Menu> Menus { get; set; }
    }
}
