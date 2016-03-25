using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOAFramework.Library.DAL;

namespace Anju.Fangke.Server.Model
{
    public partial class ChargeFee : SimpleEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public decimal? UnitPrice { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string Remark { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int? CalType { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string Unit { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int? PeriodTypeID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int? IsShared { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string RoomID { get; set; }
        
    }
}