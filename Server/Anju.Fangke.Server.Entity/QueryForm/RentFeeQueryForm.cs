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
        
        public Int32? Type_Start { get; set; }
        
        public Int32? Type_End { get; set; }
        
        public Decimal? RentMoney { get; set; }
        
        public Decimal? RentMoney_Start { get; set; }
        
        public Decimal? RentMoney_End { get; set; }
        
        public Int32? Cycle { get; set; }
        
        public Int32? Cycle_Start { get; set; }
        
        public Int32? Cycle_End { get; set; }
        
        public Int32? CycleType { get; set; }
        
        public Int32? CycleType_Start { get; set; }
        
        public Int32? CycleType_End { get; set; }
        
        public string Remark { get; set; }
        
        public Decimal? Deposit { get; set; }
        
        public Decimal? Deposit_Start { get; set; }
        
        public Decimal? Deposit_End { get; set; }
        
        public List<String> Creators { get; set;}
        public Int32? RentDay { get; set; }
        
        public Int32? RentDay_Start { get; set; }
        
        public Int32? RentDay_End { get; set; }
        
        public UInt64? Enabled { get; set; }
        
        public UInt64? IsDeleted { get; set; }
        
        public DateTime? ExpiredTime { get; set; }
        
        public DateTime? ExpiredTime_Start { get; set; }
        
        public DateTime? ExpiredTime_End { get; set; }
        
        public string ContractCode { get; set; }
        
        public DateTime? RentDateStart { get; set; }
        
        public DateTime? RentDateStart_Start { get; set; }
        
        public DateTime? RentDateStart_End { get; set; }
        
        public DateTime? RentDateEnd { get; set; }
        
        public DateTime? RentDateEnd_Start { get; set; }
        
        public DateTime? RentDateEnd_End { get; set; }
        
    }
}
