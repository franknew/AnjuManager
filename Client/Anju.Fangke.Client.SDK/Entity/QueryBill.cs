using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public  class QueryBill
    {
        public string BuildingName { get; set; }
        public string BuildingID { get; set; }
        public string HouseName { get; set; }
        public string HouseID { get; set; }
        public int? RentDay { get; set; }
    }
}
