using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOAFramework.Library.DAL;

namespace Anju.Fangke.Server.Form
{
    public class House_CustomerQueryForm : BaseQueryForm
    {
        public List<String> IDs { get; set;}
        public string CustomerID { get; set; }
        
        public List<String> CustomerIDs { get; set;}
        public string HouseOrRoomID { get; set; }
        
        public List<String> HouseOrRoomIDs { get; set;}
        public Int32? Type { get; set; }
        
        public Int32? Type_Start { get; set; }
        
        public Int32? Type_End { get; set; }
        
    }
}
