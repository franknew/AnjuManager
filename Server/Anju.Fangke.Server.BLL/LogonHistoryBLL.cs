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
    public class LogonHistoryBLL
    {
        public List<FullLogonHistory> Query(FullLogonHistoryQueryForm form)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            LogonHistoryDao dao = new LogonHistoryDao(mapper);
            return dao.QueryFullLogonHistory(form);
        }

        public int QueryCount(FullLogonHistoryQueryForm form)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            LogonHistoryDao dao = new LogonHistoryDao(mapper);
            return dao.QueryFullLogonHistoryCount(form);
        }
    }
}
