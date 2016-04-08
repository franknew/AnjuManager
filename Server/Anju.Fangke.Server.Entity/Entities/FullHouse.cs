using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Server.Model
{
    public class FullHouse
    {
        public House House { get; set; }

        public RentFee RentFee { get; set; }

        public List<OtherFee> OtherFees { get; set; }
    }
}
