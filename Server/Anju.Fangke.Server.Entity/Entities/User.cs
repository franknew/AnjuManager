using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOAFramework.Library.DAL;

namespace Anju.Fangke.Server.Model
{
    public class User : SimpleEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public string Password { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int? Enabled { get; set; }
        
    }
}