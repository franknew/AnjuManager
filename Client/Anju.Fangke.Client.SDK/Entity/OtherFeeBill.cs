using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOAFramework.Library.DAL;

namespace Anju.Fangke.Client.SDK
{
    public partial class OtherFeeBill : SimpleEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public string BillID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? StartValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? EndValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string OtherFeeID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal? Fee { get; set; }

    }
}
