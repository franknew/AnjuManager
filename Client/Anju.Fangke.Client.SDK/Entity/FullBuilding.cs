using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK.Entity
{
    public class FullBuilding : Building
    {
        public List<House> House { get; set; }

        public House CurrentHouse { get; set; }
    }
}
