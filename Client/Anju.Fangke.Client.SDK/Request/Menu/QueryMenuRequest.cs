using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class QueryMenuRequest : FangkeRequest<QueryMenuResponse>
    {
        public override string GetApi()
        {
            return "Anju.Fangke.Server.Api.MenuApi.Query";
        }

        public MenuQueryForm form { get; set; }
    }
}
