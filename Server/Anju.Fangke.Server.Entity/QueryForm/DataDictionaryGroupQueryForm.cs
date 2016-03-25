using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOAFramework.Library.DAL;

namespace Anju.Fangke.Server.Form
{
    public class DataDictionaryGroupQueryForm : SimpleQueryForm
    {
        public List<String> IDs { get; set;}
        public List<String> Creators { get; set;}
        public string Remark { get; set; }
        
        public string ParentID { get; set; }
        
        public List<String> ParentIDs { get; set;}
    }
}
