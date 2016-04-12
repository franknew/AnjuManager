using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK.Entity
{
    public class FullBuilding : Building
    {
        public List<FullHouse> House { get; set; }

        public FullHouse CurrentHouse { get; set; }
    }
}
