using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOAFramework.Library.DAL;

namespace Anju.Fangke.Server.Form
{
    public class QueryFullBillServiceForm : SimpleQueryForm
    {
        public string BuildingName { get; set; }
        public string BuildingID { get; set; }
        public string HouseID { get; set; }
        public string HouseName { get; set; }
        public int? RentDay { get; set; }
        public DateTime? RentDate_Start { get; set; }
        public DateTime? RentDate_End { get; set; }
        public int? Status { get; set; }
    }
}
