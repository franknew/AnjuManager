using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class RoleQueryForm
    {
        public string Name { get; set; }

        public int? DataAccessType { get; set; }

        public string ParentID { get; set; }

        public int? Enabled { get; set; }
    }
}
