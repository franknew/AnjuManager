using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Server.Form
{
    public class FullFollowupQueryForm : FollowupQueryForm
    {
        public string BuildingName { get; set; }

        public string HouseName { get; set; }

        public string OwnerName { get; set; }

        public string CreatorName { get; set; }
    }
}
