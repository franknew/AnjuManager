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
    public class TakeHouseBLL
    {
        public List<FullHouse> Query(QueryHouseServiceForm form)
        {
            form.OwnerID = "";
            List<FullHouse> list = new List<FullHouse>();
            ISqlMapper mapper = MapperHelper.GetMapper();

            HouseDao dao = new HouseDao(mapper);
            House_CustomerDao hcdao = new House_CustomerDao(mapper);
            CustomerDao customerdao = new CustomerDao(mapper);
            BuildingDao buildingdao = new BuildingDao(mapper);
            var house = dao.QueryFullHouse(form);
            var houseids = (from h in house select h.ID).ToList();
            var hos = hcdao.Query(new House_CustomerQueryForm { HouseOrRoomIDs = houseids });
            var customerids = (from ho in hos select ho.CustomerID).Distinct().ToList();
            var customers = customerdao.Query(new CustomerQueryForm { IDs = customerids, Enabled = 1, IsDeleted = 0 });
            var buildingids = (from h in house select h.BuildingID).Distinct().ToList();
            var buidlings = buildingdao.Query(new BuildingQueryForm { IDs = buildingids });
            foreach (var h in house)
            {
                FullHouse fh = new FullHouse
                {
                    House = h,
                    Customer = (from ho in hos
                                join c in customers on ho.CustomerID equals c.ID
                                where ho.HouseOrRoomID.Equals(h.ID)
                                select c).FirstOrDefault(),
                    Building = buidlings.Find(t => t.ID.Equals(h.BuildingID)),
                };
                list.Add(fh);
            }
            return list;
        }
    }
}
