using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOAFramework.Library.DAL;

namespace Anju.Fangke.Server.Form
{
    public class OtherFeeBillQueryForm : SimpleQueryForm
    {
        public List<String> IDs { get; set;}
        public string BillID { get; set; }
        
        public List<String> BillIDs { get; set;}
        public Int32? StartValue { get; set; }
        
        public Int32? StartValue_Start { get; set; }
        
        public Int32? StartValue_End { get; set; }
        
        public Int32? EndValue { get; set; }
        
        public Int32? EndValue_Start { get; set; }
        
        public Int32? EndValue_End { get; set; }
        
        public string OtherFeeID { get; set; }
        
        public List<String> OtherFeeIDs { get; set;}
        public Decimal? Fee { get; set; }
        
        public Decimal? Fee_Start { get; set; }
        
        public Decimal? Fee_End { get; set; }
        
        public List<String> Creators { get; set;}
    }
}
