﻿using System;
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
    }
}
