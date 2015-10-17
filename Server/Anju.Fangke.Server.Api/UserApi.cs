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
                Name = form.Name,
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

        public bool Update(FullUser form)
        {
            User user = new User
            {
                ID = form.ID,
                Enabled = form.Enabled,
                Name = form.Name,
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
            bll.Update(user, ui);
            return true;
        }

        public bool Delete(List<string> ids)
        {
            return bll.Delete(ids);
        }

        public bool ChangePassword(string username, string password)
        {
            return bll.ChangePassword(username, password);
        }

        public bool ChangeSelfPassword(string oldpassword, string newpassword)
        {
            return bll.ChangeSelfPassword(oldpassword, newpassword);
        }
    }
}
