using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOAFramework.Library.DAL;

namespace Anju.Fangke.Server.Form
{
    public class RoleQueryForm : SimpleQueryForm
    {
        public List<String> IDs { get; set;}
        public List<String> Creators { get; set;}
        public string Remark { get; set; }
        
        public UInt64? IsDeleted { get; set; }
        
        public Int32? DataAccessType { get; set; }
        
        public Int32? DataAccessType_Start { get; set; }
        
        public Int32? DataAccessType_End { get; set; }
        
        public string ParentID { get; set; }
        
        public List<String> ParentIDs { get; set;}
        public string LevelID { get; set; }
        
        public List<String> LevelIDs { get; set;}
        public UInt64? Enabled { get; set; }
        
    }
}
