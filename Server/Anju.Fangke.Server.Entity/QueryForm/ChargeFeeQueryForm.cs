using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOAFramework.Library.DAL;

namespace Anju.Fangke.Server.Form
{
    public class ChargeFeeQueryForm : SimpleQueryForm
    {
        public List<String> IDs { get; set;}
        public List<String> Creators { get; set;}
        public DateTime? UnitPrice_Start { get; set; }
        
        public DateTime? UnitPrice_End { get; set; }
        
        public string Remark { get; set; }
        
        public Int32? CalType { get; set; }
        
        public string Unit { get; set; }
        
        public Int32? PeriodTypeID { get; set; }
        
        public List<Int32> PeriodTypeIDs { get; set;}
        public UInt64? IsShared { get; set; }
        
        public string RoomID { get; set; }
        
        public List<String> RoomIDs { get; set;}
    }
}
