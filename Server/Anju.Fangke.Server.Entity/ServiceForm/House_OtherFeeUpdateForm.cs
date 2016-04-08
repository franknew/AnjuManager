using Anju.Fangke.Server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOAFramework.Library.DAL;

namespace Anju.Fangke.Server.Form
{
    public class House_OtherFeeUpdateForm : BaseUpdateForm<House_OtherFee>
    {
        public House_OtherFeeQueryForm House_OtherFeeQueryForm { get; set; }
    }
}