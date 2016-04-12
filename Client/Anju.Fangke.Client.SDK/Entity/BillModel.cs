using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class BillModel
    {
        public List<FullOtherFeeBill> OtherFeeBill { get; set; }

        public FullBill Bill { get; set; }
    }
}
