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
    public class HouseBLL
    {
        public List<House> Query(HouseQueryForm form)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            HouseDao dao = new HouseDao(mapper);
            return dao.Query(form);
        }

        public string Add(House House)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            HouseDao dao = new HouseDao(mapper);
            return dao.Add(House);
        }

        public bool Update(House House)
        {
            if (string.IsNullOrEmpty(House.ID)) throw new Exception("没有房间ID");
            ISqlMapper mapper = MapperHelper.GetMapper();
            HouseDao dao = new HouseDao(mapper);
            return dao.Update(new HouseUpdateForm { Entity = House, HouseQueryForm = new HouseQueryForm { ID = House.ID } });
        }

        public bool Delete(HouseQueryForm form)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            HouseDao dao = new HouseDao(mapper);
            return dao.Delete(form);
        }

        public List<FullHouse> QueryFullHouse(QueryHouseServiceForm form)
        {
            List<FullHouse> list = new List<FullHouse>();
            ISqlMapper mapper = MapperHelper.GetMapper();
            UserBLL userbll = new UserBLL();

            HouseDao dao = new HouseDao(mapper);
            House_CustomerDao hcdao = new House_CustomerDao(mapper);
            CustomerDao customerdao = new CustomerDao(mapper);
            BuildingDao buildingdao = new BuildingDao(mapper);
            FollowupDao followupdao = new FollowupDao(mapper);
            form.IsDeleted = 0;
            var house = dao.QueryFullHouse(form);
            var houseids = (from h in house select h.ID).ToList();
            var hos = hcdao.Query(new House_CustomerQueryForm { HouseOrRoomIDs = houseids });
            var customerids = (from ho in hos select ho.CustomerID).Distinct().ToList();
            var customers = customerdao.Query(new CustomerQueryForm { IDs = customerids, Enabled = 1, IsDeleted = 0 });
            var buildingids = (from h in house select h.BuildingID).Distinct().ToList();
            var buidlings = buildingdao.Query(new BuildingQueryForm { IDs = buildingids });
            //var ownerids = (from h in house where !string.IsNullOrEmpty(h.OwnerID.Trim()) select h.OwnerID).Distinct().ToList();
            var users = userbll.Query(new FullUserQueryForm { Enabled = 1, IsDeleted = 0 });
            var followups = followupdao.Query(new FollowupQueryForm { HouseIDs = houseids });
            var fullfollowup = (from f in followups
                                join u in users on f.Creator equals u.ID
                                select new FullFollowup
                                {
                                    ID = f.ID,
                                    Creator = f.Creator,
                                    CreateTime = f.CreateTime,
                                    HouseID = f.HouseID,
                                    Name = f.Name,
                                    CreatorName = u.CnName,
                                    Remark = f.Remark
                                }).ToList();
            //var rentfee = rentfeebll.Query(new RentFeeQueryForm { HouseOrRoomIDs = houseids, Type = (int)HouseOrRoomType.House, Enabled = 1, IsDeleted = 0 });
            //var house_otherfee = hobll.Query(new House_OtherFeeQueryForm { HouseOrRoomIDs = houseids, Type = (int)HouseOrRoomType.House });
            //var otherfee = ofbll.Query(new OtherFeeQueryForm { Enabled = 1, IsDeleted = 0 });
            foreach (var h in house)
            {
                FullHouse fh = new FullHouse
                {
                    House = h,
                    //RentFee = rentfee.Find(t => t.HouseOrRoomID.Equals(h.ID)),
                    //OtherFees = (from ho in house_otherfeeu
                    //join of in otherfee on ho.OtherFeeID equals of.ID
                    //where ho.HouseOrRoomID.Equals(h.ID)
                    //select of).ToList(),
                    Customer = (from ho in hos
                                join c in customers on ho.CustomerID equals c.ID
                                where ho.HouseOrRoomID.Equals(h.ID)
                                select c).FirstOrDefault(),
                    Building = buidlings.Find(t => t.ID.Equals(h.BuildingID)),
                    Owner = users.Find(t => t.ID.Equals(h.OwnerID)),
                    Followups = fullfollowup.FindAll(t => t.HouseID.Equals(h.ID)),
                };

                //rentfee.Remove(fh.RentFee);
                //house_otherfee.RemoveAll(t => t.HouseOrRoomID.Equals(fh.House.ID));
                list.Add(fh);
            }
            return list;
        }
    }
}
