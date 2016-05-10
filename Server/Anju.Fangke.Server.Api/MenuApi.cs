using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Anju.Fangke.Server.BLL;
using Anju.Fangke.Server.Form;
using Anju.Fangke.Server.Model;
using SOAFramework.Service.Core;

namespace Anju.Fangke.Server.Api
{
    [AuthFilter]
    public class MenuApi
    {
        private MenuBLL bll = new MenuBLL();

        [QueryAction]
        public List<Menu> Query(MenuQueryForm form)
        {
            return bll.Query(form);
        }
    }
}
