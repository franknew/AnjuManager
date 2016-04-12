using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOAFramework.Library.DAL;

namespace Anju.Fangke.Server.Form
{
    public class LevelQueryForm : SimpleQueryForm
    {
        public List<String> IDs { get; set;}
        public Int32? DataAccessType { get; set; }
        
        public Int32? DataAccessType_Start { get; set; }
        
        public Int32? DataAccessType_End { get; set; }
        
        public List<String> Creators { get; set;}
    }
}
