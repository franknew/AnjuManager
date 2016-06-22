using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class AddRenterRequest : FangkeRequest<AddModelResponse>
    {
        public override string GetApi()
        {
            return "Anju.Fangke.Server.Api.CustomerApi.AddRenter";
        }

        public Customer form { get; set; }
    }
}
