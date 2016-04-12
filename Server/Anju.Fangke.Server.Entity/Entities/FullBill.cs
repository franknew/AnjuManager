using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Server.Model
{ 
    public class FullBill : Bill
    {
        public string BuildingID { get; set; }
        public string BuildingName { get; set; }
        public string HouseID { get; set; }
        public string HouseName { get; set; }
        public string RentFeeID { get; set; }
        public int RentDay { get; set; }
        public decimal RentFee { get; set; }
    }
}
