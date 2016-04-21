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
    [ServiceLayer(Module = "Anju.Fangke.Server.RoleApi")]
    [AuthFilter]
    public class RoleApi
    {
        private RoleBLL bll = new RoleBLL();
        public List<FullRoleInfo> QueryFullRole(RoleQueryForm form)
        {
            form.IsDeleted = 0;
            return bll.QueryFullRole(form);
        }

        public string AddFullRole(AddRoleServiceForm form)
        {
            form.IsDeleted = 0;
            return bll.AddRole(form);
        }

        public bool UpdateFullRole(AddRoleServiceForm form)
        {
            return bll.UpdateRole(form);
        }

        public bool Delete(string RoleID)
        {
            return bll.DeleteRole(RoleID);
        }

        public List<Role> Query(RoleQueryForm form)
        {
            form.IsDeleted = 0;
            return bll.Query(form);
        }
    }
}
