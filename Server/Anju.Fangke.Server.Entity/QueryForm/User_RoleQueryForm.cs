using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOAFramework.Library.DAL;

namespace Anju.Fangke.Server.Form
{
    public class User_RoleQueryForm : BaseQueryForm
    {
        public string UserID { get; set; }
        
        public string RoleID { get; set; }
        
    }
}