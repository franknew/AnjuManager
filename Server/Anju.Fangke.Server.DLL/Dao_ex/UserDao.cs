using Anju.Fangke.Server.Form;
using Anju.Fangke.Server.Model;
using IBatisNet.DataMapper;
using SOAFramework.Library.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Server.DAL
{
    public partial class UserDao : SimpleDao<User, UserQueryForm, UserUpdateForm>
    {
        public List<FullUser> QueryFullUser(FullUserQueryForm form)
        {
            return Mapper.QueryForList<FullUser>("QueryFullUser", form).ToList();
        }

    }
}
