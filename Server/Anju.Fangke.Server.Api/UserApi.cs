using Anju.Fangke.Server.BLL;
using Anju.Fangke.Server.Form;
using Anju.Fangke.Server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Server.Api
{
    public class UserApi
    {
        private UserBLL bll = new UserBLL();

        [AuthFilter]
        public List<FullUser> Query(FullUserQueryForm form)
        {
            return bll.Query(form);
        }
    }
}
