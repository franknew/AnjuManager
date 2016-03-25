using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOAFramework.Library.DAL;

namespace Anju.Fangke.Server.Model
{
    public partial class Menu_Role : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public string MenuID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string RoleID { get; set; }
        
    }
}