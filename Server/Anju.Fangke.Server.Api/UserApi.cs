using Anju.Fangke.Server.BLL;
using Anju.Fangke.Server.Form;
using Anju.Fangke.Server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SOAFramework.Service.Core;

namespace Anju.Fangke.Server.Api
{
    [AuthFilter]
    public class UserApi
    {
        private UserBLL bll = new UserBLL();

        [QueryAction]
        public List<FullUser> Query(FullUserQueryForm form)
        {
            form.IsDeleted = 0;
            return bll.Query(form);
        }

        [QueryAction]
        public PagingEntity<FullUser> QueryPaging(FullUserQueryForm form)
        {
            form.IsDeleted = 0;
            PagingEntity<FullUser> result = new PagingEntity<FullUser>();
            result.Record = bll.Query(form);
            result.RecordCount = bll.QueryCount(form);
            return result;
        }

        [EditAction]
        public string Add(FullUser form)
        {
            User user = new User
            {
                ID = form.ID,
                Enabled = form.Enabled,
                Password = form.Password,
                Name = form.Name,
                IsDeleted = 0,
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
            return bll.Add(user, ui, form.Roles);
        }

        [EditAction]
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
            return bll.Update(user, ui, form.Roles);
        }

        [DeleteAction]
        public bool Delete(List<string> ids)
        {
            if (ids == null) throw new Exception("没有ID");
            return bll.Delete(new UserQueryForm { IDs = ids });
        }

        [EditAction]
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
