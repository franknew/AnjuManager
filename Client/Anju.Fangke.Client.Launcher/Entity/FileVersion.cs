using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.Launcher
{
    public class FileVersion
    {
        public string FullFileName { get; set; }

        public DateTime? LastModifyTime { get; set; }

        public string FileName { get; set; }

        public bool NeedUpdate { get; set; }
    }
}
