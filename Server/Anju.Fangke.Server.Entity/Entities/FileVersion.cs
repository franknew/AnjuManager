using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Server.Model
{
    public class FileVersion
    {
        public string FullFileName { get; set; }

        public DateTime? LastModifyTime { get; set; }

        public string FileName { get; set; }
    }
}
