using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOAFramework.Library.DAL;

namespace Anju.Fangke.Server.Model
{
    public partial class Role_Module_Action : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public string RoleID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ModuleID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string ActionID { get; set; }
        
    }
}