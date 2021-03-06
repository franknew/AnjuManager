using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOAFramework.Library.DAL;

namespace Anju.Fangke.Server.Form
{
    public class DataDictionaryQueryForm : SimpleQueryForm
    {
        public List<String> IDs { get; set;}
        public Int32? Value { get; set; }
        
        public Int32? Value_Start { get; set; }
        
        public Int32? Value_End { get; set; }
        
        public List<String> Creators { get; set;}
        public string Remark { get; set; }
        
        public string DataDictionaryGroupID { get; set; }
        
        public List<String> DataDictionaryGroupIDs { get; set;}
    }
}
