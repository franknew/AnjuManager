using Anju.Fangke.Server.Api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Anju.Fangke.Server.BLL;
using Anju.Fangke.Server.Form;
using Anju.Fangke.Server.Model;
using Anju.Fangke.Server;
using Anju.Fangke.Server.DAL;

namespace WinformTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VersionApi api = new VersionApi();
            var response = api.DownloadNecessaryFile("testfile.txt");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataDictionaryBLL bll = new DataDictionaryBLL();
            var list = bll.QueryByGroupName(new List<string> { "省份" });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HouseBLL bll = new HouseBLL();
            bll.Add(new Anju.Fangke.Server.Model.House
            {
                BuildingID = "1",
                Floor = 1,
                HallCount = 1,
                RoomCount = 1,
                RentType = 1,
                ToiletCount = 1,
                Remark = "test",
            });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OtherFeeBLL bll = new OtherFeeBLL();
            var result = bll.Query(new OtherFeeQueryForm { Enabled = 1, IsDeleted = 0 });
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HouseBLL housebll = new HouseBLL();
            BuildingBLL buildingbll = new BuildingBLL();
            RoomBLL roombll = new RoomBLL();
            RentFeeBLL rentfeebll = new RentFeeBLL();
            House_OtherFeeBLL hobll = new House_OtherFeeBLL();
            OtherFeeBLL ofbll = new OtherFeeBLL();
            House_CustomerBLL hcbll = new House_CustomerBLL();
            CustomerBLL customerbll = new CustomerBLL();
            List<FullHouse> list = new List<FullHouse>();
            var house = housebll.QueryFullHouse(new QueryHouseServiceForm { });
            var houseids = (from h in house select h.ID).ToList();
            var hos = hcbll.Query(new House_CustomerQueryForm { HouseOrRoomIDs = houseids });
            var customerids = (from ho in hos select ho.CustomerID).ToList();
            var customers = customerbll.Query(new CustomerQueryForm { IDs = customerids, Enabled = 1, IsDeleted = 0 });
            //var rentfee = rentfeebll.Query(new RentFeeQueryForm { HouseOrRoomIDs = houseids, Type = (int)HouseOrRoomType.House, Enabled = 1, IsDeleted = 0 });
            //var house_otherfee = hobll.Query(new House_OtherFeeQueryForm { HouseOrRoomIDs = houseids, Type = (int)HouseOrRoomType.House });
            //var otherfee = ofbll.Query(new OtherFeeQueryForm { Enabled = 1, IsDeleted = 0 });
            foreach (var h in house)
            {
                FullHouse fh = new FullHouse
                {
                    House = h,
                    //RentFee = rentfee.Find(t => t.HouseOrRoomID.Equals(h.ID)),
                    //OtherFees = (from ho in house_otherfee
                    //join of in otherfee on ho.OtherFeeID equals of.ID
                    //where ho.HouseOrRoomID.Equals(h.ID)
                    //select of).ToList(),
                    Customer = (from ho in hos
                                join c in customers on ho.CustomerID equals c.ID
                                where ho.HouseOrRoomID.Equals(h.ID)
                                select c).FirstOrDefault(),
                };
                //rentfee.Remove(fh.RentFee);
                //house_otherfee.RemoveAll(t => t.HouseOrRoomID.Equals(fh.House.ID));
                list.Add(fh);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BillBLL bll = new BillBLL();
            var list = bll.QueryFullBill(new QueryFullBillServiceForm { });
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BillBLL bll = new BillBLL();
            var list = bll.GenerateBill("test");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            BillBLL bll = new BillBLL();
            var bill = bll.QuerySingle("1");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            UserBLL bll = new UserBLL();
            var list = bll.Query(new FullUserQueryForm { Name = "ad" });
        }

        private void button10_Click(object sender, EventArgs e)
        {
            UserBLL bll = new UserBLL();
            RoleBLL rolebll = new RoleBLL();
            User_RoleDao dao = new User_RoleDao();
            var urs = dao.Query(new User_RoleQueryForm { UserID = "155f1092db4043a0b9ecd62a60ffc51d" }).ToList();
            var roleids = (from ur in urs select ur.RoleID).ToList();
            var role = rolebll.Query(new RoleQueryForm { IDs = roleids }).ToList();
            var result = rolebll.GetUserSubUserIDs("155f1092db4043a0b9ecd62a60ffc51d");
        }
    }
}
