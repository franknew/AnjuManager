using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOAFramework.Library.DAL;

namespace Anju.Fangke.Server.Form
{
    public class BillQueryForm : SimpleQueryForm
    {
        public List<String> IDs { get; set;}
        public string HouseOrRoomID { get; set; }
        
        public List<String> HouseOrRoomIDs { get; set;}
        public Int32? Type { get; set; }
        
        public Int32? Type_Start { get; set; }
        
        public Int32? Type_End { get; set; }
        
        public Decimal? ShouldPay { get; set; }
        
        public Decimal? ShouldPay_Start { get; set; }
        
        public Decimal? ShouldPay_End { get; set; }
        
        public Decimal? Payed { get; set; }
        
        public Decimal? Payed_Start { get; set; }
        
        public Decimal? Payed_End { get; set; }
        
        public string Remark { get; set; }
        
        public List<String> Creators { get; set;}
        public UInt64? IsDeleted { get; set; }
        
        public DateTime? PayDay { get; set; }
        
        public DateTime? PayDay_Start { get; set; }
        
        public DateTime? PayDay_End { get; set; }
        
        public Int32? Year { get; set; }
        
        public Int32? Year_Start { get; set; }
        
        public Int32? Year_End { get; set; }
        
        public Int32? Month { get; set; }
        
        public Int32? Month_Start { get; set; }
        
        public Int32? Month_End { get; set; }
        
    }
}
