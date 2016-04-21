using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOAFramework.Library.DAL;

namespace Anju.Fangke.Client.SDK
{
    public class CustomerQueryForm : SimpleQueryForm
    {
        public List<String> IDs { get; set; }
        public List<String> Creators { get; set; }
        public string Remark { get; set; }

        public string Mobile { get; set; }

        public string WX { get; set; }

        public string IdentityCode { get; set; }

        public Int32? Type { get; set; }

        public Int32? Type_Start { get; set; }

        public Int32? Type_End { get; set; }

        public UInt64? Enabled { get; set; }

        public UInt64? IsDeleted { get; set; }

    }
}
