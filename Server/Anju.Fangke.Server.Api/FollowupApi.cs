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
    public class FollowupApi
    {
        FollowupBLL bll = new FollowupBLL();

        [AuthFilter]
        public PagingEntity<FollowupModel> QueryFullFollowup(FullFollowupQueryForm form)
        {
            HouseBLL housebll = new HouseBLL();
            BuildingBLL buildingbll = new BuildingBLL();
            UserBLL userbll = new UserBLL();
            CustomerBLL customerbll = new CustomerBLL();
            House_CustomerBLL hcbll = new House_CustomerBLL();
            PagingEntity<FollowupModel> result = new PagingEntity<FollowupModel>();
            result.Record = new List<FollowupModel>();
            var list = bll.QueryFullFollowup(form);
            var houseids = (from f in list select f.HouseID).Distinct().ToList();
            var houses = housebll.Query(new HouseQueryForm { IDs = houseids });
            var buildingids = (from h in houses select h.BuildingID).Distinct().ToList();
            var ownerids = (from h in houses where !string.IsNullOrEmpty(h.OwnerID) select h.OwnerID).Distinct().ToList();
            var userids = (from f in list select f.Creator).Distinct().ToList();
            var buildings = buildingbll.Query(new BuildingQueryForm { IDs = buildingids });
            var hcs = hcbll.Query(new House_CustomerQueryForm { HouseOrRoomIDs = houseids });
            var customerids = (from hc in hcs select hc.CustomerID).Distinct().ToList();
            var customers = customerbll.Query(new CustomerQueryForm { IDs = customerids });
            var users = userbll.SimpleQuery(new FullUserQueryForm { IDs = userids });
            list.ForEach(t =>
            {
                FollowupModel followup = new FollowupModel
                {
                    House = houses.Find(p => p.ID.Equals(t.HouseID)),
                    Followup = t,
                    User = users.Find(p=>p.ID.Equals(t.Creator)),
                };
                followup.Building = buildings.Find(p => p.ID.Equals(followup.House?.BuildingID));
                followup.Owner = (from hc in hcs
                                  join c in customers on hc.CustomerID equals c.ID
                                  where hc.HouseOrRoomID.Equals(followup.House?.ID) && c.Type == (int)CustomerType.业主
                                  select c).FirstOrDefault();
                result.Record.Add(followup);
            });
            result.RecordCount = bll.QueryFullFollowupCount(form);
            return result;
        }
    }
}
