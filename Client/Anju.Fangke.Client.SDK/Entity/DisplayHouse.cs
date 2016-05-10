using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.SDK
{
    public class DisplayHouse : House
    {
        public decimal? RentFee { get; set; }

        public string DecorationTypeName
        {
            get
            {
                string text = "";
                if (DecorationType.HasValue) text = Enum.GetName(typeof(DecorationType), this.DecorationType);
                return text;
            }
        }

        public string StatusName
        {
            get
            {
                string text = "";
                if (Status.HasValue) text = Enum.GetName(typeof(HouseType), this.Status);
                return text;
            }
        }
    }
}
