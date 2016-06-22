using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Anju.Fangke.Server.BLL;
using Anju.Fangke.Server.Form;
using Anju.Fangke.Server.Model;
using SOAFramework.Library;

namespace Anju.Fangke.Server.Api
{
    [AuthFilter]
    public class RentApi
    {
        private RentFeeBLL bll = new RentFeeBLL();

        [QueryAction]
        [DataAuthorityFilter]
        public List<FullHouse> Query(QueryHouseServiceForm form)
        {
            UserBLL userbll = new UserBLL();
            var ids = Common.GetDataAuthorityUserIDList();
            form.IsDeleted = 0;
            form.OwnerIDs = ids;
            form.IsOurs = 1;
            //MonitorCache.GetInstance().PushMessage(new CacheMessage { Message = "ids:" + string.Join(",", ids) }, SOAFramework.Library.CacheEnum.FormMonitor);
            return bll.QueryFullHouse(form);
        }

        [EditAction]
        public string Update(FullHouse form)
        {
            if (form == null) throw new Exception("form不能为null");
            if (form.RentFee == null) throw new Exception("RentFee不能为null");
            return bll.Update(form);
        }

        public string Add(FullHouse form)
        {
            if (form == null) throw new Exception("form不能为null");
            if (form.RentFee == null) throw new Exception("RentFee不能为null");
            return bll.Add(form);
        }
    }
}
