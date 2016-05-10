using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Anju.Fangke.Server.Model;

namespace Anju.Fangke.Server.Form
{
    public class AddRoleServiceForm : Role
    {
        public List<AuthorityNodeForCheck> Authority { get; set; }

        public List<Menu> Menus { get; set; }
    }
}
