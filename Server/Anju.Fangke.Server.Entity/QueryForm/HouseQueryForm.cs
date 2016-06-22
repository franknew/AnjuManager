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
        
        public Int32? Floor_Start { get; set; }
        
        public Int32? Floor_End { get; set; }
        
        public Int32? RoomCount { get; set; }
        
        public Int32? RoomCount_Start { get; set; }
        
        public Int32? RoomCount_End { get; set; }
        
        public Int32? HallCount { get; set; }
        
        public Int32? HallCount_Start { get; set; }
        
        public Int32? HallCount_End { get; set; }
        
        public Int32? ToiletCount { get; set; }
        
        public Int32? ToiletCount_Start { get; set; }
        
        public Int32? ToiletCount_End { get; set; }
        
        public List<String> Creators { get; set;}
        public string Remark { get; set; }
        
        public Int32? RentType { get; set; }
        
        public Int32? RentType_Start { get; set; }
        
        public Int32? RentType_End { get; set; }
        
        public Int32? RoomNumber { get; set; }
        
        public Int32? RoomNumber_Start { get; set; }
        
        public Int32? RoomNumber_End { get; set; }
        
        public Int32? HallNumber { get; set; }
        
        public Int32? HallNumber_Start { get; set; }
        
        public Int32? HallNumber_End { get; set; }
        
        public Int32? ToiletNumber { get; set; }
        
        public Int32? ToiletNumber_Start { get; set; }
        
        public Int32? ToiletNumber_End { get; set; }
        
        public Int32? KitchenNumber { get; set; }
        
        public Int32? KitchenNumber_Start { get; set; }
        
        public Int32? KitchenNumber_End { get; set; }
        
        public string OwnerID { get; set; }
        
        public List<String> OwnerIDs { get; set;}
        public Decimal? Area { get; set; }
        
        public Decimal? Area_Start { get; set; }
        
        public Decimal? Area_End { get; set; }
        
        public UInt64? IsRented { get; set; }
        
        public UInt64? Enabled { get; set; }
        
        public UInt64? IsDeleted { get; set; }
        
        public Decimal? Cost { get; set; }
        
        public Decimal? Cost_Start { get; set; }
        
        public Decimal? Cost_End { get; set; }
        
        public Decimal? SalePrice { get; set; }
        
        public Decimal? SalePrice_Start { get; set; }
        
        public Decimal? SalePrice_End { get; set; }
        
        public string KeyCode { get; set; }
        
        public Int32? Status { get; set; }
        
        public Int32? Status_Start { get; set; }
        
        public Int32? Status_End { get; set; }
        
        public Int32? DecorationType { get; set; }
        
        public Int32? DecorationType_Start { get; set; }
        
        public Int32? DecorationType_End { get; set; }
        
        public Decimal? RentFee { get; set; }
        
        public Decimal? RentFee_Start { get; set; }
        
        public Decimal? RentFee_End { get; set; }
        
        public DateTime? RentDateStart { get; set; }
        
        public DateTime? RentDateStart_Start { get; set; }
        
        public DateTime? RentDateStart_End { get; set; }
        
        public DateTime? RentDateEnd { get; set; }
        
        public DateTime? RentDateEnd_Start { get; set; }
        
        public DateTime? RentDateEnd_End { get; set; }
        
        public string RentRemark { get; set; }
        
        public string ContractCode { get; set; }
        
        public UInt64? IsOurs { get; set; }
        
        public Int32? RentDay { get; set; }
        
        public Int32? RentDay_Start { get; set; }
        
        public Int32? RentDay_End { get; set; }
        
    }
}
