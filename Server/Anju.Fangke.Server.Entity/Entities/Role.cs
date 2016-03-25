using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOAFramework.Library.DAL;

namespace Anju.Fangke.Server.Model
{
    public partial class Role : SimpleEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public string Remark { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int? IsDeleted { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int? DataAccessType { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ParentID { get; set; }
        
    }
}