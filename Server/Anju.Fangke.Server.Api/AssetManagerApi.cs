using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Anju.Fangke.Server.BLL;
using Anju.Fangke.Server.Form;
using Anju.Fangke.Server.Model;
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

        public List<House> QueryHouse(HouseQueryForm form)
        {
            return housebll.Query(form);
        }

        public InitAssetManagerResultForm InitAssetManagement()
        {
            InitAssetManagerResultForm form = new InitAssetManagerResultForm();
            var buildings = buildingbll.Query(new BuildingQueryForm { IsDeleted = 0 });
            var firstbuilding = buildings.FirstOrDefault();
            var houses = housebll.Query(new HouseQueryForm { BuildingID = firstbuilding.ID });
            form.Buildings = buildings;
            form.Houses = houses;
            return form;
        }

        public string AddHouse(House form)
        {
            if (form == null) throw new Exception("form不能为null");
            return housebll.Add(form);
        }

        public bool UpdateHouse(House form)
        {
            if (form == null || string.IsNullOrEmpty(form.ID)) throw new Exception("form或者ID不能为空");
            return housebll.Update(form);
        }

        public bool DeleteHouse(HouseQueryForm form)
        {
            if (form == null || string.IsNullOrEmpty(form.ID)) throw new Exception("form或者ID不能为空");
            return housebll.Delete(form.ID);
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
            return buildingbll.Delete(form.ID);
        }
    }
}
