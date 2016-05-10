using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Anju.Fangke.Server.BLL;
using Anju.Fangke.Server.DAL;
using Anju.Fangke.Server.Form;
using Anju.Fangke.Server.Model;
using IBatisNet.DataMapper;

namespace Anju.Fangke.Server.Api
{
    [AuthFilter]
    public class TakeHouseApi
    {
        private HouseBLL housebll = new HouseBLL();
        private TakeHouseBLL bll = new TakeHouseBLL();

        [QueryAction]
        public List<FullHouse> Query(QueryHouseServiceForm form)
        {
            form.IsDeleted = 0;
            form.Enabled = 1;
            return bll.Query(form);
        }

        [EditAction]
        public bool TaskHouse(House house)
        {
            if (house == null) throw new Exception("house不能为null");
            if (string.IsNullOrEmpty(house.ID)) throw new Exception("house.id不能为空");
            UserBLL userbll = new UserBLL();
            string userid = userbll.GetCurrentUser()?.User?.ID;
            return housebll.Update(new House
            {
                ID = house.ID,
                OwnerID = userid,
                RentFee = house.RentFee,
                RentDateStart = house.RentDateStart,
                RentDateEnd = house.RentDateEnd,
                ContractCode = house.ContractCode,
                RentRemark = house.RentRemark,
            });
        }
    }
}
