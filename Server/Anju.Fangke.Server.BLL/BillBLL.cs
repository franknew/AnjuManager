using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Anju.Fangke.Server.DAL;
using Anju.Fangke.Server.Form;
using Anju.Fangke.Server.Model;
using IBatisNet.DataMapper;
using SOAFramework.Library;

namespace Anju.Fangke.Server.BLL
{
    public class BillBLL
    {
        public List<Bill> Query(BillQueryForm form)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            BillDao dao = new BillDao(mapper);
            return dao.Query(form);
        }

        public DataTable QueryFullBill(QueryFullBillServiceForm form)
        {
            #region 初始化数据
            ISqlMapper mapper = MapperHelper.GetMapper();
            BillDao dao = new BillDao(mapper);
            OtherFeeDao ofbll = new OtherFeeDao(mapper);
            OtherFeeBillDao ofbbll = new OtherFeeBillDao(mapper);
            var bills = dao.QueryFullBill(form);
            var billids = (from b in bills select b.ID).ToList();
            var houseids = (from b in bills select b.HouseOrRoomID).ToList();
            var otherfee = ofbll.Query(new OtherFeeQueryForm { });
            var otherfeebills = ofbbll.Query(new OtherFeeBillQueryForm { BillIDs = billids });
            var linkedOtherfeeBills = (from b in otherfeebills
                                       join o in otherfee
                                       on b.OtherFeeID equals o.ID
                                       select new { ID = b.ID, Fee = b.Fee, Name = o.Name, BillID = b.BillID, }).ToList();
            #endregion

            #region 设置字段mapping
            List<ToDataTableMapping> list = new List<ToDataTableMapping>
            {
                new ToDataTableMapping { OrignalName = "Name", MappingName = "账单名称" },
                new ToDataTableMapping { OrignalName = "ShouldPay",MappingName = "应收" },
                new ToDataTableMapping { OrignalName = "Payed", MappingName = "已收" },
                new ToDataTableMapping { OrignalName = "PayDay", MappingName="交租日期" },
                new ToDataTableMapping { OrignalName = "HouseOrRoomID", MappingName="房间ID" },
                new ToDataTableMapping { OrignalName = "ID", MappingName="ID" },
                new ToDataTableMapping { OrignalName = "BuildingName", MappingName="楼栋名称" },
                new ToDataTableMapping { OrignalName = "HouseName", MappingName = "房间名称" },
            };
            #endregion

            #region 组装数据
            DataTable table = bills.ToDataTable(list);
            foreach (var of in otherfee)
            {
                if (!table.Columns.Contains(of.Name))
                {
                    DataColumn column = new DataColumn(of.Name, typeof(decimal));
                    column.DefaultValue = 0;
                    table.Columns.Add(column);
                }
            }
            foreach (DataRow row in table.Rows)
            {
                foreach (var ofb in linkedOtherfeeBills)
                {
                    row[ofb.Name] = ofb.Fee;
                }
            }
            #endregion
            return table;
        }

        public int GenerateBill(string userid)
        {
            #region init data
            var now = DateTime.Now;
            var premonth = DateTime.Now.AddMonths(-1);
            HouseBLL housebll = new HouseBLL();
            RentFeeBLL rentfeebll = new RentFeeBLL();
            OtherFeeBLL otherfeebll = new OtherFeeBLL();
            House_OtherFeeBLL hobll = new House_OtherFeeBLL();
            OtherFeeBillBLL ofbbll = new OtherFeeBillBLL();
            var houses = housebll.Query(new HouseQueryForm { IsDeleted = 0, Enabled = 1, IsOurs = 1 });
            var houseids = (from h in houses select h.ID).ToList();
            var rentfees = rentfeebll.Query(new RentFeeQueryForm { Enabled = 1, IsDeleted = 0, RentDay_Start = 1, RentDay_End = now.Day, ExpiredTime_Start = now });
            var premonthbills = Query(new BillQueryForm { Year = premonth.Year, Month = premonth.Month, HouseOrRoomIDs = houseids });
            var currentmonethbill = Query(new BillQueryForm { Year = now.Year, Month = now.Month, HouseOrRoomIDs = houseids });
            var otherfee = otherfeebll.Query(new OtherFeeQueryForm { });
            var ho = hobll.Query(new House_OtherFeeQueryForm { HouseOrRoomIDs = houseids });
            var premonthbillids = (from b in premonthbills select b.ID).ToList();
            var premonthofb = ofbbll.Query(new OtherFeeBillQueryForm { BillIDs = premonthbillids });
            var linked_ho = (from h in ho
                             join of in otherfee on h.OtherFeeID equals of.ID
                             select new { House_OtherFee = h, Fee = of }).ToList();
            #endregion

            #region 生成当日和当日之前未生成的账单
            int i = 0;
            foreach (var rentfee in rentfees)
            {
                //如果存在就说明已经生成过了，这条房租账单不生成
                if (currentmonethbill.Exists(t => t.HouseOrRoomID.Equals(rentfee.HouseOrRoomID))) continue;
                var billid = Guid.NewGuid().ToString().Replace("-", "");
                Bill bill = new Bill
                {
                    ID = billid,
                    HouseOrRoomID = rentfee.HouseOrRoomID,
                    PayDay = new DateTime(now.Year, now.Month, rentfee.RentDay.Value),
                    Month = now.Month,
                    Year = now.Year,
                    Type = rentfee.Type,
                    Creator = userid,
                    ShouldPay = rentfee.RentMoney,
                    Name = now.ToString("yyyyMM月账单"),
                    
                };
                var house_otherfees = linked_ho.FindAll(t => t.House_OtherFee.HouseOrRoomID.Equals(rentfee.HouseOrRoomID));
                var premonthbill = premonthbills.Find(t => t.Year == premonth.Year && t.Month == premonth.Month);
                //生成其他费用账单
                foreach (var house_otherfee in house_otherfees)
                {
                    OtherFeeBill data = new OtherFeeBill
                    {
                        BillID = bill.ID,
                        OtherFeeID = house_otherfee.Fee.ID,
                        Name = house_otherfee.Fee.Name,
                        Creator = userid,
                        Fee = 0,
                        EndValue = 0,
                        StartValue = 0,
                    };
                    //把本月起始的计数设置为上月结束的计数
                    if (premonthbill != null) data.StartValue = premonthofb.Find(t => t.BillID.Equals(premonthbill.ID))?.EndValue;
                    ofbbll.Add(data);
                }
                Add(bill);
                i++;
            }
            #endregion
            return i;
        }

        public BillModel QuerySingle(string BillID)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            BillDao dao = new BillDao(mapper);
            OtherFeeDao ofdao = new OtherFeeDao(mapper);
            House_OtherFeeDao hodao = new House_OtherFeeDao(mapper);
            OtherFeeBillDao ofbdao = new OtherFeeBillDao(mapper);

            var bill = dao.QueryFullBill(new QueryFullBillServiceForm { ID = BillID }).FirstOrDefault();
            BillModel model = new BillModel
            {
                Bill = bill,
            };
            if (bill == null) return model;
            var house_otherfees = hodao.Query(new House_OtherFeeQueryForm { HouseOrRoomID = bill.HouseOrRoomID });
            var otherfeeids = (from ho in house_otherfees select ho.OtherFeeID).ToList();
            var otherfeebills = ofbdao.Query(new OtherFeeBillQueryForm { BillID = bill.ID, });
            var otherfees = ofdao.Query(new OtherFeeQueryForm { IDs = otherfeeids });
            var fullotherfeebills = new List<FullOtherFeeBill>();
            foreach (var ho in house_otherfees)
            {
                FullOtherFeeBill ofb = new FullOtherFeeBill
                {
                    House_OtherFee = ho,
                    OtherFee = otherfees.Find(t => t.ID.Equals(ho.OtherFeeID)),
                    OtherFeeBill = otherfeebills.Find(t => t.OtherFeeID.Equals(ho.OtherFeeID)),
                };
                fullotherfeebills.Add(ofb);
            }
            model.OtherFeeBill = fullotherfeebills;
            return model;
        }

        public bool Update(BillModel model)
        {
            if (model == null) throw new Exception("model不能为null");
            if (model.Bill == null) throw new Exception("bill不能为null");
            if (string.IsNullOrEmpty(model.Bill.ID)) throw new Exception("Bill.ID不能为空");
            ISqlMapper mapper = MapperHelper.GetMapper();
            BillDao billdao = new BillDao(mapper);
            OtherFeeBillDao ofbdao = new OtherFeeBillDao(mapper);
            billdao.Update(new BillUpdateForm
            {
                Entity = new Bill
                {
                    ShouldPay = model.Bill.ShouldPay,
                    Payed = model.Bill.Payed,
                },
                BillQueryForm = new BillQueryForm { ID = model.Bill.ID },
            });
            if (model.OtherFeeBill != null)
            {
                foreach (var ofb in model.OtherFeeBill)
                {
                    if (ofb.OtherFeeBill == null || string.IsNullOrEmpty(ofb.OtherFeeBill.ID)) continue;
                    ofbdao.Update(new OtherFeeBillUpdateForm
                    {
                        Entity = new OtherFeeBill
                        {
                            StartValue = ofb.OtherFeeBill.StartValue,
                            EndValue = ofb.OtherFeeBill.EndValue,
                            Fee = ofb.OtherFeeBill.Fee,
                        },
                        OtherFeeBillQueryForm = new OtherFeeBillQueryForm { ID = ofb.OtherFeeBill.ID },
                    });
                }
            }
            return true;
        }

        public string Add(Bill bill)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            BillDao dao = new BillDao(mapper);
            return dao.Add(bill);
        }

        public bool Update(BillUpdateForm bill)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            BillDao dao = new BillDao(mapper);
            return dao.Update(bill);
        }

        public bool Delete(BillQueryForm bill)
        {
            ISqlMapper mapper = MapperHelper.GetMapper();
            BillDao dao = new BillDao(mapper);
            return dao.Delete(bill);
        }
    }
}
