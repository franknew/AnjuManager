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
    public class CustomerApi
    {
        private CustomerBLL bll = new CustomerBLL();
        private UserBLL userbll = new UserBLL();

        [EditAction]
        public string AddOwner(Customer form)
        {
            if (form == null) throw new Exception("form不能为null");
            form.IsDeleted = 0;
            form.Enabled = 1;
            form.Type = (int)CustomerType.业主;
            form.Creator = userbll.GetCurrentUserID();
            return bll.Add(form);
        }

        [EditAction]
        public string AddRenter(Customer form)
        {
            if (form == null) throw new Exception("form不能为null");
            form.IsDeleted = 0;
            form.Enabled = 1;
            form.Type = (int)CustomerType.租客;
            form.Creator = userbll.GetCurrentUser().User.ID;
            return bll.Add(form);
        }

        [EditAction]
        public bool Update(Customer form)
        {
            if (string.IsNullOrEmpty(form.ID)) throw new Exception("ID不能为空");
            form.LastUpdator = userbll.GetCurrentUser().User.ID;
            return bll.Update(new CustomerUpdateForm
            {
                Entity = form,
                CustomerQueryForm = new CustomerQueryForm { ID = form.ID },
            });
        }

        [DeleteAction]
        public bool Delete(string id)
        {
            if (string.IsNullOrEmpty(id)) throw new Exception("ID不能为空");
            string userid = userbll.GetCurrentUser().User.ID;
            return bll.Update(new CustomerUpdateForm
            {
                Entity = new Customer
                {
                    LastUpdator = userid,
                    IsDeleted = 1,
                },
                CustomerQueryForm = new CustomerQueryForm { ID = id },
            });
        }

        [QueryAction]
        [DataAuthorityFilter]
        public List<Customer> QueryOwner(CustomerQueryForm form)
        {
            if (form == null) form = new CustomerQueryForm();
            form.Type = (int)CustomerType.业主;
            form.IsDeleted = 0;
            List<string> userids = Common.GetDataAuthorityUserIDList();
            form.Creators = userids;
            return bll.Query(form);
        }

        [QueryAction]
        public List<Customer> QueryRenter(CustomerQueryForm form)
        {
            if (form == null) form = new CustomerQueryForm();
            form.Type = (int)CustomerType.租客;
            form.IsDeleted = 0;
            List<string> userids = Common.GetDataAuthorityUserIDList();
            form.Creators = userids;
            return bll.Query(form);
        }

        [QueryAction]
        public List<Customer> QueryAll()
        {
            return bll.Query(new CustomerQueryForm { Enabled = 1, IsDeleted = 0 });
        }
    }
}
