using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class FullFollowup
    {
        public Followup Followup { get; set; }

        public Building Building { get; set; }

        public House House { get; set; }

        public Customer Owner { get; set; }

        public FullUser User { get; set; }
    }
}
