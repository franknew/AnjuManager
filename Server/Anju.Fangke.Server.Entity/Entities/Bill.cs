using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOAFramework.Library.DAL;

namespace Anju.Fangke.Server.Model
{
    public partial class Bill : SimpleEntity
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
        public decimal? ShouldPay { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public decimal? Payed { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string Remark { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int? IsDeleted { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public DateTime? PayDay { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int? Year { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int? Month { get; set; }
        
    }
}