using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOAFramework.Library.DAL;

namespace Anju.Fangke.Client.SDK
{
    public partial class Menu : SimpleEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public string Page { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ParentID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int? Enabled { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string Remark { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ImagePath { get; set; }

        public int? Index { get; set; }
        
    }
}