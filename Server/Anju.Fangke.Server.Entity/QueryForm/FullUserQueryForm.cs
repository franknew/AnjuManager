using SOAFramework.Library.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Server.Form
{
    public class FullUserQueryForm : SimpleQueryForm
    {
        public string Password { get; set; }

        public int? Enabled { get; set; }

        public string QQ { get; set; }

        public string Mobile { get; set; }

        public string WX { get; set; }

        public string Address { get; set; }

        public string Identity { get; set; }

        public string CnName { get; set; }

        public string Remark { get; set; }

        public int? IsDeleted { get; set; }
    }
}
