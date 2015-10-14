using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOAFramework.Library.DAL;

namespace Anju.Fangke.Server.Model
{
    public class DataDictionary : SimpleEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public int? Value { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string Remark { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string DataDictionaryGroupID { get; set; }
        
    }
}