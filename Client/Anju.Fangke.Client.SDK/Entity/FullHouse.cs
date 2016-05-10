using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class FullHouse
    {
        public DisplayHouse House { get; set; }

        public RentFee RentFee { get; set; }

        public List<OtherFee> OtherFees { get; set; }

        /// <summary>
        /// 业主
        /// </summary>
        public Customer Customer { get; set; }

        public Building Building { get; set; }

        /// <summary>
        /// 维护员工
        /// </summary>
        public FullUser Owner { get; set; }

        public List<Followup> Followups { get; set; }
    }
}
