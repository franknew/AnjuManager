using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOAFramework.Library.DAL;

namespace Anju.Fangke.Server.Model
{
    public partial class House : SimpleEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public string BuildingID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int? Floor { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int? RoomCount { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int? HallCount { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int? ToiletCount { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string Remark { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int? RentType { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int? RoomNumber { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int? HallNumber { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int? ToiletNumber { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int? KitchenNumber { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string OwnerID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public decimal? Area { get; set; }
        
        /// <summary>
        /// 是否出租
        /// </summary>
        public int? IsRented { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int? Enabled { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int? IsDeleted { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public decimal? Cost { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public decimal? SalePrice { get; set; }
        
        /// <summary>
        /// 钥匙编号
        /// </summary>
        public string KeyCode { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int? Status { get; set; }
        
        /// <summary>
        /// 装修类型
        /// </summary>
        public int? DecorationType { get; set; }
        
        /// <summary>
        /// 收房租金
        /// </summary>
        public decimal? RentFee { get; set; }
        
        /// <summary>
        /// 收房租期
        /// </summary>
        public DateTime? RentDateStart { get; set; }
        
        /// <summary>
        /// 收房租期
        /// </summary>
        public DateTime? RentDateEnd { get; set; }
        
        /// <summary>
        /// 收房备注
        /// </summary>
        public string RentRemark { get; set; }
        
        /// <summary>
        /// 合同编号
        /// </summary>
        public string ContractCode { get; set; }
        
    }
}