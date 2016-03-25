using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOAFramework.Library.DAL;

namespace Anju.Fangke.Server.Form
{
    public class HouseQueryForm : SimpleQueryForm
    {
        public List<String> IDs { get; set;}
        public string BuildingID { get; set; }
        
        public List<String> BuildingIDs { get; set;}
        public Int32? Floor { get; set; }
        
        public Int32? RoomCount { get; set; }
        
        public Int32? HallCount { get; set; }
        
        public Int32? ToiletCount { get; set; }
        
        public List<String> Creators { get; set;}
        public string Remark { get; set; }
        
        public Int32? RentType { get; set; }
        
        public Int32? RoomNumber { get; set; }
        
        public Int32? HallNumber { get; set; }
        
        public Int32? ToiletNumber { get; set; }
        
        public Int32? KitchenNumber { get; set; }
        
        public string OwnerID { get; set; }
        
        public List<String> OwnerIDs { get; set;}
        public DateTime? Area_Start { get; set; }
        
        public DateTime? Area_End { get; set; }
        
    }
}
