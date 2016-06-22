using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOAFramework.Library.DAL;

namespace Anju.Fangke.Client.SDK
{
    public class FollowupQueryForm : SimpleQueryForm
    {
        public List<String> IDs { get; set; }
        public List<String> Creators { get; set; }
        public string Remark { get; set; }

        public string HouseID { get; set; }

        public List<String> HouseIDs { get; set; }
    }
}
