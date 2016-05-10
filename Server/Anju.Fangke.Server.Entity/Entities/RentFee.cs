using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOAFramework.Library.DAL;

namespace Anju.Fangke.Server.Model
{
    public partial class RentFee : SimpleEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public string HouseOrRoomID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int? Type { get; set; }
        
        /// <summary>
        /// 租金
        /// </summary>
        public decimal? RentMoney { get; set; }
        
        /// <summary>
        /// 收租周期
        /// </summary>
        public int? Cycle { get; set; }
        
        /// <summary>
        /// 周期类型
        /// </summary>
        public int? CycleType { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string Remark { get; set; }
        
        /// <summary>
        /// 押金
        /// </summary>
        public decimal? Deposit { get; set; }
        
        /// <summary>
        /// 租房日期
        /// </summary>
        public int? RentDay { get; set; }
        
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
        public DateTime? ExpiredTime { get; set; }
        
        /// <summary>
        /// 合同编号
        /// </summary>
        public string ContractCode { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public DateTime? RentDateStart { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public DateTime? RentDateEnd { get; set; }
        
    }
}