using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOAFramework.Library.DAL;

namespace Anju.Fangke.Server.Model
{
    public partial class OtherFee : SimpleEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public int? FeeType { get; set; }
        
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
        public int? Enabled { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int? IsDeleted { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int? IsShared { get; set; }
        
    }
}