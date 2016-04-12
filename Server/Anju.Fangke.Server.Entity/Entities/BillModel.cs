using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Server.Model
{
    public class BillModel
    {
        public FullBill Bill { get; set; }
        public List<FullOtherFeeBill> OtherFeeBill { get; set; }
    }
}
