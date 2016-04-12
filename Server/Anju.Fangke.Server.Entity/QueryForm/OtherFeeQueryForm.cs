using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOAFramework.Library.DAL;

namespace Anju.Fangke.Server.Form
{
    public class OtherFeeQueryForm : SimpleQueryForm
    {
        public List<String> IDs { get; set;}
        public Int32? FeeType { get; set; }
        
        public Int32? FeeType_Start { get; set; }
        
        public Int32? FeeType_End { get; set; }
        
        public Decimal? UnitPrice { get; set; }
        
        public Decimal? UnitPrice_Start { get; set; }
        
        public Decimal? UnitPrice_End { get; set; }
        
        public List<String> Creators { get; set;}
        public string Remark { get; set; }
        
        public UInt64? Enabled { get; set; }
        
        public UInt64? IsDeleted { get; set; }
        
        public UInt64? IsShared { get; set; }
        
    }
}
