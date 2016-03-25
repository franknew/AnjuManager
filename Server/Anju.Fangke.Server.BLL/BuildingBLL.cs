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
    public class BuildingBLL
    {
        public List<Building> Query(BuildingQueryForm form)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            BuildingDao dao = new BuildingDao(mapper);
            return dao.Query(form);
        }

        public string Add(Building building)
        {
            building.IsDeleted = 0;
            ISqlMapper mapper = MapperHelper.GetMapper();
            BuildingDao dao = new BuildingDao(mapper);
            return dao.Add(building);
        }

        public bool Update(Building building)
        {
            if (string.IsNullOrEmpty(building.ID))
            {
                throw new Exception("没有楼盘ID");
            }
            ISqlMapper mapper = MapperHelper.GetMapper();
            BuildingDao dao = new BuildingDao(mapper);
            return dao.Update(new BuildingUpdateForm { Entity = building, BuildingQueryForm = new BuildingQueryForm { ID = building.ID } });
        }

        public bool Delete(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new Exception("没有楼盘ID");
            }
            ISqlMapper mapper = MapperHelper.GetMapper();
            BuildingDao dao = new BuildingDao(mapper);
            return dao.Delete(new BuildingQueryForm { ID = id });
        }
    }
}
