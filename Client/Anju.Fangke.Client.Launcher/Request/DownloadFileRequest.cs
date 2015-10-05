using SOAFramework.Service.SDK.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.Launcher
{
    public class DownloadFileRequest : BaseRequest<DownloadFileResponse>
    {
        public override string GetApi()
        {
            return "Anju.Fangke.Server.Api.VersionApi.DownloadNecessaryFile";
        }

        [ArgMapping("fileName")]
        public string FileName { get; set; }
    }
}
