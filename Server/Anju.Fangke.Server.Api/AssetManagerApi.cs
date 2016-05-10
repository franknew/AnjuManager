using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Anju.Fangke.Server.BLL;
using Anju.Fangke.Server.DAL;
using Anju.Fangke.Server.Form;
using Anju.Fangke.Server.Model;
using DreamWorkflow.Engine;
using SOAFramework.Service.Core;

namespace Anju.Fangke.Server.Api
{
    [AuthFilter]
    public class AssetManagerApi
    {
        private HouseBLL housebll = new HouseBLL();
        private BuildingBLL buildingbll = new BuildingBLL();
        private RoomBLL roombll = new RoomBLL();
        private RentFeeBLL rentfeebll = new RentFeeBLL();
        private House_OtherFeeBLL hobll = new House_OtherFeeBLL();
        private OtherFeeBLL ofbll = new OtherFeeBLL();
        private House_CustomerBLL hcbll = new House_CustomerBLL();
        private CustomerBLL customerbll = new CustomerBLL();
        private UserBLL userbll = new UserBLL();
        private FollowupBLL followupbll = new FollowupBLL();

        [QueryAction]
        [DataAuthorityFilter]
        public List<FullHouse> QueryHouse(QueryHouseServiceForm form)
        {
            form.IsDeleted = 0;
            return housebll.QueryFullHouse(form);
        }

        [QueryAction]
        [DataAuthorityFilter]
        public List<FullHouse> QueryAllocateHouse(QueryHouseServiceForm form)
        {
            form.Enabled = 1;
            return QueryHouse(form);
        }

        [QueryAction]
        [DataAuthorityFilter]
        public List<FullHouse> QuerySelfHouse(QueryHouseServiceForm form)
        {
            var ids = Common.GetDataAuthorityUserIDList();
            form.OwnerIDs = ids;
            form.Enabled = 1;
            return QueryHouse(form);
        }

        [QueryAction]
        [DataAuthorityFilter]
        public List<FullHouse> QuerySelfAndUnallocateHouse(QueryHouseServiceForm form)
        {
            var ids = Common.GetDataAuthorityUserIDList();
            if (ids != null) ids.Add("");
            form.OwnerIDs = ids;
            form.Enabled = 1;
            return QueryHouse(form);
        }


        [QueryAction]
        public InitAssetManagerResultForm InitAssetManagement()
        {
            InitAssetManagerResultForm form = new InitAssetManagerResultForm();
            var buildings = buildingbll.Query(new BuildingQueryForm { IsDeleted = 0 });
            var firstbuilding = buildings.FirstOrDefault();
            var houses = QueryHouse(new QueryHouseServiceForm { BuildingID = firstbuilding.ID, Enabled = 1, IsDeleted = 0 });
            form.Buildings = buildings;
            form.Houses = houses;
            return form;
        }

        [EditAction]
        public AddHouseServiceForm AddHouse(FullHouse form)
        {
            if (form == null) throw new Exception("form不能为null");
            if (form.House == null) throw new Exception("House不能为null");
            form.House.Enabled = 1;
            form.House.IsDeleted = 0;
            string userid = userbll.GetCurrentUser().User.ID;
            form.House.Creator = userid;
            form.House.OwnerID = "";
            string houseid = housebll.Add(form.House);
            if (form.RentFee != null)
            {
                form.RentFee.Enabled = 1;
                form.RentFee.IsDeleted = 0;
                form.RentFee.Creator = userid;
                string rentfeeid = rentfeebll.Add(form.RentFee);
            }
            if (form.OtherFees != null)
            {
                foreach (var ho in form.OtherFees)
                {
                    hobll.Add(new House_OtherFee { HouseOrRoomID = houseid, Type = (int)HouseOrRoomType.House, OtherFeeID = ho.ID });
                }
            }
            if (!string.IsNullOrEmpty(form.Customer?.ID)) hcbll.Add(new House_Customer { HouseOrRoomID = form.House.ID, CustomerID = form.Customer.ID });
            if (form.Followups != null)
            {
                foreach (var f in form.Followups)
                {
                    f.HouseID = form.House.ID;
                    f.Creator = userid;
                    followupbll.Add(f);
                }
            }
            return new AddHouseServiceForm { HouseID = houseid, };
        }

        [EditAction]
        public bool UpdateHouse(FullHouse form)
        {
            if (form == null || form.House == null || string.IsNullOrEmpty(form.House.ID)) throw new Exception("form或者ID不能为空");
            string userid = userbll.GetCurrentUser().User.ID;
            form.House.LastUpdator = userid;
            housebll.Update(form.House);
            //if (form.RentFee != null) rentfeebll.Update(form.RentFee);
            hobll.Delete(new House_OtherFeeQueryForm { HouseOrRoomID = form.House.ID });
            if (form.OtherFees != null)
            {
                foreach (var ho in form.OtherFees)
                {
                    hobll.Add(new House_OtherFee { HouseOrRoomID = form.House.ID, Type = (int)HouseOrRoomType.House, OtherFeeID = ho.ID });
                }
            }
            hcbll.Delete(new House_CustomerQueryForm { HouseOrRoomID = form.House.ID });
            if (!string.IsNullOrEmpty(form.Customer?.ID)) hcbll.Add(new House_Customer { HouseOrRoomID = form.House.ID, CustomerID = form.Customer.ID });
            followupbll.Delete(new FollowupQueryForm { HouseID = form.House.ID });
            if (form.Followups != null)
            {
                foreach (var f in form.Followups)
                {
                    f.HouseID = form.House.ID;
                    f.LastUpdator = userid;
                    f.Creator = userid;
                    followupbll.Add(f);
                }
            }
            return true;
        }

        [DeleteAction]
        public bool DeleteHouse(HouseQueryForm form)
        {
            if (form == null || string.IsNullOrEmpty(form.ID)) throw new Exception("form或者ID不能为空");
            string userid = userbll.GetCurrentUser().User.ID;
            return housebll.Update(new House { ID = form.ID, IsDeleted = 1, LastUpdator = userid });
        }

        [QueryAction]
        public List<Building> QueryBuilding(BuildingQueryForm form)
        {
            form.IsDeleted = 0;
            return buildingbll.Query(form);
        }

        [EditAction]
        public string AddBuilding(Building form)
        {
            string userid = userbll.GetCurrentUser().User.ID;
            form.Creator = userid;
            return buildingbll.Add(form);
        }

        [EditAction]
        public bool UpdateBuilding(Building form)
        {
            string userid = userbll.GetCurrentUser().User.ID;
            form.LastUpdator = userid;
            return buildingbll.Update(form);
        }

        [DeleteAction]
        public bool DeleteBuilding(Building form)
        {
            if (form == null || string.IsNullOrEmpty(form.ID)) throw new Exception("form或者ID不能为空");
            string userid = userbll.GetCurrentUser().User.ID;
            return buildingbll.Update(new Building { ID = form.ID, IsDeleted = 1, LastUpdator = userid });
        }
        [QueryAction]
        public List<OtherFee> QueryOtherFee()
        {
            var list = TableCacheHelper.GetDataFromCache<OtherFee>(typeof(OtherFeeDao));
            return list.FindAll(t => t.IsDeleted == 0 && t.Enabled == 1);
        }
        [EditAction]
        public bool AllocateToUser(string houseID, string userID)
        {
            return housebll.Update(new House
            {
                ID = houseID,
                OwnerID = userID,
            });
        }
    }
}
