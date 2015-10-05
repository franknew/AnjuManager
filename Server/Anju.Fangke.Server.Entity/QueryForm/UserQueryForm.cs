using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOAFramework.Library.DAL;

namespace Anju.Fangke.Server.Form
{
    public class UserQueryForm : SimpleQueryForm
    {
        public string Password { get; set; }
        
        public UInt64? Enabled { get; set; }
        
    }
}