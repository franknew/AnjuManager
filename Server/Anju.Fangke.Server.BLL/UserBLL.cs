using Anju.Fangke.Server.DAL;
using Anju.Fangke.Server.Form;
using Anju.Fangke.Server.Model;
using IBatisNet.DataMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Server.BLL
{
    public class UserBLL
    {
        public List<FullUser> Query(FullUserQueryForm form)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            UserDao dao = new UserDao(mapper);
            return dao.QueryFullUser(form);
        }
    }
}
