using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOAFramework.Library.DAL;

namespace Anju.Fangke.Server.Model
{
    public partial class Building : SimpleEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public string ProvinceID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string CityID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string AreaID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string Street { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int? IsDeleted { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int? FloorCount { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int? Enabled { get; set; }
        
        /// <summary>
        /// 片区ID
        /// </summary>
        public string DistrictID { get; set; }
        
    }
}