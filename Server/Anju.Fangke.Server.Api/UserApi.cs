using Anju.Fangke.Server.BLL;
using Anju.Fangke.Server.Form;
using Anju.Fangke.Server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Server.Api
{
    [AuthFilter]
    public class UserApi
    {
        private UserBLL bll = new UserBLL();

        [AuthFilter]
        public List<FullUser> Query(FullUserQueryForm form)
        {
            return bll.Query(form);
        }

        public string Add(FullUser form)
        {
            User user = new User
            {
                ID = form.ID,
                Enabled = form.Enabled,
                Password = form.Password,
            };
            UserInfo ui = new UserInfo
            {
                CnName = form.CnName,
                Address = form.Address,
                Identity = form.Identity,
                Mobile = form.Mobile,
                QQ = form.QQ,
                Remark = form.Remark,
                WX = form.WX,
            };
            return bll.Add(user, ui);
        }
    }
}
