using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOAFramework.Library.DAL;

namespace Anju.Fangke.Server.Form
{
    public class RentFeeQueryForm : SimpleQueryForm
    {
        public List<String> IDs { get; set;}
        public string HouseOrRoomID { get; set; }
        
        public List<String> HouseOrRoomIDs { get; set;}
        public Int32? Type { get; set; }
        
        public DateTime? RentMoney_Start { get; set; }
        
        public DateTime? RentMoney_End { get; set; }
        
        public Int32? Cycle { get; set; }
        
        public Int32? CycleType { get; set; }
        
        public string Remark { get; set; }
        
        public DateTime? Deposit_Start { get; set; }
        
        public DateTime? Deposit_End { get; set; }
        
        public List<String> Creators { get; set;}
    }
}
