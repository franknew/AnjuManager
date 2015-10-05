using SOAFramework.Service.SDK.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.Launcher
{
    public class GetNecessaryFilesRequest : BaseRequest<GetNecessaryFilesResponse>
    {
        public override string GetApi()
        {
            return "Anju.Fangke.Server.Api.VersionApi.GetNecessaryFiles";
        }
    }
}
