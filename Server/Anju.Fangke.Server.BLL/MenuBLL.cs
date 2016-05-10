using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Anju.Fangke.Server.DAL;
using Anju.Fangke.Server.Form;
using Anju.Fangke.Server.Model;
using IBatisNet.DataMapper;

namespace Anju.Fangke.Server.BLL
{
    public class MenuBLL
    {
        public List<Menu> Query(MenuQueryForm form)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            MenuDao dao = new MenuDao(mapper);
            return dao.Query(form);
        }
    }
}
