using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Server.Model
{
    public class FollowupModel
    {
        public Followup Followup { get; set; }

        public Building Building { get; set; }

        public House House { get; set; }

        public Customer Owner { get; set; }

        public User User { get; set; }
    }
}
