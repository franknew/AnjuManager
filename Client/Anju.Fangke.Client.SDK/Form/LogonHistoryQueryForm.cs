using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOAFramework.Library.DAL;

namespace Anju.Fangke.Client.SDK
{
    public class LogonHistoryQueryForm : BaseQueryForm
    {
        public List<String> IDs { get; set; }
        public string UserID { get; set; }

        public List<String> UserIDs { get; set; }
        public string Token { get; set; }

        public DateTime? LogonTime { get; set; }

        public DateTime? LogonTime_Start { get; set; }

        public DateTime? LogonTime_End { get; set; }

        public string IP { get; set; }

        public DateTime? ActiveTime { get; set; }

        public DateTime? ActiveTime_Start { get; set; }

        public DateTime? ActiveTime_End { get; set; }

        public string UserName { get; set; }

    }
}
