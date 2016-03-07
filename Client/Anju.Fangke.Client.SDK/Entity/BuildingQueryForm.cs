using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOAFramework.Library.DAL;

namespace Anju.Fangke.Client.SDK
{
    public class BuildingQueryForm : SimpleQueryForm
    {
        public List<String> IDs { get; set; }
        public string ProvinceID { get; set; }

        public List<String> ProvinceIDs { get; set; }
        public string CityID { get; set; }

        public List<String> CityIDs { get; set; }
        public string AreaID { get; set; }

        public List<String> AreaIDs { get; set; }
        public string Street { get; set; }

        public List<String> Creators { get; set; }
        public UInt64? IsDeleted { get; set; }

        public string Remark { get; set; }

        public Int32? FloorCount { get; set; }

    }
}
