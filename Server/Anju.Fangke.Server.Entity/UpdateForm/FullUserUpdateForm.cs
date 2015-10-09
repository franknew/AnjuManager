using Anju.Fangke.Server.Model;
using SOAFramework.Library.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Server.Form
{
    public class FullUserUpdateForm : SimpleUpdateForm<FullUser>
    {
        public FullUserQueryForm FullUserQueryForm { get; set; }
    }
}
