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
            var house = housebll.QueryFullHouse(new QueryHouseServiceForm { });

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
            TakeHouseBLL bll = new TakeHouseBLL();
            var list = bll.Query(new QueryHouseServiceForm { Enabled = 1, IsDeleted = 0 });
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
