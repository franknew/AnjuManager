using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOAFramework.Library.DAL;

namespace Anju.Fangke.Server.Model
{
    public partial class House_OtherFee : BaseEntity
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
        public string OtherFeeID { get; set; }
        
    }
}