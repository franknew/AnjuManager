using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Anju.Fangke.Server.BLL;
using Anju.Fangke.Server.Form;
using Anju.Fangke.Server.Model;

namespace Anju.Fangke.Server.Api
{
    [AuthFilter]
    public class LogonHistoryApi
    {
        private LogonHistoryBLL bll = new LogonHistoryBLL();

        public PagingEntity<FullLogonHistory> QueryPaging(FullLogonHistoryQueryForm form)
        {
            PagingEntity<FullLogonHistory> result = new PagingEntity<FullLogonHistory>();
            result.Record = bll.Query(form);
            result.RecordCount = bll.QueryCount(form);
            return result;
        }
    }
}
