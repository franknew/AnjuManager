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
    [ServiceLayer(Module = "Anju.Fangke.Server.AssetManagerApi")]
    [AuthFilter]
    public class AssetManagerApi
    {
        private HouseBLL housebll = new HouseBLL();
        private BuildingBLL buildingbll = new BuildingBLL();
        private RoomBLL roombll = new RoomBLL();
        private RentFeeBLL rentfeebll = new RentFeeBLL();
        private House_OtherFeeBLL hobll = new House_OtherFeeBLL();
        private OtherFeeBLL ofbll = new OtherFeeBLL();
        
        public List<FullHouse> QueryHouse(HouseQueryForm form)
        {
            List<FullHouse> list = new List<FullHouse>();
            var house = housebll.Query(form);
            var houseids = (from h in house select h.ID).ToList();
            var rentfee = rentfeebll.Query(new RentFeeQueryForm { HouseOrRoomIDs = houseids, Type = (int)HouseOrRoomType.House, Enabled = 1, IsDeleted = 0 });
            var house_otherfee = hobll.Query(new House_OtherFeeQueryForm { HouseOrRoomIDs = houseids, Type = (int)HouseOrRoomType.House });
            var otherfee = ofbll.Query(new OtherFeeQueryForm { Enabled = 1, IsDeleted = 0 });
            foreach (var h in house)
            {
                FullHouse fh = new FullHouse
                {
                    House = h,
                    RentFee = rentfee.Find(t => t.HouseOrRoomID.Equals(h.ID)),
                    OtherFees = (from ho in house_otherfee
                                 join of in otherfee on ho.OtherFeeID equals of.ID
                                 where ho.HouseOrRoomID.Equals(h.ID)
                                 select of).ToList(),
                };
                rentfee.Remove(fh.RentFee);
                house_otherfee.RemoveAll(t => t.HouseOrRoomID.Equals(fh.House.ID));
                list.Add(fh);
            }
            return list;
        }

        public InitAssetManagerResultForm InitAssetManagement()
        {
            InitAssetManagerResultForm form = new InitAssetManagerResultForm();
            var buildings = buildingbll.Query(new BuildingQueryForm { IsDeleted = 0 });
            var firstbuilding = buildings.FirstOrDefault();
            var houses = QueryHouse(new HouseQueryForm { BuildingID = firstbuilding.ID, Enabled = 1, IsDeleted = 0 });
            form.Buildings = buildings;
            form.Houses = houses;
            return form;
        }

        public AddHouseServiceForm AddHouse(FullHouse form)
        {
            if (form == null) throw new Exception("form不能为null");
            if (form.House == null) throw new Exception("House不能为null");
            string houseid = housebll.Add(form.House);
            string rentfeeid = rentfeebll.Add(form.RentFee);
            foreach (var ho in form.OtherFees)
            {
                hobll.Add(new House_OtherFee { HouseOrRoomID = houseid, Type = (int)HouseOrRoomType.House, OtherFeeID = ho.ID });
            }
            return new AddHouseServiceForm { HouseID = houseid, RentFeeID = rentfeeid };
        }

        public bool UpdateHouse(FullHouse form)
        {
            if (form == null || form.House == null || string.IsNullOrEmpty(form.House.ID)) throw new Exception("form或者ID不能为空");
            housebll.Update(form.House);
            rentfeebll.Update(form.RentFee);
            hobll.Delete(new House_OtherFeeQueryForm { HouseOrRoomID = form.House.ID });
            foreach (var ho in form.OtherFees)
            {
                hobll.Add(new House_OtherFee { HouseOrRoomID = form.House.ID, Type = (int)HouseOrRoomType.House, OtherFeeID = ho.ID });
            }
            return true;
        }

        public bool DeleteHouse(HouseQueryForm form)
        {
            if (form == null || string.IsNullOrEmpty(form.ID)) throw new Exception("form或者ID不能为空");
            return housebll.Update(new House { ID = form.ID, IsDeleted = 1 });
        }

        public List<Building> QueryBuilding(BuildingQueryForm form)
        {
            form.IsDeleted = 0;
            return buildingbll.Query(form);
        }

        public string AddBuilding(Building form)
        {
            return buildingbll.Add(form);
        }

        public bool UpdateBuilding(Building form)
        {
            return buildingbll.Update(form);
        }

        public bool DeleteBuilding(Building form)
        {
            if (form == null || string.IsNullOrEmpty(form.ID)) throw new Exception("form或者ID不能为空");
            return buildingbll.Update(new Building { ID = form.ID, IsDeleted = 1 });
        }

        public List<OtherFee> QueryOtherFee()
        {
            var list = TableCacheHelper.GetDataFromCache<OtherFee>(typeof(OtherFeeDao));
            return list.FindAll(t => t.IsDeleted == 0 && t.Enabled == 1);
        }
    }
}
