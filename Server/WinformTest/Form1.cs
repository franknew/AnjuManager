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
    }
}
