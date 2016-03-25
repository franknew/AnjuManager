using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOAFramework.Library.DAL;

namespace Anju.Fangke.Server.Form
{
    public class RoomQueryForm : SimpleQueryForm
    {
        public List<String> IDs { get; set;}
        public string HouseID { get; set; }
        
        public List<String> HouseIDs { get; set;}
        public DateTime? Area_Start { get; set; }
        
        public DateTime? Area_End { get; set; }
        
        public string Remark { get; set; }
        
        public List<String> Creators { get; set;}
    }
}
