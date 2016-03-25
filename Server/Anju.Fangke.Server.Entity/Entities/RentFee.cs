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
        /// 
        /// </summary>
        public decimal? RentMoney { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int? Cycle { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int? CycleType { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string Remark { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public decimal? Deposit { get; set; }
        
    }
}