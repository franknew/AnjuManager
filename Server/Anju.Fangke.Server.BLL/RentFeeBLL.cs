using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Anju.Fangke.Server.BLL;
using Anju.Fangke.Server.DAL;
using Anju.Fangke.Server.Form;
using Anju.Fangke.Server.Model;
using IBatisNet.DataMapper;

namespace Anju.Fangke.Server.BLL
{
    public class RentFeeBLL
    {
        public string Add(RentFee fee)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            RentFeeDao dao = new RentFeeDao(mapper);
            return dao.Add(fee);
        }

        public List<RentFee> Query(RentFeeQueryForm form)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            RentFeeDao dao = new RentFeeDao(mapper);
            return dao.Query(form);
        }

        public bool Update(RentFee fee)
        {
            //if (string.IsNullOrEmpty(fee.ID)) throw new Exception("房租ID不能为空");
            ISqlMapper mapper = MapperHelper.GetMapper();
            RentFeeDao dao = new RentFeeDao(mapper);
            return dao.Update(new RentFeeUpdateForm
            {
                Entity = fee,
                RentFeeQueryForm = new RentFeeQueryForm { ID = fee.ID },
            });
        }

        public string Update(FullHouse house)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            House_OtherFeeDao hofdao = new House_OtherFeeDao(mapper);
            RentFeeDao rfdao = new RentFeeDao(mapper);
            RentFee rf = null;
            house.RentFee.HouseOrRoomID = house.House.ID;
            if (!string.IsNullOrEmpty(house.RentFee.ID)) rf = rfdao.Query(new RentFeeQueryForm { HouseOrRoomID = house.House.ID, Enabled = 1, IsDeleted = 0 }).FirstOrDefault();
            string id = house.RentFee.ID;
            if (rf == null) id = rfdao.Add(house.RentFee);
            else
                rfdao.Update(new RentFeeUpdateForm
                {
                    Entity = house.RentFee,
                    RentFeeQueryForm = new RentFeeQueryForm { ID = id },
                });
            hofdao.Delete(new House_OtherFeeQueryForm { HouseOrRoomID = house.House.ID });
            if (house.OtherFees != null)
            {
                foreach (var of in house.OtherFees)
                {
                    hofdao.Add(new House_OtherFee { HouseOrRoomID = house.House.ID, OtherFeeID = of.ID, Type = (int)HouseOrRoomType.House });
                }
            }
            return id;
        }

        public string Add(FullHouse house)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            House_OtherFeeDao hofdao = new House_OtherFeeDao(mapper);
            RentFeeDao rfdao = new RentFeeDao(mapper);
            RentFee rf = null;
            house.RentFee.HouseOrRoomID = house.House.ID;
            if (!string.IsNullOrEmpty(house.RentFee.ID)) rf = rfdao.Query(new RentFeeQueryForm { HouseOrRoomID = house.House.ID, Enabled = 1, IsDeleted = 0 }).FirstOrDefault();
            string id = house.RentFee.ID;
            if (rf != null) 
                rfdao.Update(new RentFeeUpdateForm
                {
                    Entity = new RentFee { Enabled = 0 },
                    RentFeeQueryForm = new RentFeeQueryForm { ID = rf.ID }
                });
            id = rfdao.Add(house.RentFee);
            if (house.OtherFees != null)
            {
                foreach (var of in house.OtherFees)
                {
                    hofdao.Add(new House_OtherFee { HouseOrRoomID = house.House.ID, OtherFeeID = of.ID, Type = (int)HouseOrRoomType.House });
                }
            }
            return id;
        }

        public List<FullHouse> QueryFullHouse(QueryHouseServiceForm form)
        {
            List<FullHouse> list = new List<FullHouse>();
            ISqlMapper mapper = MapperHelper.GetMapper();

            HouseDao dao = new HouseDao(mapper);
            House_CustomerDao hcdao = new House_CustomerDao(mapper);
            CustomerDao customerdao = new CustomerDao(mapper);
            BuildingDao buildingdao = new BuildingDao(mapper);
            RentFeeDao rfdao = new RentFeeDao(mapper);
            House_OtherFeeDao hofdao = new House_OtherFeeDao(mapper);
            OtherFeeDao ofdao = new OtherFeeDao(mapper);
            var house = dao.QueryFullHouse(form);
            var houseids = (from h in house select h.ID).ToList();
            var hcs = hcdao.Query(new House_CustomerQueryForm { HouseOrRoomIDs = houseids });
            var customerids = (from ho in hcs select ho.CustomerID).Distinct().ToList();
            var customers = customerdao.Query(new CustomerQueryForm { IDs = customerids, Enabled = 1, IsDeleted = 0 });
            var buildingids = (from h in house select h.BuildingID).Distinct().ToList();
            var buidlings = buildingdao.Query(new BuildingQueryForm { IDs = buildingids });
            var rentfees = rfdao.Query(new RentFeeQueryForm { HouseOrRoomIDs = houseids, Enabled = 1, IsDeleted = 0 });
            var rentfeeids = (from rf in rentfees select rf.ID).ToList();
            var hos = hofdao.Query(new House_OtherFeeQueryForm { HouseOrRoomIDs = houseids });
            var otherfeeids = (from ho in hos select ho.OtherFeeID).Distinct().ToList();
            var ofs = ofdao.Query(new OtherFeeQueryForm { IDs = otherfeeids });
            foreach (var h in house)
            {
                FullHouse fh = new FullHouse
                {
                    House = h,
                    Customer = (from ho in hcs
                                join c in customers on ho.CustomerID equals c.ID
                                where ho.HouseOrRoomID.Equals(h.ID)
                                select c).FirstOrDefault(),
                    Building = buidlings.Find(t => t.ID.Equals(h.BuildingID)),
                    RentFee = rentfees.Find(t => t.HouseOrRoomID.Equals(h.ID)),
                    OtherFees = (from ho in hos
                                 join of in ofs on ho.OtherFeeID equals of.ID
                                 where ho.HouseOrRoomID.Equals(h.ID)
                                 select of).ToList(),
                };
                list.Add(fh);
            }
            return list;
        }
    }
}
