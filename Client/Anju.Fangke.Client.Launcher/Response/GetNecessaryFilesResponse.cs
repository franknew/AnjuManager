﻿using SOAFramework.Service.SDK.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.Launcher
{
    public class GetNecessaryFilesResponse : BaseResponse
    {
        public List<FileVersion> Files { get; set; }
    }
}
